Public Class register
    Private isDateClicked As Boolean = False
    Private lastClickPoint As Point
    
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fn.TextChanged

    End Sub

    Private Sub Label4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            pass2.PasswordChar = "*"
        Else
            pass2.PasswordChar = ""
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            pass1.PasswordChar = "*"
        Else
            pass1.PasswordChar = ""
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox4_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass1.TextChanged

    End Sub
    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles age.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter numbers only.")
        End If
    End Sub

    Private Sub TextBox5_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pass2.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ReturnToHome()
    End Sub
    Private Sub ReturnToHome()
        Dim home As New Form()
        home.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                If txt.Text.Trim() = "" Then
                    MessageBox.Show("Please complete all fields before registering.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txt.Focus()
                    Exit Sub
                End If
            End If
        Next

        ' Check kung magkapareho ang password at confirm password
        If pass2.Text <> pass1.Text Then
            MessageBox.Show("Passwords do not match.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pass1.Focus()

            Exit Sub
        End If



    End Sub

    Private Sub register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MonthCalendar1.Visible = False
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub add_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.TextChanged

    End Sub

    Private Sub id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id.TextChanged

    End Sub

    Private Sub mn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mn.TextChanged

    End Sub

    Private Sub age_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles age.TextChanged

    End Sub

    Private Sub gender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gender.SelectedIndexChanged

    End Sub

    Private Sub contact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contact.TextChanged
    
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ReturnToHome()
    End Sub


    Private Sub bd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bd.Click
        MonthCalendar1.Visible = True
        MonthCalendar1.BringToFront()
        isDateClicked = False
    End Sub

    Private Sub dzd(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub


    Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        If isDateClicked Then
            bd.Text = e.Start.ToString("MM/dd/yyyy")
            MonthCalendar1.Visible = False
        End If
    End Sub

    Private Sub MonthCalendar1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MonthCalendar1.MouseDown
        Dim info As MonthCalendar.HitTestInfo = MonthCalendar1.HitTest(e.X, e.Y)
        isDateClicked = (info.HitArea = MonthCalendar.HitArea.Date)
    End Sub
End Class