<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowOrder))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblShowOrder = New System.Windows.Forms.Label()
        Me.lblShowName = New System.Windows.Forms.Label()
        Me.lblShowTickets = New System.Windows.Forms.Label()
        Me.lblShowSection = New System.Windows.Forms.Label()
        Me.lblShowCost = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Firebrick
        Me.lblHeading.Location = New System.Drawing.Point(50, 13)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(184, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Ticket Sales Receipt"
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(13, 51)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(113, 19)
        Me.lblOrder.TabIndex = 1
        Me.lblOrder.Text = "Order Number:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(13, 78)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 19)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tickets Purchased:"
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.Location = New System.Drawing.Point(13, 132)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(64, 19)
        Me.lblSection.TabIndex = 4
        Me.lblSection.Text = "Section:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(13, 159)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(84, 19)
        Me.lblCost.TabIndex = 5
        Me.lblCost.Text = "Total Cost:"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(24, 206)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 25)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "&Print Receipt"
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Print receipt exactly as it appears here")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(160, 206)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(100, 25)
        Me.btnReturn.TabIndex = 7
        Me.btnReturn.Text = "R&eturn"
        Me.ToolTip1.SetToolTip(Me.btnReturn, "Return to order form")
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lblShowOrder
        '
        Me.lblShowOrder.AutoSize = True
        Me.lblShowOrder.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowOrder.Location = New System.Drawing.Point(166, 51)
        Me.lblShowOrder.Name = "lblShowOrder"
        Me.lblShowOrder.Size = New System.Drawing.Size(60, 19)
        Me.lblShowOrder.TabIndex = 8
        Me.lblShowOrder.Text = "Order#"
        '
        'lblShowName
        '
        Me.lblShowName.AutoSize = True
        Me.lblShowName.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowName.Location = New System.Drawing.Point(166, 78)
        Me.lblShowName.Name = "lblShowName"
        Me.lblShowName.Size = New System.Drawing.Size(49, 19)
        Me.lblShowName.TabIndex = 9
        Me.lblShowName.Text = "Name"
        '
        'lblShowTickets
        '
        Me.lblShowTickets.AutoSize = True
        Me.lblShowTickets.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowTickets.Location = New System.Drawing.Point(166, 105)
        Me.lblShowTickets.Name = "lblShowTickets"
        Me.lblShowTickets.Size = New System.Drawing.Size(70, 19)
        Me.lblShowTickets.TabIndex = 10
        Me.lblShowTickets.Text = "#Tickets"
        '
        'lblShowSection
        '
        Me.lblShowSection.AutoSize = True
        Me.lblShowSection.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowSection.Location = New System.Drawing.Point(166, 132)
        Me.lblShowSection.Name = "lblShowSection"
        Me.lblShowSection.Size = New System.Drawing.Size(60, 19)
        Me.lblShowSection.TabIndex = 11
        Me.lblShowSection.Text = "Section"
        '
        'lblShowCost
        '
        Me.lblShowCost.AutoSize = True
        Me.lblShowCost.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowCost.Location = New System.Drawing.Point(166, 159)
        Me.lblShowCost.Name = "lblShowCost"
        Me.lblShowCost.Size = New System.Drawing.Size(47, 19)
        Me.lblShowCost.TabIndex = 12
        Me.lblShowCost.Text = "$Cost"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frmShowOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblShowCost)
        Me.Controls.Add(Me.lblShowSection)
        Me.Controls.Add(Me.lblShowTickets)
        Me.Controls.Add(Me.lblShowName)
        Me.Controls.Add(Me.lblShowOrder)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblSection)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmShowOrder"
        Me.Text = "Sales Receipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblOrder As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSection As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblShowOrder As Label
    Friend WithEvents lblShowName As Label
    Friend WithEvents lblShowTickets As Label
    Friend WithEvents lblShowSection As Label
    Friend WithEvents lblShowCost As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
