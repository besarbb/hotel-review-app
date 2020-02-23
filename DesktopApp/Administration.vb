Imports System.IO
Public Class Administration
    Private Sub Administration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bwsImageLoad.Filter = "Image files (*.jpg, *.jpeg, *.png) |*.jpg; *.jpeg; *.png"
        Using storeDb As New StoreDBDataContext
            Dim storeId = storeDb.Users.SingleOrDefault(Function(d) d.ID = GlobalConfClass.user).StoreID
            Dim store = storeDb.Stores.SingleOrDefault(Function(d) d.ID = storeId)
            txtCompanyName.Text = store.Store_Name
            txtCompanyMarketingLine.Text = store.Store_Marketing_Line
        End Using

    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        bwsImageLoad.ShowDialog()

    End Sub

    Private Sub bwsImageLoad_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles bwsImageLoad.FileOk
        txtCompanyLogoPath.Text = bwsImageLoad.FileName
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Using storeDb As New StoreDBDataContext
                Dim storeId = storeDb.Users.SingleOrDefault(Function(d) d.ID = GlobalConfClass.user).StoreID
                Dim store = storeDb.Stores.SingleOrDefault(Function(d) d.ID = storeId)

                store.Store_Name = txtCompanyName.Text
                store.Store_Marketing_Line = txtCompanyMarketingLine.Text
                If bwsImageLoad.FileName <> "" Then
                    store.Store_Logo = File.ReadAllBytes(txtCompanyLogoPath.Text)
                End If

                storeDb.SubmitChanges()

                lblInfo.ForeColor = Color.Green
                lblInfo.Text = "Your changes have been saved!"
                lblInfo.Visible = True
            End Using
        Catch ex As Exception
            lblInfo.ForeColor = Color.Red
            lblInfo.Text = "Something went wrong! Changes couldn't be saved."
            lblInfo.Visible = True
        End Try

    End Sub
End Class