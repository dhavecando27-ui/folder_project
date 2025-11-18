Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Dim connString As String = "Server=localhost;Database=SampleDB;User Id=yourUsername;Password=yourPasword;"
Dim conn As New SqlConnection(connString)

Try
    conn.Open()
    MessageBox.Show("Connected successfully!")

Dim query As String = "SELECT * FROM Users"
Dim cmd As New SqlCommand(query, conn)
Dim reader As SqlDataReader = cmd.ExecuteReader()

    While reader.Read()
        Console.WriteLine("Username: " & reader("Username").ToString())
    End While

    reader.Close()
    conn.Close()

Catch ex As Exception
    MessageBox.Show("Error: " & ex.Message)


Public Class ForgetPassword

    ' pang-hash ng password
    Function HashPass(ByVal txt As String) As String
        Dim sha As SHA256 = SHA256.Create()
        Dim data() As Byte = Encoding.UTF8.GetBytes(txt)
        Dim hashed() As Byte = sha.ComputeHash(data)
        Return Convert.ToBase64String(hashed)
    End Function
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

    Public Class frmForgotPassword

        ' pang-hash ng password
        Function HashPass(ByVal txt As String) As String
            Dim sha As SHA256 = SHA256.Create()
            Dim data() As Byte = Encoding.UTF8.GetBytes(txt)
            Dim hashed() As Byte = sha.ComputeHash(data)
            Return Convert.ToBase64String(hashed)
        End Function

        ' reset password kapag tama ang recovery
        Private Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReset.Click
            Dim uname As String = txtUsername.Text
            Dim recpass As String = txtRecovery.Text
            Dim newpass As String = txtNewPass.Text

            If uname = "" Or recpass = "" Or newpass = "" Then
                MsgBox("Please complete all fields.")
                Exit Sub
            End If

            Dim con As New SqlConnection("your_connection_string_here")
            Dim cmd As New SqlCommand("SELECT RecoveryPassword FROM Users WHERE Username=@u", con)
            cmd.Parameters.AddWithValue("@u", uname)

            con.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader()

            If rdr.Read() Then
                Dim recHash As String = rdr("RecoveryPassword").ToString()
                rdr.Close()

                If recHash = HashPass(recpass) Then
                    Dim updateCmd As New SqlCommand("UPDATE Users SET Password=@p WHERE Username=@u", con)
                    updateCmd.Parameters.AddWithValue("@p", HashPass(newpass))
                    updateCmd.Parameters.AddWithValue("@u", uname)
                    updateCmd.ExecuteNonQuery()
                    MsgBox("Password updated.")
                Else
                    MsgBox("Wrong recovery password.")
                End If
            Else
                MsgBox("Username not found.")
            End If

            con.Close()
        End Sub

    End Class


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ReturnToHome()
    End Sub
    Private Sub ReturnToHome()
        Dim home As New Form()
        home.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim regForm As New form1()
        regForm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ForgetPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Dim regForm As New form1()
        regForm.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint




    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

End Class