Imports Guna.UI2.WinForms
Imports System.Drawing.Drawing2D

Public Class RegistrationPortal

    ' Define a class-level boolean variable to control tab switching
    Private allowTabSwitch As Boolean = False

    ' Event handler to prevent tab switching by clicking on the tab headers
    Private Sub TabControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles Guna2TabControl1.Selecting
        ' Cancel the tab switch if it's user-initiated
        If Not allowTabSwitch Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Enable programmatic tab switching
        allowTabSwitch = True

        ' Switch to the second tab (index 1) programmatically
        Guna2TabControl1.SelectedTab = educationtab

        ' Disable programmatic tab switching
        allowTabSwitch = False
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        allowTabSwitch = True

        Guna2TabControl1.SelectedTab = TabPage1
        allowTabSwitch = False
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        allowTabSwitch = True

        Guna2TabControl1.SelectedTab = addresstab
        allowTabSwitch = False
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        allowTabSwitch = True

        Guna2TabControl1.SelectedTab = educationtab
        allowTabSwitch = False
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        allowTabSwitch = True

        Guna2TabControl1.SelectedTab = confirmtab
        allowTabSwitch = False
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        allowTabSwitch = True

        Guna2TabControl1.SelectedTab = addresstab
        allowTabSwitch = False
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Me.Close()
    End Sub
End Class

