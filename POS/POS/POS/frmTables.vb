Public Class frmTables
    Dim click1 As Boolean = True
    Private Sub btnTable1_Click(sender As Object, e As EventArgs) Handles btnTable1.Click
        'DataGridView1.Rows.Add(New String() {Value1, Value2, Value3})
        'DataGridView1.Rows.Insert(rowPosition, New String() {value1, value2, value3})
        'DataSet1.DataTable.AddRow(1, "John Doe", True)
        'Dim count As Integer = 1
        'click1 = True
        'If click1 Then
        'DataGridView1.Rows.Add(New String() {"1", btnTable1.Text})
        'End If

    End Sub

    Private Sub btnTable2_Click(sender As Object, e As EventArgs) Handles btnTable2.Click
        'Me.Close()
        If click1 Then
            DataGridView1.Rows.Add(New String() {"1", btnTable2.Text})
        End If
    End Sub

    Private Sub btnTable3_Click(sender As Object, e As EventArgs) Handles btnTable3.Click
        Me.Close()
    End Sub

    Private Sub btnTable4_Click(sender As Object, e As EventArgs) Handles btnTable4.Click
        Me.Close()
    End Sub

    Private Sub btnTable5_Click(sender As Object, e As EventArgs) Handles btnTable5.Click
        Me.Close()
    End Sub

    Private Sub btnTable6_Click(sender As Object, e As EventArgs) Handles btnTable6.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frmTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DataGridView1.Rows.Add(New String() {"1", btnTable1.Text})
        For i = 1 To 6
            DataGridView1.Rows.Add(New String() {i.ToString()})
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class



