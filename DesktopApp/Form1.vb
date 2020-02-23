Imports System.Drawing.Imaging
Imports System.Drawing
Imports System.IO
Imports System.Configuration
Imports DesktopApp.My.Resources.Resource1
Imports ZXing


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Using storeDb As New StoreDBDataContext
            Dim user = storeDb.Users.SingleOrDefault(Function(d) d.ID = GlobalConfClass.user)

            Dim store = storeDb.Stores.SingleOrDefault(Function(d) d.ID = user.StoreID)

            Dim logoStream = New MemoryStream(store.Store_Logo.ToArray, 0, store.Store_Logo.Length)
            imgCompanyLogoCenter.Image = Image.FromStream(logoStream)


            imgConfused.Location = New Point((Me.Width / 2) - (imgConfused.Width / 2), (Me.Height / 2) - (imgConfused.Height / 2))
            imgSmiley.Location = New Point((imgConfused.Location.X / 2) - (imgSmiley.Width / 2), (Me.Height / 2) - (imgSmiley.Height / 2))
            Dim thirdLocationX = imgConfused.Location.X + imgSmiley.Location.X + imgAngry.Width
            imgAngry.Location = New Point(thirdLocationX, (Me.Height / 2) - (imgSmiley.Height / 2))


            Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
            lblTime.Location = New Point(Screen.PrimaryScreen.Bounds.Width - (TextRenderer.MeasureText(Format(Now, "yyyy-MM-dd hh:mm:ss"), New Font("Arial", 12)).Width + 10), lblTime.Location.Y)
            lnkLogIn.Location = New Point(lblTime.Location.X, lblTime.Location.Y + TextRenderer.MeasureText("test", New Font("Arial", 12)).Height + 20)
            imgHeader.BackColor = Color.FromArgb(0, 52, 102)
            imgHeader.Width = Screen.PrimaryScreen.Bounds.Width
            lblAreaDiServizio.BackColor = Color.FromArgb(0, 52, 102)
            lblCompany.BackColor = Color.FromArgb(0, 52, 102)
            lblGioveClear.BackColor = Color.FromArgb(0, 52, 102)
            imgCompanyLogoCenter.BackColor = Color.FromArgb(0, 52, 102)
            lblTime.BackColor = Color.FromArgb(0, 52, 102)
            lblTime.ForeColor = Color.White
            lnkLogIn.BackColor = Color.FromArgb(0, 52, 102)
            lblCustomerQuestion.ForeColor = Color.FromArgb(0, 52, 102)
        End Using
    End Sub

    Private Sub tmrTime_Tick(sender As Object, e As EventArgs) Handles tmrTime.Tick
        lblTime.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLogIn.LinkClicked
        LogIn.Show()
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs, Optional emojiClicked As Int16 = 1) Handles PrintDocument1.PrintPage
        Using storeDb As New StoreDBDataContext
            Dim font22 = New Font("Calibri", 22, FontStyle.Bold)
            Dim font14 = New Font("Calibri", 14, FontStyle.Italic)
            Dim x As Int16 = 0, y As Int16 = 0

            Dim Store = storeDb.Stores.SingleOrDefault(Function(d) d.ID = storeDb.Users.SingleOrDefault(Function(m) m.ID = GlobalConfClass.user).StoreID)


            Dim logoStream = New MemoryStream(Store.Store_Logo.ToArray, 0, Store.Store_Logo.Length)
            Dim companyLogo = Image.FromStream(logoStream)
            x = e.MarginBounds.Left + (e.MarginBounds.Width / 2) - (companyLogo.Width / 2)
            e.Graphics.DrawImage(companyLogo, x, y)
            y += companyLogo.Height + 5
            Dim xStringRectangle = New Rectangle(55, y, e.MarginBounds.Width, 100)
            Dim drawFormat As New StringFormat
            drawFormat.Alignment = StringAlignment.Near

            'x += 10

            e.Graphics.DrawString(Store.Store_Marketing_Line, font22, Brushes.Black, xStringRectangle, drawFormat)

            y += xStringRectangle.Height

            'generate QR-Code

            Dim Name As String = "https://tripadvisor.com/"
            Dim writer = New BarcodeWriter()
            writer.Format = BarcodeFormat.QR_CODE
            writer.Options.Height = 300
            writer.Options.Width = 300
            Dim result = writer.Write(Name)
            Dim barcodeBitmap = New Bitmap(result)
            Dim memory As New MemoryStream()
            barcodeBitmap.Save(memory, ImageFormat.Jpeg)

            x = e.MarginBounds.Left + (e.MarginBounds.Width / 2) - (barcodeBitmap.Width / 2)

            e.Graphics.DrawImage(Image.FromStream(memory), x, y)

            y += barcodeBitmap.Height + 10
            xStringRectangle.Y = y
            xStringRectangle.Height = e.MarginBounds.Height - y

            e.Graphics.DrawString("We’re still young and always trying to do our best. We hope to continue and make all our guests comfortable and happy. Most of all, we hope the food & beverages we serve and prepare meet your expectations and satisfy you as much as possible. To continue doing so, we sometimes need a little help & encouragement from you as well.", font14, Brushes.Black, xStringRectangle, drawFormat)



        End Using



    End Sub

    Private Sub imgConfused_Click(sender As Object, e As EventArgs) Handles imgConfused.Click
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub imgAngry_Click(sender As Object, e As EventArgs) Handles imgAngry.Click
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub imgSmiley_Click(sender As Object, e As EventArgs) Handles imgSmiley.Click
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub


End Class
