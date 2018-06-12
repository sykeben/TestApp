Public Class MainWindow
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles HelloWorldText.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles InfoButton.Click
        MsgBox("TestApp By Ben Sykes, (C)2018.")
    End Sub
End Class
