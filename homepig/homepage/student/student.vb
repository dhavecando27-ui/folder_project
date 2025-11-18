Public Class student
    Dim homes As New home()
    Dim containeruc As New Panel()

    Private Sub student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        loadusercontrol(homes)

        'sidebar layout
        Panel1.Dock = DockStyle.Left
        Panel1.Width = 250
        Panel1.BackColor = Color.FromArgb(40, 40, 40)


        'overlay
        Dim overlay As New Panel
        overlay.BackColor = Color.FromArgb(150, 0, 0, 0)
        overlay.Dock = DockStyle.Fill
        Panel2.Controls.Add(overlay)


        'profile icon
        PictureBox1.Image = My.Resources.pfl_pic
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.Size = New Size(80, 80)
        PictureBox1.Location = New Point((Panel1.Width - PictureBox1.Width) \ 2, 20)
        PictureBox1.BackColor = Color.Transparent


        'left side panel
        For Each uc As Control In Panel1.Controls
            If TypeOf uc Is Button Then
                Dim btn As Button = CType(uc, Button)
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0
                btn.BackColor = Color.Transparent
                btn.ForeColor = Color.White
                btn.Font = New Font("Segoe UI", 10, FontStyle.Regular)
                btn.TextAlign = ContentAlignment.MiddleLeft
                btn.Padding = New Padding(10, 0, 0, 0)
            End If

        Next
    End Sub
    'x button
    Private Sub form_closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            MessageBox.Show("PLEASE USE THE LOG OUT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub
    'hoverbutton in leftside panel
    Private Sub button_hover(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.MouseEnter, Button2.MouseEnter, Button3.MouseEnter, Button4.MouseEnter, Button5.MouseEnter
        CType(sender, Button).BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub button_leave(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave, Button5.MouseLeave
        CType(sender, Button).BackColor = Color.Transparent
    End Sub
    'highlightbutton
    Private Sub highlightbutton(ByVal activebtn As Button)
        For Each uc As Control In Panel1.Controls
            If TypeOf uc Is Button Then
                CType(uc, Button).BackColor = Color.Transparent
            End If
        Next
        activebtn.BackColor = Color.FromArgb(70, 70, 70)
    End Sub
    'usercontrol
    Private Sub loadusercontrol(ByVal uc As UserControl)
        Panel2.Controls.Clear()
        uc.Dock = DockStyle.Fill
        Panel2.Controls.Add(uc)


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        highlightbutton(Button1)
        Dim profilestudent As New profilestudent()
        loadusercontrol(profilestudent)

    End Sub

    Private Sub MENU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        highlightbutton(Button2)
        Dim view As New viewgrade()
        loadusercontrol(view)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        highlightbutton(Button4)
        Dim assessments As New assessment()
        loadusercontrol(assessments)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        highlightbutton(Button5)
        Dim result As DialogResult = MessageBox.Show("are you sure you want to logout", "Logout confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide()
            Form.Show()
            Form.BringToFront()
            Form.Activate()
        Else
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        loadusercontrol(homes)
        highlightbutton(Button3)
    End Sub

  

    Private Sub profilestudent_resize(ByVal sender As Object, ByVal e As EventArgs) Handles Panel2.Resize

    End Sub
End Class