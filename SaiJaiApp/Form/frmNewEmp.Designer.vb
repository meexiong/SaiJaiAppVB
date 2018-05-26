<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewEmp
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
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnNew = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtpbLink = New System.Windows.Forms.TextBox()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.cmb_Postion = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.RichTextBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtBOD = New System.Windows.Forms.DateTimePicker()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnCancel)
        Me.GroupPanel1.Controls.Add(Me.btnNew)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(739, 31)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuSide2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(104, 1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 23)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "ຍົກເລີກ"
        '
        'btnNew
        '
        Me.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNew.Location = New System.Drawing.Point(3, 1)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(95, 23)
        Me.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "ບັນທຶກ"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.txtpbLink)
        Me.GroupPanel2.Controls.Add(Me.pbImage)
        Me.GroupPanel2.Controls.Add(Me.cmb_Postion)
        Me.GroupPanel2.Controls.Add(Me.Label9)
        Me.GroupPanel2.Controls.Add(Me.txtAddress)
        Me.GroupPanel2.Controls.Add(Me.txtPhone)
        Me.GroupPanel2.Controls.Add(Me.txtBOD)
        Me.GroupPanel2.Controls.Add(Me.radMale)
        Me.GroupPanel2.Controls.Add(Me.radFemale)
        Me.GroupPanel2.Controls.Add(Me.Label8)
        Me.GroupPanel2.Controls.Add(Me.txtEmail)
        Me.GroupPanel2.Controls.Add(Me.Label7)
        Me.GroupPanel2.Controls.Add(Me.Label6)
        Me.GroupPanel2.Controls.Add(Me.Label5)
        Me.GroupPanel2.Controls.Add(Me.txtSurname)
        Me.GroupPanel2.Controls.Add(Me.Label4)
        Me.GroupPanel2.Controls.Add(Me.txtEmpName)
        Me.GroupPanel2.Controls.Add(Me.Label3)
        Me.GroupPanel2.Controls.Add(Me.Label2)
        Me.GroupPanel2.Controls.Add(Me.txtEmpID)
        Me.GroupPanel2.Controls.Add(Me.Label1)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 49)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(739, 444)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuSide2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 2
        '
        'txtpbLink
        '
        Me.txtpbLink.Location = New System.Drawing.Point(527, 168)
        Me.txtpbLink.Name = "txtpbLink"
        Me.txtpbLink.Size = New System.Drawing.Size(203, 35)
        Me.txtpbLink.TabIndex = 23
        '
        'pbImage
        '
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbImage.Location = New System.Drawing.Point(527, 6)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(203, 157)
        Me.pbImage.TabIndex = 22
        Me.pbImage.TabStop = False
        '
        'cmb_Postion
        '
        Me.cmb_Postion.FormattingEnabled = True
        Me.cmb_Postion.Location = New System.Drawing.Point(165, 44)
        Me.cmb_Postion.Name = "cmb_Postion"
        Me.cmb_Postion.Size = New System.Drawing.Size(325, 37)
        Me.cmb_Postion.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 29)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "ຕຳແໜ່ງ"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(165, 333)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(325, 96)
        Me.txtAddress.TabIndex = 19
        Me.txtAddress.Text = ""
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(165, 251)
        Me.txtPhone.Mask = "000 00000000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(145, 35)
        Me.txtPhone.TabIndex = 18
        '
        'txtBOD
        '
        Me.txtBOD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtBOD.Location = New System.Drawing.Point(165, 207)
        Me.txtBOD.Name = "txtBOD"
        Me.txtBOD.Size = New System.Drawing.Size(145, 35)
        Me.txtBOD.TabIndex = 17
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(230, 170)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(59, 33)
        Me.radMale.TabIndex = 16
        Me.radMale.TabStop = True
        Me.radMale.Text = "ຊາຍ"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(162, 170)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(49, 33)
        Me.radFemale.TabIndex = 15
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "ຍິງ"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 29)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "ທີ່ຢູ່ຂອງພະນັກງານ"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(165, 292)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(325, 35)
        Me.txtEmail.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 29)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ອີເມວ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ເບີໂທລະສັບ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ວັນ,ເດືອນ,ປີເກີດ"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(165, 128)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(325, 35)
        Me.txtSurname.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ນາມສະກຸນ"
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(165, 87)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(325, 35)
        Me.txtEmpName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ຊື່ພະນັກງານ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ເພດ"
        '
        'txtEmpID
        '
        Me.txtEmpID.Location = New System.Drawing.Point(165, 3)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(124, 35)
        Me.txtEmpID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ລະຫັດ"
        '
        'frmNewEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 505)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmNewEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Empployee"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnNew As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtAddress As RichTextBox
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents txtBOD As DateTimePicker
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_Postion As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents txtpbLink As TextBox
End Class
