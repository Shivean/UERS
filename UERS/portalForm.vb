Public Class portalForm
    Private Sub btnPortalexit_Click(sender As Object, e As EventArgs) Handles btnPortalexit.Click
        Me.Close()
    End Sub

    Private Sub btnPortalLogin_Click(sender As Object, e As EventArgs) Handles btnPortalLogin.Click
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnPortalregister_Click(sender As Object, e As EventArgs) Handles btnPortalregister.Click
        registrationPortal.show()
        Me.Hide()
    End Sub
End Class