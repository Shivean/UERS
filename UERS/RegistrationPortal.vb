Imports Guna.UI2.WinForms
Imports System.Diagnostics.Eventing.Reader
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
        Guna2TabControl1.SelectedTab = addresstab

        ' Disable programmatic tab switching
        allowTabSwitch = False
    End Sub



    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        allowTabSwitch = True

        Guna2TabControl1.SelectedTab = confirmtab
        allowTabSwitch = False

        Dim firstname As String = txtFirstName.Text
        Dim middlename As String = txtMiddleName.Text
        Dim lastname As String = txtLastName.Text
        Dim nationality As String = cmbNationality.Text
        Dim fathername As String = txtFatherName.Text
        Dim mothername As String = txtMotherName.Text
        Dim dob As Date = timepickerDOB.Text
        Dim gender As String
        If rbMale.Checked Then
            gender = "Male"
        ElseIf rbFemale.Checked Then
            gender = "Female"
        Else
            gender = "Other"
        End If

        Dim fullname As String = $"{firstname} {middlename} {lastname}"
        lblconfirmfullname.Text = fullname
        lblconfirmNationality.Text = nationality
        lblconfirmFatherName.Text = fathername
        lblconfirmMotherName.Text = mothername
        lblconfirmDateofBirth.Text = dob
        lblconfirmGender.Text = gender

        ' For Address Details
        Dim district As String = cmbDistrict.Text
        Dim localGov As String = txtLocalGov.Text
        Dim ward As Integer = txtWard.Text
        Dim town As String = txtTown.Text
        Dim street As String = txtStreet.Text

        lblconfirmDistrict.Text = district
        lblconfirmLocalGov.Text = localGov
        lblconfirmWard.Text = ward
        lblconfirmTown.Text = town
        lblconfirmStreet.Text = street

        ' For Educational Information table
        Dim secondaryBoard As String = txtsecondaryBoard.Text
        Dim secondaryYear As Integer = txtsecondaryYear.Text
        Dim secondaryTotal As Decimal = txtsecondarytotal.Text
        Dim secondaryMarks As Decimal = txtsecondaryMarks.Text
        Dim secondarySymbol As Long = txtsecondarySymbol.Text

        Dim higherBoard As String = txthigherBoard.Text
        Dim higherYear As Integer = txthigherYear.Text
        Dim higherTotal As Decimal = txthigherTotal.Text
        Dim higherMarks As Decimal = txthigherMarks.Text
        Dim higherSymbol As Long = txthigherSymbol.Text

        Dim bachelorUni As String = txtbachelorUni.Text
        Dim bachelorYear As String = txtbachelorYear.Text
        Dim bachelorTotal As String = txtbachelorTotal.Text
        Dim bachelorMarks As String = txtbachelorMarks.Text
        Dim bachelorSymbol As String = txtbachelorSymbol.Text

        dgvConfirmEducationalDetails.Rows.Clear()

        dgvConfirmEducationalDetails.Rows.Add("Secondary Level or Equivalent", secondaryBoard, secondaryYear, secondaryTotal, secondaryMarks, secondarySymbol)
        dgvConfirmEducationalDetails.Rows.Add("Higher Secondary Level or equivalent", higherBoard, higherYear, higherTotal, higherMarks, higherSymbol)
        dgvConfirmEducationalDetails.Rows.Add("Bachelor Level", bachelorUni, bachelorYear, bachelorTotal, bachelorMarks, bachelorSymbol)
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        allowTabSwitch = True

        Guna2TabControl1.SelectedTab = personaltab
        allowTabSwitch = False
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        allowTabSwitch = True
        Guna2TabControl1.SelectedTab = educationtab
        allowTabSwitch = False

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        allowTabSwitch = True

        Guna2TabControl1.SelectedTab = educationtab
        allowTabSwitch = False
    End Sub

    Private Sub btnPortalexit_Click(sender As Object, e As EventArgs) Handles btnPortalexit.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        allowTabSwitch = True

        Guna2TabControl1.SelectedTab = addresstab
        allowTabSwitch = False
    End Sub

End Class

