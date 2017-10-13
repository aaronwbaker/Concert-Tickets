Option Strict On

Public Class frmShowOrder

    Private Sub frmShowOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' When the form loads the order number, name, number of tickets, section, and total cost for the current 
        ' order is automatically displayed.  The information is stored in the _CurrentTransaction array in the 
        ' TicketOrder form and is retrieve using the public GetCurrentTransaction method.

        lblShowOrder.Text = frmTicketOrder.GetCurrentTransaction(0).ToString
        lblShowName.Text = frmTicketOrder.GetCurrentTransaction(1).ToString
        lblShowTickets.Text = frmTicketOrder.GetCurrentTransaction(2).ToString
        lblShowSection.Text = frmTicketOrder.GetCurrentTransaction(3).ToString
        Dim strCost As String = frmTicketOrder.GetCurrentTransaction(4).ToString ' convert cost to currency string format
        Dim dblCost As Double = Convert.ToDouble(strCost)
        lblShowCost.Text = dblCost.ToString("C")

    End Sub


    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' Close the ShowOrder form and reopen the TicketOrder form when the user clicks the Return button.

        Me.Close()
        frmTicketOrder.Show()

    End Sub


    Private Sub frmShowOrder_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        ' Reopen the ShowOrder form if the user clicks the close icon on the form instead of the Return button.

        frmTicketOrder.Show()

    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Print the form in its current state.

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub

End Class