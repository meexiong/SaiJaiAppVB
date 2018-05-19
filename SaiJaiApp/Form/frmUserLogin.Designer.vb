<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserLogin
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
        Me.btnNew = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUSerID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEmp = New System.Windows.Forms.ComboBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmgStatus = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnCancel)
        Me.GroupPanel1.Controls.Add(Me.btnDelete)
        Me.GroupPanel1.Controls.Add(Me.btnSave)
        Me.GroupPanel1.Controls.Add(Me.btnNew)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(530, 32)
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
        Me.GroupPanel2.Controls.Add(Me.Panel1)
        Me.GroupPanel2.Controls.Add(Me.txtSearch)
        Me.GroupPanel2.Controls.Add(Me.Label7)
        Me.GroupPanel2.Controls.Add(Me.cmgStatus)
        Me.GroupPanel2.Controls.Add(Me.Label5)
        Me.GroupPanel2.Controls.Add(Me.txtPass)
        Me.GroupPanel2.Controls.Add(Me.Label4)
        Me.GroupPanel2.Controls.Add(Me.cmbEmp)
        Me.GroupPanel2.Controls.Add(Me.txtUserName)
        Me.GroupPanel2.Controls.Add(Me.Label3)
        Me.GroupPanel2.Controls.Add(Me.Label2)
        Me.GroupPanel2.Controls.Add(Me.txtUSerID)
        Me.GroupPanel2.Controls.Add(Me.Label1)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 50)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(530, 384)
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
        'btnNew
        '
        Me.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNew.Location = New System.Drawing.Point(2, 1)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "ສ້າງໃໝ່"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(81, 1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "ບັນທຶກ"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDelete.Location = New System.Drawing.Point(161, 1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "ລົບອອກ"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(240, 1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "ຍົກເລີກ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ລະຫັດ"
        '
        'txtUSerID
        '
        Me.txtUSerID.Location = New System.Drawing.Point(136, 107)
        Me.txtUSerID.Name = "txtUSerID"
        Me.txtUSerID.ReadOnly = True
        Me.txtUSerID.Size = New System.Drawing.Size(100, 35)
        Me.txtUSerID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ພະນັກງານ"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(136, 186)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(359, 35)
        Me.txtUserName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ຊື່ເຂົ້າໃຊ້ລະບົບ"
        '
        'cmbEmp
        '
        Me.cmbEmp.FormattingEnabled = True
        Me.cmbEmp.Location = New System.Drawing.Point(136, 146)
        Me.cmbEmp.Name = "cmbEmp"
        Me.cmbEmp.Size = New System.Drawing.Size(359, 37)
        Me.cmbEmp.TabIndex = 6
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(136, 225)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(359, 35)
        Me.txtPass.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ລະຫັດຜ່ານ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ສະຖານະ"
        '
        'cmgStatus
        '
        Me.cmgStatus.FormattingEnabled = True
        Me.cmgStatus.Location = New System.Drawing.Point(136, 264)
        Me.cmgStatus.Name = "cmgStatus"
        Me.cmgStatus.Size = New System.Drawing.Size(216, 37)
        Me.cmgStatus.TabIndex = 10
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(136, 15)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(359, 35)
        Me.txtSearch.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 29)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ຄົ້ນຫາ"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Location = New System.Drawing.Point(5, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 17)
        Me.Panel1.TabIndex = 14
        '
        'frmUserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 446)
        Me.Controls.Add(Me.GroupPanel2)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frmUserLogin"
        Me.Text = "User Login"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNew As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmgStatus As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbEmp As ComboBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUSerID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
