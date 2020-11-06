Public Class frmPOS
    Private salesNum As New ArrayList()

    Private Structure Sale
        Public intSales As Integer
        Public ReadOnly Property Sales() As Integer
            Get
                Return intSales
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return intSales
        End Function
    End Structure

    Private objSale As Sale
    Private objNewSale As Sale



    Private totalItems As New ArrayList()
    Private Structure Total
        Public intTotal As Integer
        Public ReadOnly Property Total() As Integer
            Get
                Return intTotal
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return intTotal
        End Function
    End Structure

    Private objTotal As Sale
    Private objNewTotal As Sale

    Private Sub AddSale(ByVal sales As String)
        Dim objNewSale As Sale
        objNewSale.intSales = sales
        salesNum.Add(objNewSale)
        lstSales.Items.Add(objNewSale.ToString())
    End Sub

    Private Sub AddTotal(ByVal total As Integer)
        Dim objNewTotal As Total
        objNewTotal.intTotal = total
        salesNum.Add(objNewTotal)
        lstTotal.Items.Add(objNewTotal.ToString())
    End Sub

    Const strSoup As String = "Soup"
    Const decSoup As Decimal = 5.0
    Const strPasta As String = "Pasta"
    Const decPasta As Decimal = 8.0
    Const strRice As String = "Rice"
    Const decRice As Decimal = 7.0
    Const strSandwich As String = "Sandwich"
    Const decSandwich As Decimal = 9.51
    Const strPepsi As String = "Pepsi"
    Const decPepsi As Decimal = 2




    Private Sub btnHotFood_Click(sender As Object, e As EventArgs) Handles btnHotFood.Click
        'changes the tab to hot food
        tpgMenu.SelectTab(tpgHotFood)
    End Sub

    Private Sub btnColdFood_Click(sender As Object, e As EventArgs) Handles btnColdFood.Click
        'changes the tab to cold food
        tpgMenu.SelectTab(tpgColdFood)
    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        'changes the tab to drinks
        tpgMenu.SelectTab(tpgDrinks)
    End Sub
    ' Dim check As Boolean = True
    Private Sub btnSoup_Click(sender As Object, e As EventArgs) Handles btnSoup.Click
        'bill(strSoup, decSoup)  'add item to reciept
        'AddTotal(decSoup)       'add item to total
        'rtxBill.AppendText(reciept("soup", 5))
        lstBill.Items.Add(reciept(strSoup, decSoup))
        AddTotal(decSoup)

    End Sub

    Private Sub btnPasta_Click(sender As Object, e As EventArgs) Handles btnPasta.Click
        lstBill.Items.Add(reciept(strPasta, decPasta))
        AddTotal(decPasta)
    End Sub

    Private Sub btnRice_Click(sender As Object, e As EventArgs) Handles btnRice.Click
        lstBill.Items.Add(reciept(strRice, decRice))
        AddTotal(decRice)
    End Sub

    Private Sub btnSandwich_Click(sender As Object, e As EventArgs) Handles btnSandwich.Click
        lstBill.Items.Add(reciept(strSandwich, decSandwich))
        AddTotal(decSandwich)
    End Sub

    Private Sub btbnPepsi_Click(sender As Object, e As EventArgs) Handles btbnPepsi.Click
        lstBill.Items.Add(reciept(strPepsi, decPepsi))
        AddTotal(decPepsi)
    End Sub
    Private Sub btnTable_Click(sender As Object, e As EventArgs) Handles btnTable.Click
        frmTables.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'start clock timer
        Dim intTime As String = Date.Now.ToString("hh:mm:ss")
        lblTime.Text = intTime
        Timer1.Interval = 1000
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = Date.Now.ToLongDateString()

        'lblOrder.Text = lstSales.Items.Count
    End Sub
    Private Function reciept(ByVal item As String, ByVal price As Integer)
        Dim main As String = item & " ..... " & price.ToString("c2") & vbNewLine
        Return main
    End Function

    Private Function SumTotal() As Decimal
        Dim total As Decimal
        For i = 0 To lstTotal.Items.Count - 1
            total += Val(lstTotal.Items(i))
        Next
        Return total
    End Function

    Private Sub btnTable1_Click(sender As Object, e As EventArgs) Handles btnTable1.Click
        lblTable.Text = "Table: 1"

    End Sub

    Private Sub btnTable2_Click(sender As Object, e As EventArgs) Handles btnTable2.Click
        lblTable.Text = "Table: 2"
    End Sub

    Private Sub btnTable3_Click(sender As Object, e As EventArgs) Handles btnTable3.Click
        lblTable.Text = "Table: 3"

    End Sub

    Private Sub btnTable4_Click(sender As Object, e As EventArgs) Handles btnTable4.Click
        lblTable.Text = "Table: 4"

    End Sub

    Private Sub btnNone_Click(sender As Object, e As EventArgs) Handles btnNone.Click
        lblTable.Text = "Table: None"

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim strPay As String = InputBox("Total: " & SumTotal().ToString("c2"), "Enter Payment")
        Dim decPay As Decimal
        If Decimal.TryParse(strPay, decPay) Then
            If decPay >= SumTotal() Then
                MsgBox("Payment recieved")
                AddSale(lstSales.Items.Count + "1")
                lblSalesNum.Text = "Number of Sales: " & lstSales.Items.Count
                lstBill.Items.Clear()
                lstTotal.Items.Clear()
            Else
                MsgBox("Insufficient funds for payment")
            End If
        Else
            MsgBox("Error recieving payment")
        End If
    End Sub


End Class
