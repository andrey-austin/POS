<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOS))
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.btnHotFood = New System.Windows.Forms.Button()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.btnColdFood = New System.Windows.Forms.Button()
        Me.grpReceipt = New System.Windows.Forms.GroupBox()
        Me.btnTable = New System.Windows.Forms.Button()
        Me.tpgMenu = New System.Windows.Forms.TabControl()
        Me.tpgHotFood = New System.Windows.Forms.TabPage()
        Me.btnSoup = New System.Windows.Forms.Button()
        Me.btnPasta = New System.Windows.Forms.Button()
        Me.btnRice = New System.Windows.Forms.Button()
        Me.tpgColdFood = New System.Windows.Forms.TabPage()
        Me.btnSandwich = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tpgDrinks = New System.Windows.Forms.TabPage()
        Me.btbnPepsi = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnTable1 = New System.Windows.Forms.Button()
        Me.btnTable2 = New System.Windows.Forms.Button()
        Me.btnTable4 = New System.Windows.Forms.Button()
        Me.btnTable3 = New System.Windows.Forms.Button()
        Me.btnNone = New System.Windows.Forms.Button()
        Me.btnTitle = New System.Windows.Forms.Label()
        Me.grpTable = New System.Windows.Forms.GroupBox()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnResv = New System.Windows.Forms.Button()
        Me.lstSales = New System.Windows.Forms.ListBox()
        Me.lblSalesNum = New System.Windows.Forms.Label()
        Me.lstTotal = New System.Windows.Forms.ListBox()
        Me.lblSumTotal = New System.Windows.Forms.Label()
        Me.lstBill = New System.Windows.Forms.ListBox()
        Me.grpMenu.SuspendLayout()
        Me.grpReceipt.SuspendLayout()
        Me.tpgMenu.SuspendLayout()
        Me.tpgHotFood.SuspendLayout()
        Me.tpgColdFood.SuspendLayout()
        Me.tpgDrinks.SuspendLayout()
        Me.grpTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMenu
        '
        Me.grpMenu.Controls.Add(Me.btnHotFood)
        Me.grpMenu.Controls.Add(Me.btnDrinks)
        Me.grpMenu.Controls.Add(Me.btnColdFood)
        Me.grpMenu.Location = New System.Drawing.Point(12, 75)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Size = New System.Drawing.Size(71, 339)
        Me.grpMenu.TabIndex = 0
        Me.grpMenu.TabStop = False
        Me.grpMenu.Text = "Menu"
        '
        'btnHotFood
        '
        Me.btnHotFood.Location = New System.Drawing.Point(6, 31)
        Me.btnHotFood.Name = "btnHotFood"
        Me.btnHotFood.Size = New System.Drawing.Size(65, 23)
        Me.btnHotFood.TabIndex = 0
        Me.btnHotFood.Text = "Hot Food"
        Me.btnHotFood.UseVisualStyleBackColor = True
        '
        'btnDrinks
        '
        Me.btnDrinks.Location = New System.Drawing.Point(6, 91)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(65, 23)
        Me.btnDrinks.TabIndex = 2
        Me.btnDrinks.Text = "Drinks"
        Me.btnDrinks.UseVisualStyleBackColor = True
        '
        'btnColdFood
        '
        Me.btnColdFood.Location = New System.Drawing.Point(5, 62)
        Me.btnColdFood.Name = "btnColdFood"
        Me.btnColdFood.Size = New System.Drawing.Size(65, 23)
        Me.btnColdFood.TabIndex = 1
        Me.btnColdFood.Text = "Cold Food"
        Me.btnColdFood.UseVisualStyleBackColor = True
        '
        'grpReceipt
        '
        Me.grpReceipt.Controls.Add(Me.lstBill)
        Me.grpReceipt.Location = New System.Drawing.Point(515, 223)
        Me.grpReceipt.Name = "grpReceipt"
        Me.grpReceipt.Size = New System.Drawing.Size(183, 191)
        Me.grpReceipt.TabIndex = 2
        Me.grpReceipt.TabStop = False
        Me.grpReceipt.Text = "Bill"
        '
        'btnTable
        '
        Me.btnTable.Location = New System.Drawing.Point(523, 177)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Size = New System.Drawing.Size(75, 23)
        Me.btnTable.TabIndex = 9
        Me.btnTable.Text = "Table"
        Me.btnTable.UseVisualStyleBackColor = True
        '
        'tpgMenu
        '
        Me.tpgMenu.Controls.Add(Me.tpgHotFood)
        Me.tpgMenu.Controls.Add(Me.tpgColdFood)
        Me.tpgMenu.Controls.Add(Me.tpgDrinks)
        Me.tpgMenu.Location = New System.Drawing.Point(89, 84)
        Me.tpgMenu.Name = "tpgMenu"
        Me.tpgMenu.SelectedIndex = 0
        Me.tpgMenu.Size = New System.Drawing.Size(400, 330)
        Me.tpgMenu.TabIndex = 8
        '
        'tpgHotFood
        '
        Me.tpgHotFood.Controls.Add(Me.btnSoup)
        Me.tpgHotFood.Controls.Add(Me.btnPasta)
        Me.tpgHotFood.Controls.Add(Me.btnRice)
        Me.tpgHotFood.Location = New System.Drawing.Point(4, 22)
        Me.tpgHotFood.Name = "tpgHotFood"
        Me.tpgHotFood.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgHotFood.Size = New System.Drawing.Size(392, 304)
        Me.tpgHotFood.TabIndex = 0
        Me.tpgHotFood.Text = "Hot Food"
        Me.tpgHotFood.UseVisualStyleBackColor = True
        '
        'btnSoup
        '
        Me.btnSoup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSoup.BackgroundImage = CType(resources.GetObject("btnSoup.BackgroundImage"), System.Drawing.Image)
        Me.btnSoup.Location = New System.Drawing.Point(6, 37)
        Me.btnSoup.Name = "btnSoup"
        Me.btnSoup.Size = New System.Drawing.Size(102, 80)
        Me.btnSoup.TabIndex = 5
        Me.btnSoup.UseVisualStyleBackColor = True
        '
        'btnPasta
        '
        Me.btnPasta.BackgroundImage = CType(resources.GetObject("btnPasta.BackgroundImage"), System.Drawing.Image)
        Me.btnPasta.Location = New System.Drawing.Point(128, 37)
        Me.btnPasta.Name = "btnPasta"
        Me.btnPasta.Size = New System.Drawing.Size(101, 80)
        Me.btnPasta.TabIndex = 6
        Me.btnPasta.UseVisualStyleBackColor = True
        '
        'btnRice
        '
        Me.btnRice.BackgroundImage = CType(resources.GetObject("btnRice.BackgroundImage"), System.Drawing.Image)
        Me.btnRice.Location = New System.Drawing.Point(244, 37)
        Me.btnRice.Name = "btnRice"
        Me.btnRice.Size = New System.Drawing.Size(106, 80)
        Me.btnRice.TabIndex = 7
        Me.btnRice.UseVisualStyleBackColor = True
        '
        'tpgColdFood
        '
        Me.tpgColdFood.Controls.Add(Me.btnSandwich)
        Me.tpgColdFood.Controls.Add(Me.Button2)
        Me.tpgColdFood.Controls.Add(Me.Button3)
        Me.tpgColdFood.Location = New System.Drawing.Point(4, 22)
        Me.tpgColdFood.Name = "tpgColdFood"
        Me.tpgColdFood.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgColdFood.Size = New System.Drawing.Size(392, 304)
        Me.tpgColdFood.TabIndex = 1
        Me.tpgColdFood.Text = "Cold Food"
        Me.tpgColdFood.UseVisualStyleBackColor = True
        '
        'btnSandwich
        '
        Me.btnSandwich.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSandwich.BackgroundImage = CType(resources.GetObject("btnSandwich.BackgroundImage"), System.Drawing.Image)
        Me.btnSandwich.Location = New System.Drawing.Point(6, 37)
        Me.btnSandwich.Name = "btnSandwich"
        Me.btnSandwich.Size = New System.Drawing.Size(102, 80)
        Me.btnSandwich.TabIndex = 8
        Me.btnSandwich.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(128, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 80)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(244, 37)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 80)
        Me.Button3.TabIndex = 10
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tpgDrinks
        '
        Me.tpgDrinks.Controls.Add(Me.btbnPepsi)
        Me.tpgDrinks.Controls.Add(Me.Button5)
        Me.tpgDrinks.Controls.Add(Me.Button6)
        Me.tpgDrinks.Location = New System.Drawing.Point(4, 22)
        Me.tpgDrinks.Name = "tpgDrinks"
        Me.tpgDrinks.Size = New System.Drawing.Size(392, 304)
        Me.tpgDrinks.TabIndex = 2
        Me.tpgDrinks.Text = "Drinks"
        Me.tpgDrinks.UseVisualStyleBackColor = True
        '
        'btbnPepsi
        '
        Me.btbnPepsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btbnPepsi.BackgroundImage = CType(resources.GetObject("btbnPepsi.BackgroundImage"), System.Drawing.Image)
        Me.btbnPepsi.Location = New System.Drawing.Point(6, 37)
        Me.btbnPepsi.Name = "btbnPepsi"
        Me.btbnPepsi.Size = New System.Drawing.Size(102, 80)
        Me.btbnPepsi.TabIndex = 8
        Me.btbnPepsi.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(128, 37)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 80)
        Me.Button5.TabIndex = 9
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(244, 37)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 80)
        Me.Button6.TabIndex = 10
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btnTable1
        '
        Me.btnTable1.AutoSize = True
        Me.btnTable1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable1.Location = New System.Drawing.Point(19, 19)
        Me.btnTable1.Name = "btnTable1"
        Me.btnTable1.Size = New System.Drawing.Size(26, 28)
        Me.btnTable1.TabIndex = 13
        Me.btnTable1.Text = "1"
        Me.btnTable1.UseVisualStyleBackColor = True
        '
        'btnTable2
        '
        Me.btnTable2.AutoSize = True
        Me.btnTable2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable2.Location = New System.Drawing.Point(48, 19)
        Me.btnTable2.Name = "btnTable2"
        Me.btnTable2.Size = New System.Drawing.Size(26, 28)
        Me.btnTable2.TabIndex = 14
        Me.btnTable2.Text = "2"
        Me.btnTable2.UseVisualStyleBackColor = True
        '
        'btnTable4
        '
        Me.btnTable4.AutoSize = True
        Me.btnTable4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable4.Location = New System.Drawing.Point(108, 19)
        Me.btnTable4.Name = "btnTable4"
        Me.btnTable4.Size = New System.Drawing.Size(26, 28)
        Me.btnTable4.TabIndex = 16
        Me.btnTable4.Text = "4"
        Me.btnTable4.UseVisualStyleBackColor = True
        '
        'btnTable3
        '
        Me.btnTable3.AutoSize = True
        Me.btnTable3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTable3.Location = New System.Drawing.Point(76, 19)
        Me.btnTable3.Name = "btnTable3"
        Me.btnTable3.Size = New System.Drawing.Size(26, 28)
        Me.btnTable3.TabIndex = 15
        Me.btnTable3.Text = "3"
        Me.btnTable3.UseVisualStyleBackColor = True
        '
        'btnNone
        '
        Me.btnNone.AutoSize = True
        Me.btnNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNone.Location = New System.Drawing.Point(140, 19)
        Me.btnNone.Name = "btnNone"
        Me.btnNone.Size = New System.Drawing.Size(54, 28)
        Me.btnNone.TabIndex = 17
        Me.btnNone.Text = "None"
        Me.btnNone.UseVisualStyleBackColor = True
        '
        'btnTitle
        '
        Me.btnTitle.AutoSize = True
        Me.btnTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTitle.Location = New System.Drawing.Point(12, -2)
        Me.btnTitle.Name = "btnTitle"
        Me.btnTitle.Size = New System.Drawing.Size(101, 25)
        Me.btnTitle.TabIndex = 18
        Me.btnTitle.Text = "Bun Cafe"
        '
        'grpTable
        '
        Me.grpTable.Controls.Add(Me.btnTable4)
        Me.grpTable.Controls.Add(Me.lblTable)
        Me.grpTable.Controls.Add(Me.btnTable3)
        Me.grpTable.Controls.Add(Me.lblOrder)
        Me.grpTable.Controls.Add(Me.btnNone)
        Me.grpTable.Controls.Add(Me.btnTable2)
        Me.grpTable.Controls.Add(Me.btnTable1)
        Me.grpTable.Location = New System.Drawing.Point(504, 50)
        Me.grpTable.Name = "grpTable"
        Me.grpTable.Size = New System.Drawing.Size(202, 121)
        Me.grpTable.TabIndex = 19
        Me.grpTable.TabStop = False
        Me.grpTable.Text = "Table"
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.Location = New System.Drawing.Point(16, 92)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(40, 13)
        Me.lblTable.TabIndex = 24
        Me.lblTable.Text = "Table: "
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(16, 66)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(39, 13)
        Me.lblOrder.TabIndex = 23
        Me.lblOrder.Text = "Order: "
        '
        'Timer1
        '
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Location = New System.Drawing.Point(631, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(75, 23)
        Me.lblTime.TabIndex = 20
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Location = New System.Drawing.Point(201, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(254, 23)
        Me.lblDate.TabIndex = 21
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(552, 420)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 22
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnResv
        '
        Me.btnResv.Location = New System.Drawing.Point(604, 177)
        Me.btnResv.Name = "btnResv"
        Me.btnResv.Size = New System.Drawing.Size(75, 23)
        Me.btnResv.TabIndex = 25
        Me.btnResv.Text = "Reservation"
        Me.btnResv.UseVisualStyleBackColor = True
        '
        'lstSales
        '
        Me.lstSales.FormattingEnabled = True
        Me.lstSales.Location = New System.Drawing.Point(580, 487)
        Me.lstSales.Name = "lstSales"
        Me.lstSales.Size = New System.Drawing.Size(120, 95)
        Me.lstSales.TabIndex = 26
        '
        'lblSalesNum
        '
        Me.lblSalesNum.AutoSize = True
        Me.lblSalesNum.Location = New System.Drawing.Point(577, 471)
        Me.lblSalesNum.Name = "lblSalesNum"
        Me.lblSalesNum.Size = New System.Drawing.Size(91, 13)
        Me.lblSalesNum.TabIndex = 28
        Me.lblSalesNum.Text = "Number of Sales: "
        '
        'lstTotal
        '
        Me.lstTotal.FormattingEnabled = True
        Me.lstTotal.Location = New System.Drawing.Point(454, 487)
        Me.lstTotal.Name = "lstTotal"
        Me.lstTotal.Size = New System.Drawing.Size(120, 95)
        Me.lstTotal.TabIndex = 29
        '
        'lblSumTotal
        '
        Me.lblSumTotal.AutoSize = True
        Me.lblSumTotal.Location = New System.Drawing.Point(451, 471)
        Me.lblSumTotal.Name = "lblSumTotal"
        Me.lblSumTotal.Size = New System.Drawing.Size(58, 13)
        Me.lblSumTotal.TabIndex = 30
        Me.lblSumTotal.Text = "Total Sum:"
        '
        'lstBill
        '
        Me.lstBill.FormattingEnabled = True
        Me.lstBill.Location = New System.Drawing.Point(6, 14)
        Me.lstBill.Name = "lstBill"
        Me.lstBill.Size = New System.Drawing.Size(171, 173)
        Me.lstBill.TabIndex = 31
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 590)
        Me.Controls.Add(Me.lblSumTotal)
        Me.Controls.Add(Me.lstTotal)
        Me.Controls.Add(Me.lblSalesNum)
        Me.Controls.Add(Me.lstSales)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnResv)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.grpTable)
        Me.Controls.Add(Me.btnTitle)
        Me.Controls.Add(Me.btnTable)
        Me.Controls.Add(Me.tpgMenu)
        Me.Controls.Add(Me.grpReceipt)
        Me.Controls.Add(Me.grpMenu)
        Me.Name = "frmPOS"
        Me.Text = "Form1"
        Me.grpMenu.ResumeLayout(False)
        Me.grpReceipt.ResumeLayout(False)
        Me.tpgMenu.ResumeLayout(False)
        Me.tpgHotFood.ResumeLayout(False)
        Me.tpgColdFood.ResumeLayout(False)
        Me.tpgDrinks.ResumeLayout(False)
        Me.grpTable.ResumeLayout(False)
        Me.grpTable.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpMenu As GroupBox
    Friend WithEvents grpReceipt As GroupBox
    Friend WithEvents btnHotFood As Button
    Friend WithEvents btnDrinks As Button
    Friend WithEvents btnColdFood As Button
    Friend WithEvents btnSoup As Button
    Friend WithEvents btnPasta As Button
    Friend WithEvents btnRice As Button
    Friend WithEvents tpgMenu As TabControl
    Friend WithEvents tpgHotFood As TabPage
    Friend WithEvents tpgColdFood As TabPage
    Friend WithEvents tpgDrinks As TabPage
    Friend WithEvents btnSandwich As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btbnPepsi As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btnTable As Button
    Friend WithEvents btnTable1 As Button
    Friend WithEvents btnTable2 As Button
    Friend WithEvents btnTable4 As Button
    Friend WithEvents btnTable3 As Button
    Friend WithEvents btnNone As Button
    Friend WithEvents btnTitle As Label
    Friend WithEvents grpTable As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents lblOrder As Label
    Friend WithEvents lblTable As Label
    Friend WithEvents btnResv As Button
    Friend WithEvents lstSales As ListBox
    Friend WithEvents lblSalesNum As Label
    Friend WithEvents lstTotal As ListBox
    Friend WithEvents lblSumTotal As Label
    Friend WithEvents lstBill As ListBox
End Class
