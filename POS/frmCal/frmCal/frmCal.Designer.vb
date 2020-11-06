<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cal = New System.Windows.Forms.MonthCalendar()
        Me.lblSelectionStart = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cal
        '
        Me.cal.Location = New System.Drawing.Point(151, 18)
        Me.cal.Name = "cal"
        Me.cal.TabIndex = 0
        '
        'lblSelectionStart
        '
        Me.lblSelectionStart.AutoSize = True
        Me.lblSelectionStart.Location = New System.Drawing.Point(235, 189)
        Me.lblSelectionStart.Name = "lblSelectionStart"
        Me.lblSelectionStart.Size = New System.Drawing.Size(76, 13)
        Me.lblSelectionStart.TabIndex = 1
        Me.lblSelectionStart.Text = "Selection Start"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmCal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 376)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblSelectionStart)
        Me.Controls.Add(Me.cal)
        Me.Name = "frmCal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cal As MonthCalendar
    Friend WithEvents lblSelectionStart As Label
    Friend WithEvents Button1 As Button
End Class
