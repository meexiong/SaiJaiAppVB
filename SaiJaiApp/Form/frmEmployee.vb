Public Class frmEmployee
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim f As New frmNewEmp
        f.ShowDialog()
    End Sub

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class