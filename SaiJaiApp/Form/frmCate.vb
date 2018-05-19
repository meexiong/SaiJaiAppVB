Imports System.Data.SqlClient

Public Class frmCate
    Dim conn As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cm As New SqlCommand
    Private Sub frmCate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = StrConnection.strcon
            .Open()
        End With
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
        LoadData()
        ManageDGV()
    End Sub
    Sub ManageDGV()
        With DGV
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ຊື່ປະເພດສີນຄ້າ"
            .Columns(0).Width = 70
            .Columns(1).Width = 200
        End With
    End Sub
    Private Sub LoadData()
        Dim sql As String = "Select * from tbl_Category"
        da = New SqlDataAdapter(sql, conn)
        da.Fill(ds, "Category")
        ds.Tables(0).Clear()
        da.Fill(ds, "Category")
        DGV.DataSource = ds.Tables(0)
        DGV.Refresh()
    End Sub
    Private Sub DisableBtn()
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
    End Sub
    Private Sub EnableBtn()
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = True
        btnCancel.Enabled = True
    End Sub
    Private Sub ClearText()
        txtCateID.Text = "AutoID"
        txtCateName.Text = ""
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        EnableBtn()
        ClearText()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DisableBtn()
        ClearText()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtCateID.Text = "AutoID" Then
                Dim insert As String = "insert into tbl_Category values(@CatName)"
                cm = New SqlCommand(insert, conn)
                With cm
                    .Parameters.Add("@CatName", SqlDbType.NVarChar).Value = txtCateName.Text.Trim
                    cm.ExecuteNonQuery()
                End With
            Else
                Dim update As String = "Update tbl_Category set CatName=@CateName where CatID=@CateID"
                cm = New SqlCommand(update, conn)
                With cm
                    .Parameters.Add("@CateID", SqlDbType.Int).Value = CInt(txtCateID.Text)
                    .Parameters.Add("@CateName", SqlDbType.NVarChar).Value = txtCateName.Text.Trim
                    cm.ExecuteNonQuery()
                End With
            End If
            LoadData()
            txtCateName.Clear()
            DisableBtn()
            ClearText()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGV_Click(sender As Object, e As EventArgs) Handles DGV.Click
        Try
            EnableBtn()
            ClearText()
            With DGV.Rows(DGV.CurrentRow.Index)
                txtCateID.Text = .Cells(0).Value
                txtCateName.Text = .Cells(1).Value
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim delete As String = "Delete Tbl_Category where CatID=@CatID"
            cm = New SqlCommand(delete, conn)
            cm.Parameters.Add("@CatID", SqlDbType.Int).Value = CInt(txtCateID.Text)
            cm.ExecuteNonQuery()
            LoadData()
            ClearText()
            DisableBtn()
        Catch ex As Exception

        End Try
    End Sub
End Class