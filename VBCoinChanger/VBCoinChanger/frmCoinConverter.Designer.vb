<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoinConverter
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
        Me.ttpCoinConverter = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblProgrammerName = New System.Windows.Forms.Label()
        Me.lblEntry = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.lblDollarAmount = New System.Windows.Forms.Label()
        Me.lblAverageCoinValue = New System.Windows.Forms.Label()
        Me.txtEntry = New System.Windows.Forms.TextBox()
        Me.txtQuarters = New System.Windows.Forms.TextBox()
        Me.txtDimes = New System.Windows.Forms.TextBox()
        Me.txtNickels = New System.Windows.Forms.TextBox()
        Me.txtPennies = New System.Windows.Forms.TextBox()
        Me.txtDollarAmount = New System.Windows.Forms.TextBox()
        Me.txtAverageCoinValue = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Old English Text MT", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.Location = New System.Drawing.Point(48, -2)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(421, 45)
        Me.lblCompanyName.TabIndex = 0
        Me.lblCompanyName.Text = "Ye Olde Coin Converter"
        '
        'lblProgrammerName
        '
        Me.lblProgrammerName.AutoSize = True
        Me.lblProgrammerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgrammerName.Location = New System.Drawing.Point(157, 43)
        Me.lblProgrammerName.Name = "lblProgrammerName"
        Me.lblProgrammerName.Size = New System.Drawing.Size(132, 20)
        Me.lblProgrammerName.TabIndex = 1
        Me.lblProgrammerName.Text = "Programmed by:  "
        '
        'lblEntry
        '
        Me.lblEntry.AutoSize = True
        Me.lblEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntry.Location = New System.Drawing.Point(158, 93)
        Me.lblEntry.Name = "lblEntry"
        Me.lblEntry.Size = New System.Drawing.Size(145, 13)
        Me.lblEntry.TabIndex = 2
        Me.lblEntry.Text = "Enter number of pennies"
        Me.lblEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarters.Location = New System.Drawing.Point(251, 144)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(55, 13)
        Me.lblQuarters.TabIndex = 3
        Me.lblQuarters.Text = "Quarters"
        Me.lblQuarters.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimes.Location = New System.Drawing.Point(251, 186)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(41, 13)
        Me.lblDimes.TabIndex = 4
        Me.lblDimes.Text = "Dimes"
        Me.lblDimes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickels.Location = New System.Drawing.Point(251, 231)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(49, 13)
        Me.lblNickels.TabIndex = 5
        Me.lblNickels.Text = "Nickels"
        Me.lblNickels.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPennies.Location = New System.Drawing.Point(251, 275)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(52, 13)
        Me.lblPennies.TabIndex = 6
        Me.lblPennies.Text = "Pennies"
        Me.lblPennies.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDollarAmount
        '
        Me.lblDollarAmount.AutoSize = True
        Me.lblDollarAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollarAmount.Location = New System.Drawing.Point(219, 361)
        Me.lblDollarAmount.Name = "lblDollarAmount"
        Me.lblDollarAmount.Size = New System.Drawing.Size(86, 13)
        Me.lblDollarAmount.TabIndex = 7
        Me.lblDollarAmount.Text = "Dollar Amount"
        Me.lblDollarAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAverageCoinValue
        '
        Me.lblAverageCoinValue.AutoSize = True
        Me.lblAverageCoinValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageCoinValue.Location = New System.Drawing.Point(191, 407)
        Me.lblAverageCoinValue.Name = "lblAverageCoinValue"
        Me.lblAverageCoinValue.Size = New System.Drawing.Size(119, 13)
        Me.lblAverageCoinValue.TabIndex = 8
        Me.lblAverageCoinValue.Text = "Average Coin Value"
        Me.lblAverageCoinValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEntry
        '
        Me.txtEntry.Location = New System.Drawing.Point(327, 86)
        Me.txtEntry.Name = "txtEntry"
        Me.txtEntry.Size = New System.Drawing.Size(56, 20)
        Me.txtEntry.TabIndex = 9
        '
        'txtQuarters
        '
        Me.txtQuarters.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQuarters.Location = New System.Drawing.Point(327, 137)
        Me.txtQuarters.Name = "txtQuarters"
        Me.txtQuarters.ReadOnly = True
        Me.txtQuarters.Size = New System.Drawing.Size(56, 20)
        Me.txtQuarters.TabIndex = 10
        '
        'txtDimes
        '
        Me.txtDimes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDimes.Location = New System.Drawing.Point(327, 179)
        Me.txtDimes.Name = "txtDimes"
        Me.txtDimes.ReadOnly = True
        Me.txtDimes.Size = New System.Drawing.Size(56, 20)
        Me.txtDimes.TabIndex = 11
        '
        'txtNickels
        '
        Me.txtNickels.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNickels.Location = New System.Drawing.Point(327, 224)
        Me.txtNickels.Name = "txtNickels"
        Me.txtNickels.ReadOnly = True
        Me.txtNickels.Size = New System.Drawing.Size(56, 20)
        Me.txtNickels.TabIndex = 12
        '
        'txtPennies
        '
        Me.txtPennies.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPennies.Location = New System.Drawing.Point(327, 268)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.ReadOnly = True
        Me.txtPennies.Size = New System.Drawing.Size(56, 20)
        Me.txtPennies.TabIndex = 13
        '
        'txtDollarAmount
        '
        Me.txtDollarAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDollarAmount.Location = New System.Drawing.Point(327, 354)
        Me.txtDollarAmount.Name = "txtDollarAmount"
        Me.txtDollarAmount.ReadOnly = True
        Me.txtDollarAmount.Size = New System.Drawing.Size(83, 20)
        Me.txtDollarAmount.TabIndex = 14
        '
        'txtAverageCoinValue
        '
        Me.txtAverageCoinValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAverageCoinValue.Location = New System.Drawing.Point(327, 400)
        Me.txtAverageCoinValue.Name = "txtAverageCoinValue"
        Me.txtAverageCoinValue.ReadOnly = True
        Me.txtAverageCoinValue.Size = New System.Drawing.Size(83, 20)
        Me.txtAverageCoinValue.TabIndex = 15
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(87, 455)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(218, 455)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(335, 455)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VBCoinChanger.My.Resources.Resources.antique_cash_register
        Me.PictureBox1.Location = New System.Drawing.Point(56, 137)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'frmCoinConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 503)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtAverageCoinValue)
        Me.Controls.Add(Me.txtDollarAmount)
        Me.Controls.Add(Me.txtPennies)
        Me.Controls.Add(Me.txtNickels)
        Me.Controls.Add(Me.txtDimes)
        Me.Controls.Add(Me.txtQuarters)
        Me.Controls.Add(Me.txtEntry)
        Me.Controls.Add(Me.lblAverageCoinValue)
        Me.Controls.Add(Me.lblDollarAmount)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblEntry)
        Me.Controls.Add(Me.lblProgrammerName)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Name = "frmCoinConverter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coin Converter"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ttpCoinConverter As System.Windows.Forms.ToolTip
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents lblProgrammerName As System.Windows.Forms.Label
    Friend WithEvents lblEntry As System.Windows.Forms.Label
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblNickels As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    Friend WithEvents lblDollarAmount As System.Windows.Forms.Label
    Friend WithEvents lblAverageCoinValue As System.Windows.Forms.Label
    Friend WithEvents txtEntry As System.Windows.Forms.TextBox
    Friend WithEvents txtQuarters As System.Windows.Forms.TextBox
    Friend WithEvents txtDimes As System.Windows.Forms.TextBox
    Friend WithEvents txtNickels As System.Windows.Forms.TextBox
    Friend WithEvents txtPennies As System.Windows.Forms.TextBox
    Friend WithEvents txtDollarAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtAverageCoinValue As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
