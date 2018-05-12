Public Class frmEmployee
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim f As New frmNewEmp
        f.ShowDialog()
    End Sub
End Class