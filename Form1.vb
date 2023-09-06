Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim stFirstName As String
        Dim stSurname As String
        Dim stGender As String

        stFirstName = txtFirstName.Text
        stSurname = txtSurname.Text
        stGender = txtGender.Text

        MsgBox("Hello " & stFirstName & " " & stSurname & " it is good to know you are " & stGender)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
