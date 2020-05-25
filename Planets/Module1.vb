Imports System.Data.OleDb
Module Module1
	Public conn As OleDbConnection

	Public Sub Fill_grid(datagridview1 As DataGridView, cmd As String, TableName As String)
		Dim c As New OleDbCommand
		c.Connection = conn
		c.CommandText = cmd
		Dim ds As New DataSet
		Dim da As New OleDbDataAdapter(c)
		da.Fill(ds, TableName)
		datagridview1.DataSource = ds
		datagridview1.DataMember = TableName
	End Sub

End Module