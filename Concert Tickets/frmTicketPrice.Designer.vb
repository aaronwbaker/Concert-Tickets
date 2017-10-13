<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketPrice
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblOrchestraPrice = New System.Windows.Forms.Label()
        Me.lblMezzaninePrice = New System.Windows.Forms.Label()
        Me.lblGeneralPrice = New System.Windows.Forms.Label()
        Me.lblBalconyPrice = New System.Windows.Forms.Label()
        Me.lblOrchestra = New System.Windows.Forms.Label()
        Me.lblMezzanine = New System.Windows.Forms.Label()
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.lblBalcony = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Firebrick
        Me.lblHeading.Location = New System.Drawing.Point(46, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(193, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Current Ticket Prices"
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.Location = New System.Drawing.Point(12, 46)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(110, 20)
        Me.lblSection.TabIndex = 1
        Me.lblSection.Text = "Seating Section"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(188, 46)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(43, 20)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price"
        '
        'lblOrchestraPrice
        '
        Me.lblOrchestraPrice.AutoSize = True
        Me.lblOrchestraPrice.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrchestraPrice.Location = New System.Drawing.Point(188, 80)
        Me.lblOrchestraPrice.Name = "lblOrchestraPrice"
        Me.lblOrchestraPrice.Size = New System.Drawing.Size(61, 19)
        Me.lblOrchestraPrice.TabIndex = 3
        Me.lblOrchestraPrice.Text = "$888.88"
        '
        'lblMezzaninePrice
        '
        Me.lblMezzaninePrice.AutoSize = True
        Me.lblMezzaninePrice.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMezzaninePrice.Location = New System.Drawing.Point(188, 108)
        Me.lblMezzaninePrice.Name = "lblMezzaninePrice"
        Me.lblMezzaninePrice.Size = New System.Drawing.Size(61, 19)
        Me.lblMezzaninePrice.TabIndex = 4
        Me.lblMezzaninePrice.Text = "$888.88"
        '
        'lblGeneralPrice
        '
        Me.lblGeneralPrice.AutoSize = True
        Me.lblGeneralPrice.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneralPrice.Location = New System.Drawing.Point(188, 136)
        Me.lblGeneralPrice.Name = "lblGeneralPrice"
        Me.lblGeneralPrice.Size = New System.Drawing.Size(61, 19)
        Me.lblGeneralPrice.TabIndex = 5
        Me.lblGeneralPrice.Text = "$888.88"
        '
        'lblBalconyPrice
        '
        Me.lblBalconyPrice.AutoSize = True
        Me.lblBalconyPrice.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalconyPrice.Location = New System.Drawing.Point(188, 164)
        Me.lblBalconyPrice.Name = "lblBalconyPrice"
        Me.lblBalconyPrice.Size = New System.Drawing.Size(61, 19)
        Me.lblBalconyPrice.TabIndex = 6
        Me.lblBalconyPrice.Text = "$888.88"
        '
        'lblOrchestra
        '
        Me.lblOrchestra.AutoSize = True
        Me.lblOrchestra.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrchestra.Location = New System.Drawing.Point(12, 80)
        Me.lblOrchestra.Name = "lblOrchestra"
        Me.lblOrchestra.Size = New System.Drawing.Size(76, 19)
        Me.lblOrchestra.TabIndex = 7
        Me.lblOrchestra.Text = "Orchestra"
        '
        'lblMezzanine
        '
        Me.lblMezzanine.AutoSize = True
        Me.lblMezzanine.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMezzanine.Location = New System.Drawing.Point(12, 108)
        Me.lblMezzanine.Name = "lblMezzanine"
        Me.lblMezzanine.Size = New System.Drawing.Size(81, 19)
        Me.lblMezzanine.TabIndex = 8
        Me.lblMezzanine.Text = "Mezzanine"
        '
        'lblGeneral
        '
        Me.lblGeneral.AutoSize = True
        Me.lblGeneral.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneral.Location = New System.Drawing.Point(12, 136)
        Me.lblGeneral.Name = "lblGeneral"
        Me.lblGeneral.Size = New System.Drawing.Size(62, 19)
        Me.lblGeneral.TabIndex = 9
        Me.lblGeneral.Text = "General"
        '
        'lblBalcony
        '
        Me.lblBalcony.AutoSize = True
        Me.lblBalcony.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalcony.Location = New System.Drawing.Point(12, 164)
        Me.lblBalcony.Name = "lblBalcony"
        Me.lblBalcony.Size = New System.Drawing.Size(65, 19)
        Me.lblBalcony.TabIndex = 10
        Me.lblBalcony.Text = "Balcony"
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(102, 207)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(80, 25)
        Me.btnOk.TabIndex = 11
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmTicketPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblBalcony)
        Me.Controls.Add(Me.lblGeneral)
        Me.Controls.Add(Me.lblMezzanine)
        Me.Controls.Add(Me.lblOrchestra)
        Me.Controls.Add(Me.lblBalconyPrice)
        Me.Controls.Add(Me.lblGeneralPrice)
        Me.Controls.Add(Me.lblMezzaninePrice)
        Me.Controls.Add(Me.lblOrchestraPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblSection)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmTicketPrice"
        Me.Text = "Current Prices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSection As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblOrchestraPrice As Label
    Friend WithEvents lblMezzaninePrice As Label
    Friend WithEvents lblGeneralPrice As Label
    Friend WithEvents lblBalconyPrice As Label
    Friend WithEvents lblOrchestra As Label
    Friend WithEvents lblMezzanine As Label
    Friend WithEvents lblGeneral As Label
    Friend WithEvents lblBalcony As Label
    Friend WithEvents btnOk As Button
End Class
