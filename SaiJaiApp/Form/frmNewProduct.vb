Imports System.Data.SqlClient
Public Class frmNewProduct
    Dim conn As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Dim AutoID As String = ""
    Private Sub frmNewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = StrConnection.strcon
            .Open()
            Show_Category()
            Show_Unit()
            If GlobalVariable.productID = "" Then
                txtProductID.Text = "New"
            Else
                txtProductID.Text = GlobalVariable.productID
                LoadData()
            End If
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
    Sub AutoMaxID()
        Try
            Dim sql As String = "Select ProductID from tbl_Product"
            Dim cm As New SqlCommand
            cm = conn.CreateCommand
            cm.CommandText = sql
            Dim dr As SqlDataReader
            dr = cm.ExecuteReader
            If dr.HasRows Then
                dr.Close()
                Dim query As String = "Select 'P'+Convert(nchar(5),isnull(max(Substring(ProductID,2,5)),0)+1) as autoID from Tbl_Product"
                Dim da1 As New SqlDataAdapter(query, conn)
                Dim ds1 As New DataSet
                da1.Fill(ds1, "MaxID")
                ds1.Tables(0).Clear()
                da1.Fill(ds1, "MaxID")
                AutoID = ds1.Tables(0).Rows(0).Item(0)
            Else
                dr.Close()
                Dim query As String = "Select 'P'+Convert(nchar(5),isnull(max(Substring(ProductID,2,5)),0)+1001) as autoID from Tbl_Product"
                Dim da1 As New SqlDataAdapter(query, conn)
                Dim ds1 As New DataSet
                da1.Fill(ds1, "MaxID")
                ds1.Tables(0).Clear()
                da1.Fill(ds1, "MaxID")
                AutoID = ds1.Tables(0).Rows(0).Item(0)
            End If
        Catch ex As Exception

        End Try

    End Sub
    Sub LoadData()
        Try
            Dim query As String = "Select p.ProductName,c.CatName,p.Price,p.qty,p.Total,
            u.UnitName,p.Note from Tbl_Product p inner join Tbl_Category c
            on p.CatID=c.CatID inner join tbl_Unit u on
            p.UnitiD=u.UnitiD where p.ProductID='" + txtProductID.Text.Trim + "'"
            da = New SqlDataAdapter(query, conn)
            da.Fill(ds, "Product")
            ds.Tables(0).Clear()
            da.Fill(ds, "Product")
            txtProdcutName.Text = ds.Tables(0).Rows(0).Item(0)
            cmbCate.Text = ds.Tables(0).Rows(0).Item(1)
            txtPrice.Text = ds.Tables(0).Rows(0).Item(2)
            txtQty.Text = ds.Tables(0).Rows(0).Item(3)
            txtTotal.Text = ds.Tables(0).Rows(0).Item(4)
            cmbUnit.Text = ds.Tables(0).Rows(0).Item(5)
            txtNote.Text = ds.Tables(0).Rows(0).Item(6)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtProductID.Text = "New" Then
            Save()
        Else
            UpdateTable()
        End If

    End Sub
    Sub Save()
        Try
            'If txtCateID.Text = "AutoID" Then
            Dim insert As String = "insert into Tbl_Product values(@ProductID, @ProductName, @CatID, @Price, @qty, @Total, @UnitiD, @Note)"
            cm = New SqlCommand(insert, conn)
            With cm
                AutoMaxID()
                .Parameters.Add("@ProductID", SqlDbType.NChar).Value = AutoID
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
    Sub UpdateTable()
        'Try
        Dim update As String = "Update Tbl_Product set  ProductName=@ProductName, CatID=@CatID, Price=@Price, qty=@qty, Total=@Total, UnitiD=@UnitiD, Note=@Note where ProductID=@ProductID"
        cm = New SqlCommand(update, conn)
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
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        Dim price As Double
        Dim qty As Integer
        Dim Total As Double
        price = CDbl(txtPrice.Text)
        qty = CInt(txtQty.Text)
        Total = price * qty
        txtTotal.Text = Total.ToString
    End Sub
End Class