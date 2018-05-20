Imports System.Data.SqlClient
Public Class frmNewProduct
    Dim conn As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Private Sub frmNewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = StrConnection.strcon
            .Open()
            Show_Category()
            Show_Unit()
        End With
    End Sub
    Sub Show_Category()
        Dim da = New SqlDataAdapter("SELECT CatID, CatName FROM  dbo.Tbl_Category", conn)
        Dim ds = New DataSet
        da.Fill(ds, "c")
        With cmbCate
            .DataSource = ds.Tables(0)
            .DisplayMember = "CatName"
            .ValueMember = "CatID"
        End With
    End Sub
    Sub Show_Unit()
        Dim daU = New SqlDataAdapter("SELECT UnitiD, UnitName FROM dbo.Tbl_Unit", conn)
        Dim ds = New DataSet
        daU.Fill(ds, "U")
        With cmbUnit
            .DataSource = ds.Tables(0)
            .DisplayMember = "UnitName"
            .ValueMember = "UnitiD"
        End With
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()

    End Sub
    Sub Save()
        Try
            'If txtCateID.Text = "AutoID" Then
            Dim insert As String = "insert into Tbl_Product values(@ProductID, @ProductName, @CatID, @Price, @qty, @Total, @UnitiD, @Note)"
            cm = New SqlCommand(insert, conn)
            With cm
                .Parameters.Add("@ProductID", SqlDbType.NChar).Value = txtProductID.Text.Trim
                .Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = txtProdcutName.Text.Trim
                .Parameters.Add("@CatID", SqlDbType.Int).Value = cmbCate.SelectedValue
                .Parameters.Add("@Price", SqlDbType.Float).Value = txtPrice.Text.Trim
                .Parameters.Add("@qty", SqlDbType.Int).Value = txtQty.Text.Trim
                .Parameters.Add("@Total", SqlDbType.Float).Value = txtTotal.Text.Trim
                .Parameters.Add("@UnitiD", SqlDbType.Int).Value = cmbUnit.SelectedValue
                .Parameters.Add("@Note", SqlDbType.NVarChar).Value = txtNote.Text.Trim
                cm.ExecuteNonQuery()
            End With
            MessageBox.Show("ສໍາເລັດ....", "ຄໍາຢືນຢັນ")
            'Else
            '    Dim update As String = "Update tbl_Category set CatName=@CateName where CatID=@CateID"
            '    cm = New SqlCommand(update, conn)
            '    With cm
            '        .Parameters.Add("@CateID", SqlDbType.Int).Value = CInt(txtCateID.Text)
            '        .Parameters.Add("@CateName", SqlDbType.NVarChar).Value = txtCateName.Text.Trim
            '        cm.ExecuteNonQuery()
            '    End With
            'End If
            'LoadData()
            'txtCateName.Clear()
            'DisableBtn()
            'ClearText()

        Catch ex As Exception

        End Try
    End Sub
End Class