<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.lblPrevious = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtYearsEmployed = New System.Windows.Forms.TextBox()
        Me.txtPreviousPurchases = New System.Windows.Forms.TextBox()
        Me.txtTodaysPurchases = New System.Windows.Forms.TextBox()
        Me.BtnSummary = New System.Windows.Forms.Button()
        Me.radEmployee = New System.Windows.Forms.RadioButton()
        Me.radManager = New System.Windows.Forms.RadioButton()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(33, 542)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(114, 23)
        Me.BtnCalculate.TabIndex = 0
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.Location = New System.Drawing.Point(186, 542)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(114, 23)
        Me.BtnNext.TabIndex = 1
        Me.BtnNext.Text = "Next Employee"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(529, 542)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(114, 23)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(44, 28)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(49, 16)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Name"
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYears.Location = New System.Drawing.Point(41, 98)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(198, 16)
        Me.lblYears.TabIndex = 5
        Me.lblYears.Text = "Number of Years Employed"
        '
        'lblPrevious
        '
        Me.lblPrevious.AutoSize = True
        Me.lblPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrevious.Location = New System.Drawing.Point(41, 163)
        Me.lblPrevious.Name = "lblPrevious"
        Me.lblPrevious.Size = New System.Drawing.Size(258, 16)
        Me.lblPrevious.TabIndex = 6
        Me.lblPrevious.Text = "Total Amount of Previous Purchases"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(41, 230)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(125, 16)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Employee Status"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(41, 327)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(191, 16)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Total of Today's Purchase"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(47, 47)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 9
        '
        'txtYearsEmployed
        '
        Me.txtYearsEmployed.Location = New System.Drawing.Point(47, 114)
        Me.txtYearsEmployed.Name = "txtYearsEmployed"
        Me.txtYearsEmployed.Size = New System.Drawing.Size(100, 20)
        Me.txtYearsEmployed.TabIndex = 10
        '
        'txtPreviousPurchases
        '
        Me.txtPreviousPurchases.Location = New System.Drawing.Point(47, 179)
        Me.txtPreviousPurchases.Name = "txtPreviousPurchases"
        Me.txtPreviousPurchases.Size = New System.Drawing.Size(100, 20)
        Me.txtPreviousPurchases.TabIndex = 11
        '
        'txtTodaysPurchases
        '
        Me.txtTodaysPurchases.Location = New System.Drawing.Point(44, 343)
        Me.txtTodaysPurchases.Name = "txtTodaysPurchases"
        Me.txtTodaysPurchases.Size = New System.Drawing.Size(100, 20)
        Me.txtTodaysPurchases.TabIndex = 13
        '
        'BtnSummary
        '
        Me.BtnSummary.Location = New System.Drawing.Point(385, 542)
        Me.BtnSummary.Name = "BtnSummary"
        Me.BtnSummary.Size = New System.Drawing.Size(114, 23)
        Me.BtnSummary.TabIndex = 30
        Me.BtnSummary.Text = "Discount Summary"
        Me.BtnSummary.UseVisualStyleBackColor = True
        '
        'radEmployee
        '
        Me.radEmployee.AutoSize = True
        Me.radEmployee.Location = New System.Drawing.Point(47, 246)
        Me.radEmployee.Name = "radEmployee"
        Me.radEmployee.Size = New System.Drawing.Size(71, 17)
        Me.radEmployee.TabIndex = 31
        Me.radEmployee.TabStop = True
        Me.radEmployee.Text = "Employee"
        Me.radEmployee.UseVisualStyleBackColor = True
        '
        'radManager
        '
        Me.radManager.AutoSize = True
        Me.radManager.Location = New System.Drawing.Point(47, 279)
        Me.radManager.Name = "radManager"
        Me.radManager.Size = New System.Drawing.Size(67, 17)
        Me.radManager.TabIndex = 32
        Me.radManager.TabStop = True
        Me.radManager.Text = "Manager"
        Me.radManager.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(338, 28)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(341, 218)
        Me.lblOutput.TabIndex = 33
        '
        'lblSummary
        '
        Me.lblSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSummary.Location = New System.Drawing.Point(338, 304)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(341, 175)
        Me.lblSummary.TabIndex = 34
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 627)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.radManager)
        Me.Controls.Add(Me.radEmployee)
        Me.Controls.Add(Me.BtnSummary)
        Me.Controls.Add(Me.txtTodaysPurchases)
        Me.Controls.Add(Me.txtPreviousPurchases)
        Me.Controls.Add(Me.txtYearsEmployed)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblPrevious)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Name = "Form1"
        Me.Text = "Employee Discount Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCalculate As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblYears As Label
    Friend WithEvents lblPrevious As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtYearsEmployed As TextBox
    Friend WithEvents txtPreviousPurchases As TextBox
    Friend WithEvents txtTodaysPurchases As TextBox
    Friend WithEvents BtnSummary As Button
    Friend WithEvents radEmployee As RadioButton
    Friend WithEvents radManager As RadioButton
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblSummary As Label
End Class
