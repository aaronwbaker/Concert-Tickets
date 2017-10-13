Option Strict On

Public Class frmTicketPrice

    Private Sub frmTicketPrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Automatically retrieve and display the current ticket prices when the form is loaded.

        lblOrchestraPrice.Text = frmTicketOrder.GetPrice("Orchestra").ToString("C")
        lblMezzaninePrice.Text = frmTicketOrder.GetPrice("Mezzanine").ToString("C")
        lblGeneralPrice.Text = frmTicketOrder.GetPrice("General").ToString("C")
        lblBalconyPrice.Text = frmTicketOrder.GetPrice("Balcony").ToString("C")

    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ' Close the form and reopen the TicketOrder form when the user clicks the Ok button.
        Close()
        frmTicketOrder.Show()

    End Sub


    Private Sub frmTicketPrice_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        ' Reopen the TicketOrder form if this form is closed by other means.
        frmTicketOrder.Show()

    End Sub

End Class