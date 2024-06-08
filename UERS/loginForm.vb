Public Class loginForm
    Private Sub btnloginexit_Click(sender As Object, e As EventArgs) Handles btnloginexit.Click

        Application.Exit()

    End Sub

    Private Sub btnloginReturn_Click(sender As Object, e As EventArgs) Handles btnloginReturn.Click
        portalForm.Show()
        Me.Close()
    End Sub

End Class
