Public Class frmCal

    Private Sub cal_DateSelected(sender As Object, e As DateRangeEventArgs) Handles cal.DateSelected
        lblSelectionStart.Text = cal.SelectionStart
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
