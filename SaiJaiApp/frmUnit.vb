Imports System.Data.SqlClient
Public Class frmUnit
    Dim conn As New SqlConnection
    Dim cm As New SqlCommand
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    'Dim MaxID As Integer
    Private Sub frmUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = StrConnection.strcon
                .Open()
            End With
            DisableBtn()
            LoadData()
            ManageDGV()
        Catch ex As Exception

        End Try
    End Sub
    Sub EnableBtn()
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = True
        btnCancel.Enabled = True
    End Sub
    Sub DisableBtn()
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
    End Sub
    Sub ClearText()
        txtUnitID.Text = "AutoID"
        txtUnitName.Text = ""
    End Sub
    Sub SelectMaxID()
        Try
            Dim query As String = "Select ISNULL(Max(UnitID),0)+1 as AutoID from tbl_Unit"
            Dim daMax As New SqlDataAdapter(query, conn)
            Dim dsMax As New DataSet
            daMax.Fill(dsMax, "Max")
            txtUnitID.Text = dsMax.Tables(0).Rows(0).Item(0)

        Catch ex As Exception

        End Try
    End Sub
    Sub LoadData()
        Try
            Dim query As String = "Select UnitID,UnitName from tbl_Unit"
            da = New SqlDataAdapter(query, conn)
            da.Fill(ds, "Unit")
            ds.Tables(0).Clear()
            da.Fill(ds, "Unit")
            DGV.DataSource = ds.Tables(0)
            DGV.Refresh()
        Catch ex As Exception

        End Try
    End Sub
    Sub ManageDGV()
        With DGV
            .Columns(0).HeaderText = "ລະຫັດ"
            .Columns(1).HeaderText = "ຊື່ຫົວໜ່ວຍ"
            .Columns(0).Width = 80
            .Columns(1).Width = 310
        End With
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
            If txtUnitName.Text = "" Then
                MessageBox.Show("ກາລຸນາປ້ອນຂໍ້ມູນກ່ອນ", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                If txtUnitID.Text = "AutoID" Then
                    SelectMaxID()
                    Dim insert As String = "Insert into Tbl_Unit(UnitID,UnitName)values(@UnitID,@UnitName)"
                    cm = New SqlCommand(insert, conn)
                    cm.Parameters.Add("@UnitID", SqlDbType.Int).Value = CInt(txtUnitID.Text)
                    cm.Parameters.Add("@UnitName", SqlDbType.NVarChar).Value = txtUnitName.Text.Trim
                    cm.ExecuteNonQuery()
                Else
                    Dim update As String = "Update tbl_Unit set UnitName=@UnitName where UnitID=@UnitID"
                    cm = New SqlCommand(update, conn)
                    cm.Parameters.Add("@UnitName", SqlDbType.NVarChar).Value = txtUnitName.Text.Trim
                    cm.Parameters.Add("@UnitID", SqlDbType.Int).Value = CInt(txtUnitID.Text)
                    cm.ExecuteNonQuery()
                End If
                ClearText()
                DisableBtn()
                LoadData()
                ManageDGV()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick

    End Sub

    Private Sub DGV_Click(sender As Object, e As EventArgs) Handles DGV.Click
        Try
            EnableBtn()
            ClearText()
            With DGV.Rows(DGV.CurrentRow.Index)
                txtUnitID.Text = .Cells(0).Value
                txtUnitName.Text = .Cells(1).Value
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("ທ່ານຕ້ອງການລົບ ຫຼື ບໍ?", "ແຈ້ງເຕືອນ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Dim delete As String = "Delete tbl_Unit where UnitID=@UnitID"
                cm = New SqlCommand(delete, conn)
                cm.Parameters.Add("@UnitID", SqlDbType.Int).Value = CInt(txtUnitID.Text)
                cm.ExecuteNonQuery()
                ClearText()
                DisableBtn()
                LoadData()
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class