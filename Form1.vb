Public Class Form1
    Private Sub Btn_ShowMsg_Click(sender As Object, e As EventArgs) Handles Btn_ShowMsg.Click

        Dim FirstName As String
        FirstName = "Kokikun"
        MessageBox.Show("Good Morning " & FirstName & " How are you?")

    End Sub
End Class