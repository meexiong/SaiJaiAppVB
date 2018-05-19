<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewProduct
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
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.txtProdcutName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbCate = New System.Windows.Forms.ComboBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.txtNote = New System.Windows.Forms.RichTextBox()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnCancel)
        Me.GroupPanel1.Controls.Add(Me.btnSave)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(583, 32)
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
        Me.GroupPanel1.TabIndex = 0
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.txtNote)
        Me.GroupPanel2.Controls.Add(Me.cmbUnit)
        Me.GroupPanel2.Controls.Add(Me.cmbCate)
        Me.GroupPanel2.Controls.Add(Me.Label8)
        Me.GroupPanel2.Controls.Add(Me.txtTotal)
        Me.GroupPanel2.Controls.Add(Me.Label7)
        Me.GroupPanel2.Controls.Add(Me.Label6)
        Me.GroupPanel2.Controls.Add(Me.txtQty)
        Me.GroupPanel2.Controls.Add(Me.Label5)
        Me.GroupPanel2.Controls.Add(Me.txtPrice)
        Me.GroupPanel2.Controls.Add(Me.Label4)
        Me.GroupPanel2.Controls.Add(Me.Label3)
        Me.GroupPanel2.Controls.Add(Me.txtProdcutName)
        Me.GroupPanel2.Controls.Add(Me.Label2)
        Me.GroupPanel2.Controls.Add(Me.txtProductID)
        Me.GroupPanel2.Controls.Add(Me.Label1)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 50)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(583, 411)
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
        Me.GroupPanel2.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(3, 1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "ບັນທຶກ"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(84, 1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "ຍົກເລີກ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ລະຫັດ"
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(118, 16)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(100, 35)
        Me.txtProductID.TabIndex = 1
        '
        'txtProdcutName
        '
        Me.txtProdcutName.Location = New System.Drawing.Point(118, 57)
        Me.txtProdcutName.Name = "txtProdcutName"
        Me.txtProdcutName.Size = New System.Drawing.Size(406, 35)
        Me.txtProdcutName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ຊື່ສິນຄ້າ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ປະເພດ"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(118, 139)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 35)
        Me.txtPrice.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ລາຄາ"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(292, 139)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(64, 35)
        Me.txtQty.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ຈຳນວນ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(364, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ຫົວໜ່ວຍ"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(118, 180)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(238, 35)
        Me.txtTotal.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 29)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ລາຄາລວມ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 29)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "ໝາຍເຫດ"
        '
        'cmbCate
        '
        Me.cmbCate.FormattingEnabled = True
        Me.cmbCate.Location = New System.Drawing.Point(118, 97)
        Me.cmbCate.Name = "cmbCate"
        Me.cmbCate.Size = New System.Drawing.Size(406, 37)
        Me.cmbCate.TabIndex = 16
        '
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(440, 136)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(84, 37)
        Me.cmbUnit.TabIndex = 17
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(118, 221)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(406, 95)
        Me.txtNote.TabIndex = 18
        Me.txtNote.Text = ""
        '
        'frmNewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 473)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmNewProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Product"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtNote As RichTextBox
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents cmbCate As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProdcutName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label1 As Label
End Class
