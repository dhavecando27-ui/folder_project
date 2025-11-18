Public Class Form
    Dim selectrole As String = ""
    Dim activebutton As Button = Nothing

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        selectrole = "STUDENT"
        HighlightRole(Button1)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        selectrole = "PROFESSOR"
        HighlightRole(Button2)
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
       

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim regForm As New register()
        regForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim regForm As New ForgetPassword()
        regForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If username = "admin" And password = "admin12345" Then
            Dim Admin As New admin()
            Admin.show()
            Me.Hide()
        End If

        If username = "student" And password = "12345" Then
            Dim student As New student()
            student.Show()
            Me.Hide()
        End If

        If username = "cashier" And password = "6789" Then
            Dim cash As New cashier()
            cashier.Show()
            Me.Hide()


        End If


        Exit Sub

        If username = "" Then
            MessageBox.Show("PLEASE INPUT YOUR ACCOUNT!!")
            Exit Sub

        End If


    End Sub

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        centerpanel()
        Me.KeyPreview = True
        Button1.FlatStyle = FlatStyle.Flat
        Button2.FlatStyle = FlatStyle.Flat
        Button3.FlatStyle = FlatStyle.Flat

        Button1.FlatAppearance.MouseOverBackColor = Color.Blue
        Button2.FlatAppearance.MouseOverBackColor = Color.Blue
        Button3.FlatAppearance.MouseOverBackColor = Color.Blue

        Button5.ForeColor = Color.Blue

    End Sub

    Private Sub form_resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
        centerpanel()
    End Sub
    Private Sub centerpanel()
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        selectrole = "CASHIER"
        HighlightRole(Button3)
    End Sub

    Private Sub HighlightRole(ByVal btn As Button)

        If activebutton IsNot Nothing Then
            activebutton.BackColor = SystemColors.Control
        End If
        btn.BackColor = Color.Blue
        activebutton = btn
    End Sub

    Private Sub Label4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub form_keydown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button6.PerformClick()
        End If
    End Sub
End Class
