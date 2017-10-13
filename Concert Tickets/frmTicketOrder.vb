' Program:  Concert Tickets
' Author:   Aaron Baker
' Date:     December 3, 2016
' Purpose:  This application allows the user to order tickets for an upcoming concert series.  The application 
'           allows the user to print a receipt for the current order, print a summary of the current order, and 
'           print a summary of all ticket sales for the current application session.  The user may also view current 
'           ticket prices for each seating section.


Option Strict On

Public Class frmTicketOrder

    Dim _dblPrice As Double ' price per ticket
    Dim _dblOrderTotal As Double ' total cost for current order
    Dim _intTransactionNumber As Integer ' current/total transaction(s)
    Dim _intTotalTickets As Integer ' total tickets sold
    Dim _TransactionTotals(6) As Double
    ' {number of tickets sold, total revenue, tickets sold for orchestra, tickets sold for mezzanine, tickets sold for general, tickets sold for balcony}
    Dim _CurrentTransaction(5) As Object
    ' {transaction number, name for the order, quantity of tickets, section, total cost}

    Private Sub frmTicketOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' When the form is first loaded, clear the text for the ShowPrice and ShowTotal labels and set the transaction 
        ' number to zero.

        lblShowPrice.Text = ""
        lblShowTotal.Text = ""
        _intTransactionNumber = 0

    End Sub

    ' BEGIN FORM EVENT HANDLERS

    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        ' Automatically update and display price when the user selects section and enable quantity.

        ' If Section is selected update and display price and enable Quantity text box.
        If cboSection.SelectedIndex <> -1 Then
            Dim strSection As String = cboSection.SelectedItem.ToString()
            lblShowPrice.Text = GetPrice(strSection).ToString("C")
            txtQuantity.Enabled = True
        End If

    End Sub


    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        ' Automatically update and display total when user enters quantity.

        ' If statement avoids error message when text box is cleared.  Otherwise TextChanged event will only occur
        ' if user has entered text in the Quantity text box.
        If txtQuantity.Text.Length <> 0 Then

            Dim intQuantity As Integer
            Dim blnValidQuantity As Boolean = False

            Try
                intQuantity = Convert.ToInt32(txtQuantity.Text)
            Catch ex As Exception
                MsgBox("Must be a number.")
                txtQuantity.Text = ""
                txtQuantity.Focus()
                Return
            End Try

            If intQuantity > 0 Then
                blnValidQuantity = True
            Else
                MsgBox("Must enter a positive number.")
                txtQuantity.Text = ""
                txtQuantity.Focus()
                Return
            End If

            ' If valid then update and display total price and enable Order function.
            If blnValidQuantity Then
                _dblOrderTotal = intQuantity * _dblPrice
                lblShowTotal.Text = _dblOrderTotal.ToString("C")
                btnOrder.Enabled = True
            End If
        End If

    End Sub


    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        ' This event handler executes when the user clicks the Order button.  All relevant order information is stored 
        ' in the _CurrentTransaction array and the accumulated information for all transcations is updated in the 
        ' _TransactionTotals array.  The print functions are also enabled.  A new ShowOrder form is opened to display 
        ' the current order information for the user.

        ' Verify that a name has been entered for the current order
        If txtName.Text.Length = 0 Then
            MsgBox("Please enter a name for the order.")
            txtName.Focus()
            Return
        End If

        ' Set current transaction number
        _intTransactionNumber += 1
        ' Add tickets from this order to accumulated total for all orders
        _intTotalTickets += Convert.ToInt32(txtQuantity.Text)

        ' Store current order info in array
        PopulateCurrentTransaction()
        ' Update cummulative order info
        PopulateTransactionTotals()

        ' Enable the print functions
        mnuPrintOrder.Enabled = True
        mnuPrintSummary.Enabled = True

        ' Open and display order info in ShowOrder form
        Dim frmShowOrder As New frmShowOrder
        Me.Hide()
        frmShowOrder.ShowDialog()

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler executes when the user clicks the Clear button.  All text boxes are cleared, the ShowPrice 
        ' and ShowTotal labels are cleared, and the Section drop down list is reset.  The Price and OrderTotal variables 
        ' are reset to zero, and the PrintOrder menu function, Order button, and Quantity text box are disabled.  The 
        ' focus is set to the Name text box to prompt the user to input the next order.

        txtName.Text = ""
        cboSection.SelectedIndex = -1
        lblShowPrice.Text = ""
        txtQuantity.Text = ""
        txtQuantity.Enabled = False
        lblShowTotal.Text = ""
        btnOrder.Enabled = False
        mnuPrintOrder.Enabled = False
        _dblPrice = 0
        _dblOrderTotal = 0
        txtName.Focus()

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close Concert Ticket application when the user clicks the Exit button.

        Application.Exit()

    End Sub


    Private Sub mnuPrintOrder_Click(sender As Object, e As EventArgs) Handles mnuPrintOrder.Click
        ' Open the print preview dialog for the CurrentOrder document when the user selects the PrintOrder 
        ' menu function.

        PrintPreviewCurrentOrder.Document = PrintCurrentOrder
        PrintPreviewCurrentOrder.ShowDialog()

    End Sub


    Private Sub mnuPrintSummary_Click(sender As Object, e As EventArgs) Handles mnuPrintSummary.Click
        ' Open the print preview dialog for the SalesSummary document when the user selects the PrintSummary 
        ' menu function.

        PrintPreviewSalesSummary.Document = PrintSalesSummary
        PrintPreviewSalesSummary.ShowDialog()

    End Sub


    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' Close application when the user selects the Exit menu item.

        Application.Exit()

    End Sub


    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' This event handler executes when the user selects the Clear menu option.  All text boxes are cleared, the ShowPrice 
        ' and ShowTotal labels are cleared, and the Section drop down list is reset.  The Price and OrderTotal variables 
        ' are reset to zero, and the PrintOrder menu function, Order button, and Quantity text box are disabled.  The 
        ' focus is set to the Name text box to prompt the user to input the next order.

        txtName.Text = ""
        cboSection.SelectedIndex = -1
        lblShowPrice.Text = ""
        txtQuantity.Text = ""
        txtQuantity.Enabled = False
        lblShowTotal.Text = ""
        btnOrder.Enabled = False
        mnuPrintOrder.Enabled = False
        _dblPrice = 0
        _dblOrderTotal = 0
        txtName.Focus()

    End Sub


    Private Sub mnuCurrentPrices_Click(sender As Object, e As EventArgs) Handles mnuCurrentPrices.Click
        ' When the user clicks the View > CurrentPrices menu item, hide the TicketOrder form and open a new 
        ' TicketPrice form.

        Dim frmTicketPrice As New frmTicketPrice
        Me.Hide()
        frmTicketPrice.ShowDialog()

    End Sub


    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        ' Hide the current form and display a new AboutBox when the user selects the About menu function.

        Dim AboutBox = New AboutBox1
        Me.Hide()
        AboutBox.ShowDialog()

    End Sub


    Private Sub frmTicketOrder_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        ' Close Concert Ticket application if the user closes the window instead of clicking the Exit button.

        Application.Exit()

    End Sub

    ' BEGIN SUB-PROCEDURE DEFINITIONS

    Private Sub PopulateCurrentTransaction()
        ' Populate _CurrentTransaction array with information for the current order.  Sub-procedure is called by the 
        ' btnOrder_Click event.

        _CurrentTransaction(0) = _intTransactionNumber
        _CurrentTransaction(1) = txtName.Text
        _CurrentTransaction(2) = txtQuantity.Text
        _CurrentTransaction(3) = cboSection.SelectedItem
        _CurrentTransaction(4) = _dblOrderTotal

    End Sub


    Private Sub PopulateTransactionTotals()
        ' Update the _TransactionTotals array (holds accumulated values) for the current transaction.
        ' This sub-procedure is called by the btnOrder_Click event.

        Dim strSection As String = cboSection.SelectedItem.ToString()
        Dim section As Integer

        ' Indexes 2 - 5 of the _TrasactionsTotals array tracks number of tickets sold for each section.
        ' Select appropriate index add current transaction to.
        Select Case strSection
            Case "Orchestra"
                section = 2
            Case "Mezzanine"
                section = 3
            Case "General"
                section = 4
            Case "Balcony"
                section = 5
        End Select

        _TransactionTotals(0) = _intTotalTickets ' add tickets sold from current order to accumulated total
        _TransactionTotals(1) += _dblOrderTotal ' add current transaction to accumulated total
        _TransactionTotals(section) += Convert.ToInt32(txtQuantity.Text) ' add number of tickets to total for appropriate section

    End Sub


    Private Sub PrintCurrentOrder_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintCurrentOrder.PrintPage
        ' This sub-procedure contains the logic for printing a summary of the current transaction (CurrentOrder).

        ' Set the font, line height, font color, and print location for the main body of the document.
        Dim prtFont As New Font("Times New Roman", 12)
        Dim prtLineHeight As Single = prtFont.GetHeight + 10
        Dim prtBrush = Brushes.Black
        Dim prtLeftLocation As Single = e.MarginBounds.Left
        Dim prtRightLocation As Single = e.MarginBounds.Left + 200
        Dim vPrintLocation As Single = e.MarginBounds.Top + 100

        ' print title
        e.Graphics.DrawString("Order Summary for " & _CurrentTransaction(1).ToString, New Font("Times New Roman", 16, FontStyle.Bold), prtBrush, e.MarginBounds.Left, e.MarginBounds.Top)
        ' print transaction number for this order
        e.Graphics.DrawString("Transaction ID:", prtFont, prtBrush, prtLeftLocation, vPrintLocation)
        e.Graphics.DrawString(_CurrentTransaction(0).ToString, prtFont, prtBrush, prtRightLocation, vPrintLocation)
        ' print number of tickets ordered
        vPrintLocation += prtLineHeight
        e.Graphics.DrawString("Number of Tickets:", prtFont, prtBrush, prtLeftLocation, vPrintLocation)
        e.Graphics.DrawString(_CurrentTransaction(2).ToString, prtFont, prtBrush, prtRightLocation, vPrintLocation)
        ' print selected seating section
        vPrintLocation += prtLineHeight
        e.Graphics.DrawString("Seating Section:", prtFont, prtBrush, prtLeftLocation, vPrintLocation)
        e.Graphics.DrawString(_CurrentTransaction(3).ToString, prtFont, prtBrush, prtRightLocation, vPrintLocation)
        ' print total cost for this order
        vPrintLocation += prtLineHeight
        e.Graphics.DrawString("Total Ticket Cost:", prtFont, prtBrush, prtLeftLocation, vPrintLocation)
        e.Graphics.DrawString((Convert.ToDouble(_CurrentTransaction(4).ToString)).ToString("C"), prtFont, prtBrush, prtRightLocation, vPrintLocation)

    End Sub


    Private Sub PrintSalesSummary_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintSalesSummary.PrintPage
        ' This sub-procedure contains the logic for printing the summary report for all ticket sales (SalesSummary).

        ' Sent font, line height, font color, and print location for the main part of the document
        Dim prtFont As New Font("Times New Roman", 12)
        Dim prtLineHeight As Single = prtFont.GetHeight + 10
        Dim prtBrush = Brushes.Black
        Dim prtLeftLocation As Single = e.MarginBounds.Left
        Dim prtRightLocation As Single = e.MarginBounds.Left + 250
        Dim vPrintLocation As Single = e.MarginBounds.Top + 100

        ' print title
        e.Graphics.DrawString("Total Ticket Sales Summary Report", New Font("Times New Roman", 16, FontStyle.Bold), prtBrush, e.MarginBounds.Left, e.MarginBounds.Top)
        ' print total number of tickets sold
        e.Graphics.DrawString("Total Tickets Sold:", prtFont, prtBrush, prtLeftLocation, vPrintLocation)
        e.Graphics.DrawString(_TransactionTotals(0).ToString, prtFont, prtBrush, prtRightLocation, vPrintLocation)
        ' print number of tickets ordered
        vPrintLocation += prtLineHeight
        e.Graphics.DrawString("Total Ticket Sales:", prtFont, prtBrush, prtLeftLocation, vPrintLocation)
        e.Graphics.DrawString((Convert.ToDouble(_TransactionTotals(1).ToString)).ToString("C"), prtFont, prtBrush, prtRightLocation, vPrintLocation)
        ' print tickets sold for Orchestra section
        vPrintLocation += prtLineHeight
        e.Graphics.DrawString("Sales for Orchestra Section:", prtFont, prtBrush, prtLeftLocation, vPrintLocation)
        e.Graphics.DrawString(_TransactionTotals(2).ToString, prtFont, prtBrush, prtRightLocation, vPrintLocation)
        ' print tickets sold for Mezzanine section
        vPrintLocation += prtLineHeight
        e.Graphics.DrawString("Sales for Mezzanine Section:", prtFont, prtBrush, prtLeftLocation, vPrintLocation)
        e.Graphics.DrawString(_TransactionTotals(3).ToString, prtFont, prtBrush, prtRightLocation, vPrintLocation)
        ' print tickets sold for General section
        vPrintLocation += prtLineHeight
        e.Graphics.DrawString("Sales for General Section:", prtFont, prtBrush, prtLeftLocation, vPrintLocation)
        e.Graphics.DrawString(_TransactionTotals(4).ToString, prtFont, prtBrush, prtRightLocation, vPrintLocation)
        'print tickets sold for Balcony section
        vPrintLocation += prtLineHeight
        e.Graphics.DrawString("Sales for Balcony Section:", prtFont, prtBrush, prtLeftLocation, vPrintLocation)
        e.Graphics.DrawString(_TransactionTotals(5).ToString, prtFont, prtBrush, prtRightLocation, vPrintLocation)

    End Sub

    ' BEGIN FUNCTION DEFINITIONS

    Public Function GetPrice(strSection As String) As Double
        ' Return price per ticket based on section.

        Select Case strSection
            Case "Orchestra"
                _dblPrice = 40D
            Case "Mezzanine"
                _dblPrice = 27.5D
            Case "General"
                _dblPrice = 15D
            Case "Balcony"
                _dblPrice = 10D
        End Select

        Return _dblPrice

    End Function


    Public Function GetCurrentTransaction(index As Integer) As Object
        ' Return value for the desired index in the _CurrentTransaction array.

        Return _CurrentTransaction(index)

    End Function


End Class
