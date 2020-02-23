Imports System.Configuration
Public Class LogIn
    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Try
            Using storedb As New StoreDBDataContext
                Dim user = storedb.Users.SingleOrDefault(Function(d) d.Username = txtUsername.Text And d.HashedPassword = txtPassword.Text)
                If user IsNot Nothing And GlobalConfClass.loggedIn <> True Then
                    GlobalConfClass.user = user.ID
                    GlobalConfClass.loggedIn = True

                    Form1.Show()
                    Me.Close()
                ElseIf user IsNot Nothing Then
                    GlobalConfClass.user = user.ID
                    Administration.Show()
                    Me.Close()
                Else
                    lblWarning.Visible = True
                End If



            End Using
        Catch ex As Exception
            lblWarning.Text = "There was a problem with your request. Please try again."
            lblWarning.Visible = True
        End Try

    End Sub
End Class