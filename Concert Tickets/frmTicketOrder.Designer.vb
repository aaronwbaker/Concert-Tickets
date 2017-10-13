<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketOrder))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.lblPriceEach = New System.Windows.Forms.Label()
        Me.lblShowPrice = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblShowTotal = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCurrentPrices = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintPreviewCurrentOrder = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintCurrentOrder = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewSalesSummary = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintSalesSummary = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Bauhaus 93", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Firebrick
        Me.lblHeading.Location = New System.Drawing.Point(24, 39)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(156, 30)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Ticket Sales"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(25, 108)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 19)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(25, 180)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(76, 19)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "Quantity:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(116, 109)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 20)
        Me.txtName.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtName, "Enter name for the order")
        '
        'txtQuantity
        '
        Me.txtQuantity.Enabled = False
        Me.txtQuantity.Location = New System.Drawing.Point(116, 181)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(34, 20)
        Me.txtQuantity.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtQuantity, "Enter number of tickets needed")
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.Location = New System.Drawing.Point(25, 142)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(64, 19)
        Me.lblSection.TabIndex = 6
        Me.lblSection.Text = "Section:"
        '
        'cboSection
        '
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Items.AddRange(New Object() {"Orchestra", "Mezzanine", "General", "Balcony"})
        Me.cboSection.Location = New System.Drawing.Point(116, 143)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(121, 21)
        Me.cboSection.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cboSection, "Select seating section")
        '
        'lblPriceEach
        '
        Me.lblPriceEach.AutoSize = True
        Me.lblPriceEach.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceEach.Location = New System.Drawing.Point(267, 142)
        Me.lblPriceEach.Name = "lblPriceEach"
        Me.lblPriceEach.Size = New System.Drawing.Size(49, 19)
        Me.lblPriceEach.TabIndex = 8
        Me.lblPriceEach.Text = "Price:"
        '
        'lblShowPrice
        '
        Me.lblShowPrice.AutoSize = True
        Me.lblShowPrice.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowPrice.Location = New System.Drawing.Point(322, 142)
        Me.lblShowPrice.Name = "lblShowPrice"
        Me.lblShowPrice.Size = New System.Drawing.Size(53, 19)
        Me.lblShowPrice.TabIndex = 9
        Me.lblShowPrice.Text = "$88.88"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(267, 180)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(50, 19)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total:"
        '
        'lblShowTotal
        '
        Me.lblShowTotal.AutoSize = True
        Me.lblShowTotal.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowTotal.Location = New System.Drawing.Point(322, 180)
        Me.lblShowTotal.Name = "lblShowTotal"
        Me.lblShowTotal.Size = New System.Drawing.Size(69, 20)
        Me.lblShowTotal.TabIndex = 11
        Me.lblShowTotal.Text = "$8888.88"
        '
        'btnOrder
        '
        Me.btnOrder.Enabled = False
        Me.btnOrder.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(27, 247)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(90, 25)
        Me.btnOrder.TabIndex = 4
        Me.btnOrder.Text = "&Order"
        Me.ToolTip1.SetToolTip(Me.btnOrder, "Place ticket order")
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(162, 247)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 25)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear entered information")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(297, 247)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 25)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Close application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuView, Me.mnuAbout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(414, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrintOrder, Me.mnuPrintSummary, Me.ToolStripMenuItem2, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        Me.mnuFile.ToolTipText = "Print summary of current ticket order"
        '
        'mnuPrintOrder
        '
        Me.mnuPrintOrder.Enabled = False
        Me.mnuPrintOrder.Name = "mnuPrintOrder"
        Me.mnuPrintOrder.Size = New System.Drawing.Size(182, 22)
        Me.mnuPrintOrder.Text = "Print &Current Order"
        Me.mnuPrintOrder.ToolTipText = "Print summary of current ticket order"
        '
        'mnuPrintSummary
        '
        Me.mnuPrintSummary.Enabled = False
        Me.mnuPrintSummary.Name = "mnuPrintSummary"
        Me.mnuPrintSummary.Size = New System.Drawing.Size(182, 22)
        Me.mnuPrintSummary.Text = "Print Sales &Summary"
        Me.mnuPrintSummary.ToolTipText = "Print summary of all transactions"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripMenuItem2.Text = "---------------"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(182, 22)
        Me.mnuExit.Text = "E&xit"
        Me.mnuExit.ToolTipText = "Close application"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(132, 22)
        Me.mnuClear.Text = "&Clear Form"
        Me.mnuClear.ToolTipText = "Clear all entered information"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCurrentPrices})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 20)
        Me.mnuView.Text = "&View"
        '
        'mnuCurrentPrices
        '
        Me.mnuCurrentPrices.Name = "mnuCurrentPrices"
        Me.mnuCurrentPrices.Size = New System.Drawing.Size(183, 22)
        Me.mnuCurrentPrices.Text = "&Current Ticket Prices"
        Me.mnuCurrentPrices.ToolTipText = "View current ticket prices"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(52, 20)
        Me.mnuAbout.Text = "&About"
        Me.mnuAbout.ToolTipText = "View application info"
        '
        'PrintPreviewCurrentOrder
        '
        Me.PrintPreviewCurrentOrder.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewCurrentOrder.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewCurrentOrder.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewCurrentOrder.Enabled = True
        Me.PrintPreviewCurrentOrder.Icon = CType(resources.GetObject("PrintPreviewCurrentOrder.Icon"), System.Drawing.Icon)
        Me.PrintPreviewCurrentOrder.Name = "PrintPreviewCurrentOrder"
        Me.PrintPreviewCurrentOrder.Visible = False
        '
        'PrintCurrentOrder
        '
        '
        'PrintPreviewSalesSummary
        '
        Me.PrintPreviewSalesSummary.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewSalesSummary.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewSalesSummary.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewSalesSummary.Enabled = True
        Me.PrintPreviewSalesSummary.Icon = CType(resources.GetObject("PrintPreviewSalesSummary.Icon"), System.Drawing.Icon)
        Me.PrintPreviewSalesSummary.Name = "PrintPreviewSalesSummary"
        Me.PrintPreviewSalesSummary.Visible = False
        '
        'PrintSalesSummary
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(314, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'frmTicketOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(414, 293)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblShowTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblShowPrice)
        Me.Controls.Add(Me.lblPriceEach)
        Me.Controls.Add(Me.cboSection)
        Me.Controls.Add(Me.lblSection)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTicketOrder"
        Me.Text = "Ticket Sales"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblSection As Label
    Friend WithEvents cboSection As ComboBox
    Friend WithEvents lblPriceEach As Label
    Friend WithEvents lblShowPrice As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblShowTotal As Label
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents mnuPrintOrder As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuPrintSummary As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuView As ToolStripMenuItem
    Friend WithEvents mnuCurrentPrices As ToolStripMenuItem
    Friend WithEvents PrintPreviewCurrentOrder As PrintPreviewDialog
    Friend WithEvents PrintCurrentOrder As Printing.PrintDocument
    Friend WithEvents PrintPreviewSalesSummary As PrintPreviewDialog
    Friend WithEvents PrintSalesSummary As Printing.PrintDocument
    Friend WithEvents PictureBox1 As PictureBox
End Class
