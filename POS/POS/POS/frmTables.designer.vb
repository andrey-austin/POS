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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.clmTable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmOrdered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTable1
        '
        Me.btnTable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable1.Location = New System.Drawing.Point(30, 52)
        Me.btnTable1.Name = "btnTable1"
        Me.btnTable1.Size = New System.Drawing.Size(105, 86)
        Me.btnTable1.TabIndex = 0
        Me.btnTable1.Text = "1"
        Me.btnTable1.UseVisualStyleBackColor = True
        '
        'btnTable2
        '
        Me.btnTable2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable2.Location = New System.Drawing.Point(141, 52)
        Me.btnTable2.Name = "btnTable2"
        Me.btnTable2.Size = New System.Drawing.Size(105, 86)
        Me.btnTable2.TabIndex = 1
        Me.btnTable2.Text = "2"
        Me.btnTable2.UseVisualStyleBackColor = True
        '
        'btnTable3
        '
        Me.btnTable3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable3.Location = New System.Drawing.Point(252, 52)
        Me.btnTable3.Name = "btnTable3"
        Me.btnTable3.Size = New System.Drawing.Size(105, 86)
        Me.btnTable3.TabIndex = 2
        Me.btnTable3.Text = "3"
        Me.btnTable3.UseVisualStyleBackColor = True
        '
        'btnTable4
        '
        Me.btnTable4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable4.Location = New System.Drawing.Point(363, 52)
        Me.btnTable4.Name = "btnTable4"
        Me.btnTable4.Size = New System.Drawing.Size(105, 86)
        Me.btnTable4.TabIndex = 3
        Me.btnTable4.Text = "4"
        Me.btnTable4.UseVisualStyleBackColor = True
        '
        'btnTable5
        '
        Me.btnTable5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable5.Location = New System.Drawing.Point(474, 52)
        Me.btnTable5.Name = "btnTable5"
        Me.btnTable5.Size = New System.Drawing.Size(105, 86)
        Me.btnTable5.TabIndex = 4
        Me.btnTable5.Text = "5"
        Me.btnTable5.UseVisualStyleBackColor = True
        '
        'btnTable6
        '
        Me.btnTable6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable6.Location = New System.Drawing.Point(585, 52)
        Me.btnTable6.Name = "btnTable6"
        Me.btnTable6.Size = New System.Drawing.Size(105, 86)
        Me.btnTable6.TabIndex = 5
        Me.btnTable6.Text = "6"
        Me.btnTable6.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmTable, Me.clmOrdered})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 200)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(678, 43)
        Me.DataGridView1.TabIndex = 11
        '
        'clmTable
        '
        Me.clmTable.HeaderText = "Table #"
        Me.clmTable.Name = "clmTable"
        '
        'clmOrdered
        '
        Me.clmOrdered.HeaderText = "Ordered"
        Me.clmOrdered.Name = "clmOrdered"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(310, 365)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTable1)
        Me.Controls.Add(Me.btnTable6)
        Me.Controls.Add(Me.btnTable2)
        Me.Controls.Add(Me.btnTable4)
        Me.Controls.Add(Me.btnTable5)
        Me.Controls.Add(Me.btnTable3)
        Me.MaximumSize = New System.Drawing.Size(730, 465)
        Me.MinimumSize = New System.Drawing.Size(730, 465)
        Me.Name = "frmTables"
        Me.Text = "Tables"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTable1 As Button
    Friend WithEvents btnTable2 As Button
    Friend WithEvents btnTable3 As Button
    Friend WithEvents btnTable4 As Button
    Friend WithEvents btnTable5 As Button
    Friend WithEvents btnTable6 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents clmTable As DataGridViewTextBoxColumn
    Friend WithEvents clmOrdered As DataGridViewTextBoxColumn
    Friend WithEvents btnExit As Button
End Class
