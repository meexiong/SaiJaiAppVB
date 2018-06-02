Imports System.Data.SqlClient

Public Class frmNewEmp
    Dim conn As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim cm As New SqlCommand
    Dim ds As New DataSet
    Private Sub frmNewEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = StrConnection.strcon
                .Open()
            End With
            showTitle()
        Catch ex As Exception

        End Try
    End Sub
    Sub showTitle()
        Try
            Dim sql As String = "Select TitleID,TitleName from tbl_Title"
            Dim daP As New SqlDataAdapter(sql, conn)
            Dim dsP As New DataSet
            daP.Fill(dsP, "Titile")
            With cmb_Postion
                .DataSource = dsP.Tables(0)
                .DisplayMember = "TitleName"
                .ValueMember = "TitleID"
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class