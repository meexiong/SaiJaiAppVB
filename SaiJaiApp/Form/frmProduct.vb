Public Class frmProduct
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim f As New frmNewProduct
        f.ShowDialog()
    End Sub
End Class