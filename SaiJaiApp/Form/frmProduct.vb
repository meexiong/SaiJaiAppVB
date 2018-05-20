Imports System.Data.SqlClient
Public Class frmProduct
    Dim conn As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim f As New frmNewProduct
        f.ShowDialog()
    End Sub

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = StrConnection.strcon
            .Open()
            LoadData()
            Show_DGV()

        End With
    End Sub
    Private Sub LoadData()
        Dim sql As String = "SELECT dbo.Tbl_Product.ProductID, dbo.Tbl_Product.ProductName, dbo.Tbl_Category.CatName, 
                          dbo.Tbl_Product.Price, dbo.Tbl_Product.qty, dbo.Tbl_Unit.UnitName,  dbo.Tbl_Product.Total,
                          dbo.Tbl_Product.Note FROM  dbo.Tbl_Product INNER JOIN
                         dbo.Tbl_Category ON dbo.Tbl_Product.CatID = dbo.Tbl_Category.CatID INNER JOIN
                         dbo.Tbl_Unit ON dbo.Tbl_Product.UnitiD = dbo.Tbl_Unit.UnitiD"
        da = New SqlDataAdapter(sql, conn)
        da.Fill(ds, "Product")
        ds.Tables(0).Clear()
        da.Fill(ds, "Product")
        DGV.DataSource = ds.Tables(0)
        DGV.Refresh()
    End Sub
    Sub Show_DGV()
        With DGV
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ຊື່ປະສິນຄ້າ"
            .Columns(2).HeaderText = "ປະເພດສິນຄ້າ"
            .Columns(3).HeaderText = "ລາຄາ"
            .Columns(4).HeaderText = "ຈໍານວນ"
            .Columns(5).HeaderText = "ຫົວໜ່ວຍ"
            .Columns(6).HeaderText = "ລວມລາຄາ"
            .Columns(7).HeaderText = "ໝາຍເຫດ"
            .Columns(0).Width = 70
            .Columns(1).Width = 100
            .Columns(2).Width = 90
            .Columns(3).Width = 100
            .Columns(4).Width = 60
            .Columns(5).Width = 60
            .Columns(6).Width = 120
            .Columns(7).Width = 200
        End With
    End Sub

End Class