<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTables
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
        Me.btnTable1 = New System.Windows.Forms.Button()
        Me.btnTable2 = New System.Windows.Forms.Button()
        Me.btnTable3 = New System.Windows.Forms.Button()
        Me.btnTable4 = New System.Windows.Forms.Button()
        Me.btnTable5 = New System.Windows.Forms.Button()
        Me.btnTable6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTable1
        '
        Me.btnTable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable1.Location = New System.Drawing.Point(70, 76)
        Me.btnTable1.Name = "btnTable1"
        Me.btnTable1.Size = New System.Drawing.Size(185, 140)
        Me.btnTable1.TabIndex = 0
        Me.btnTable1.Text = "1"
        Me.btnTable1.UseVisualStyleBackColor = True
        '
        'btnTable2
        '
        Me.btnTable2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable2.Location = New System.Drawing.Point(261, 76)
        Me.btnTable2.Name = "btnTable2"
        Me.btnTable2.Size = New System.Drawing.Size(185, 140)
        Me.btnTable2.TabIndex = 1
        Me.btnTable2.Text = "2"
        Me.btnTable2.UseVisualStyleBackColor = True
        '
        'btnTable3
        '
        Me.btnTable3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable3.Location = New System.Drawing.Point(452, 76)
        Me.btnTable3.Name = "btnTable3"
        Me.btnTable3.Size = New System.Drawing.Size(185, 140)
        Me.btnTable3.TabIndex = 2
        Me.btnTable3.Text = "3"
        Me.btnTable3.UseVisualStyleBackColor = True
        '
        'btnTable4
        '
        Me.btnTable4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable4.Location = New System.Drawing.Point(70, 222)
        Me.btnTable4.Name = "btnTable4"
        Me.btnTable4.Size = New System.Drawing.Size(185, 140)
        Me.btnTable4.TabIndex = 3
        Me.btnTable4.Text = "4"
        Me.btnTable4.UseVisualStyleBackColor = True
        '
        'btnTable5
        '
        Me.btnTable5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable5.Location = New System.Drawing.Point(261, 222)
        Me.btnTable5.Name = "btnTable5"
        Me.btnTable5.Size = New System.Drawing.Size(185, 140)
        Me.btnTable5.TabIndex = 4
        Me.btnTable5.Text = "5"
        Me.btnTable5.UseVisualStyleBackColor = True
        '
        'btnTable6
        '
        Me.btnTable6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable6.Location = New System.Drawing.Point(452, 222)
        Me.btnTable6.Name = "btnTable6"
        Me.btnTable6.Size = New System.Drawing.Size(185, 140)
        Me.btnTable6.TabIndex = 5
        Me.btnTable6.Text = "6"
        Me.btnTable6.UseVisualStyleBackColor = True
        '
        'frmTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnTable1)
        Me.Controls.Add(Me.btnTable6)
        Me.Controls.Add(Me.btnTable2)
        Me.Controls.Add(Me.btnTable4)
        Me.Controls.Add(Me.btnTable5)
        Me.Controls.Add(Me.btnTable3)
        Me.Name = "frmTables"
        Me.Text = "Tables"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTable1 As Button
    Friend WithEvents btnTable2 As Button
    Friend WithEvents btnTable3 As Button
    Friend WithEvents btnTable4 As Button
    Friend WithEvents btnTable5 As Button
    Friend WithEvents btnTable6 As Button
End Class
