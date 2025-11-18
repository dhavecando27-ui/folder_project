Imports System.Drawingv
Imports MySql.Data.MySqlClient

Public Class recover

    Private storedAnswer As String = ""
    Private storedPassword As String = ""


    Private Sub txtusename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblusename.Click

    End Sub

    Private Sub btnrecover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecover.Click
        ' 1. Siguraduhin na may nilagay na sagot ang user
        If txtanswer.Text = "" Then
            lblresult.ForeColor = Color.Red
            lblresult.Text = "pls,Fill your answer."
            Return
        End If

        ' 2. Ikumpara ang sagot ng user sa storedAnswer (galing sa database)
        ' Ang StringComparison.OrdinalIgnoreCase ay ginagamit para hindi na mahalaga kung malaki o maliit ang letra.
        If String.Equals(txtanswer.Text, storedAnswer, StringComparison.OrdinalIgnoreCase) Then

            ' --- KUNG TAMA ANG SAGOT ---
            lblresult.ForeColor = Color.Green  ' Gawing berde ang kulay ng text
            lblresult.Text = "SUCCESS! : " & storedPassword

            ' I-disable ang fields para matapos na ang recovery process
            txtanswer.Enabled = False
            btbrecover.Enabled = False

        Else
            ' --- KUNG MALI ANG SAGOT ---
            lblresult.ForeColor = Color.Red    ' Gawing pula ang kulay ng text
            lblresult.Text = "Try again."

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub lblresult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblresult.Click

    End Sub

    Private Sub btbrecover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbrecover.Click
        If txtanswer.Text = "" Then
            lblResult.ForeColor = Color.Red
            lblResult.Text = "Please fill your answer."
            lblResult.Visible = True
            Return
        End If

        ' Case-insensitive comparison laban sa hardcoded storedAnswer ("blue")
        If String.Equals(txtanswer.Text, storedAnswer, StringComparison.OrdinalIgnoreCase) Then

            ' SUCCESS - BUKAS NG RESET FORM
            Dim resetForm As New ResetPassword()

            ' Ipasa ang username (Testuser) sa bagong form
            resetForm.UsernameToReset = txtusername.Text

            resetForm.Show()
            Me.Close()

        Else
            ' FAILURE
            lblResult.ForeColor = Color.Red
            lblResult.Text = "Try again. Incorrect answer."
            lblResult.Visible = True
        End If
    End Sub


    Private Sub recover_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim reg As New Form()

    End Sub
End Class