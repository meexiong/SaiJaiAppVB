Imports System.Data.SqlClient
Public Class frmTitle
    Dim conn As New SqlConnection
    Dim cm As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim titleID As Integer
    Private Sub frmTitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = StrConnection.strcon
            .Open()
        End With
        Disablebtn()
        loadData()
        DGVColHeader()
    End Sub
    Sub Disablebtn()
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
    End Sub
    Sub Enablebtn()
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = True
        btnCancel.Enabled = True
    End Sub
    Sub ClearText()
        txtTitleID.Text = "New"
        txtTitleName.Clear()
        txtTitleName.Select()
    End Sub
    Sub getMaxiD()
        Dim sql As String = "Select isnull(Max(TitleID),0)+1 as MaxID from tbl_Title"
        Dim daM As New SqlDataAdapter(sql, conn)
        Dim dsM As New DataSet
        daM.Fill(dsM, "Max")
        titleID = dsM.Tables(0).Rows(0).Item(0)
    End Sub
    Sub loadData()
        Try
            Dim qeury As String = "Select * from tbl_Title"
            da = New SqlDataAdapter(qeury, conn)
            da.Fill(ds, "Title")
            ds.Tables(0).Clear()
            da.Fill(ds, "Title")
            DGV.DataSource = ds.Tables(0)
            DGV.Refresh()
        Catch ex As Exception

        End Try
    End Sub
    Sub DGVColHeader()
        With DGV
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ຊື່ຕຳແໜ່ງ"
            .Columns(0).Width = 70
            .Columns(1).Width = 300
        End With
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Enablebtn()
        ClearText()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Disablebtn()
        ClearText()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtTitleID.Text = "New" Then
            getMaxiD()
            Dim insert As String = "Insert into tbl_Title(TitleID,TitleName) values(@TitleID,@TitleName)"
            cm = New SqlCommand(insert, conn)
            cm.Parameters.Add("@TitleID", SqlDbType.Int).Value = titleID
            cm.Parameters.Add("@TitleName", SqlDbType.NVarChar).Value = txtTitleName.Text.Trim
            cm.ExecuteNonQuery()
        Else
            Dim update As String = "Update tbl_Title set TitleName=@TitleName where TitleID=@TitleID"
            cm = New SqlCommand(update, conn)
            cm.Parameters.Add("@TitleName", SqlDbType.NVarChar).Value = txtTitleName.Text.Trim
            cm.Parameters.Add("@TitleID", SqlDbType.Int).Value = CInt(txtTitleID.Text)
            cm.ExecuteNonQuery()
        End If
        loadData()
        DGVColHeader()
        ClearText()
    End Sub

    Private Sub DGV_Click(sender As Object, e As EventArgs) Handles DGV.Click
        Try
            With DGV.Rows(DGV.CurrentRow.Index)
                txtTitleID.Text = .Cells(0).Value
                txtTitleName.Text = .Cells(1).Value
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTitleName_TextChanged(sender As Object, e As EventArgs) Handles txtTitleName.TextChanged

    End Sub
End Class