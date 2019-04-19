<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.游戏路径设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.版本说明ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于PokemonStarterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerationTab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.PictureBox22 = New System.Windows.Forms.PictureBox()
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureBox35 = New System.Windows.Forms.PictureBox()
        Me.PictureBox33 = New System.Windows.Forms.PictureBox()
        Me.PictureBox32 = New System.Windows.Forms.PictureBox()
        Me.PictureBox31 = New System.Windows.Forms.PictureBox()
        Me.PictureBox34 = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox41 = New System.Windows.Forms.PictureBox()
        Me.PictureBox42 = New System.Windows.Forms.PictureBox()
        Me.PictureBox43 = New System.Windows.Forms.PictureBox()
        Me.PictureBox44 = New System.Windows.Forms.PictureBox()
        Me.PictureBox45 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GenerationTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox34, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.PictureBox41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox45, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件ToolStripMenuItem, Me.设置ToolStripMenuItem, Me.关于ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(894, 28)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件ToolStripMenuItem
        '
        Me.文件ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.退出ToolStripMenuItem})
        Me.文件ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem"
        Me.文件ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.文件ToolStripMenuItem.Text = "文件"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(111, 6)
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '设置ToolStripMenuItem
        '
        Me.设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.游戏路径设置ToolStripMenuItem})
        Me.设置ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem"
        Me.设置ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.设置ToolStripMenuItem.Text = "设置"
        '
        '游戏路径设置ToolStripMenuItem
        '
        Me.游戏路径设置ToolStripMenuItem.Name = "游戏路径设置ToolStripMenuItem"
        Me.游戏路径设置ToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.游戏路径设置ToolStripMenuItem.Text = "游戏路径设置"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.版本说明ToolStripMenuItem, Me.关于PokemonStarterToolStripMenuItem})
        Me.关于ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.关于ToolStripMenuItem.Text = "帮助"
        '
        '版本说明ToolStripMenuItem
        '
        Me.版本说明ToolStripMenuItem.Name = "版本说明ToolStripMenuItem"
        Me.版本说明ToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.版本说明ToolStripMenuItem.Text = "版本说明"
        '
        '关于PokemonStarterToolStripMenuItem
        '
        Me.关于PokemonStarterToolStripMenuItem.Name = "关于PokemonStarterToolStripMenuItem"
        Me.关于PokemonStarterToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.关于PokemonStarterToolStripMenuItem.Text = "关于Pokemon Launcher"
        '
        'GenerationTab
        '
        Me.GenerationTab.Controls.Add(Me.TabPage1)
        Me.GenerationTab.Controls.Add(Me.TabPage2)
        Me.GenerationTab.Controls.Add(Me.TabPage3)
        Me.GenerationTab.Controls.Add(Me.TabPage4)
        Me.GenerationTab.Controls.Add(Me.TabPage5)
        Me.GenerationTab.Controls.Add(Me.TabPage6)
        Me.GenerationTab.Controls.Add(Me.TabPage7)
        Me.GenerationTab.Controls.Add(Me.TabPage8)
        Me.GenerationTab.Cursor = System.Windows.Forms.Cursors.Default
        Me.GenerationTab.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GenerationTab.HotTrack = True
        Me.GenerationTab.ItemSize = New System.Drawing.Size(75, 25)
        Me.GenerationTab.Location = New System.Drawing.Point(0, 31)
        Me.GenerationTab.Multiline = True
        Me.GenerationTab.Name = "GenerationTab"
        Me.GenerationTab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GenerationTab.SelectedIndex = 0
        Me.GenerationTab.Size = New System.Drawing.Size(894, 551)
        Me.GenerationTab.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.PictureBox12)
        Me.TabPage1.Controls.Add(Me.PictureBox13)
        Me.TabPage1.Controls.Add(Me.PictureBox14)
        Me.TabPage1.Controls.Add(Me.PictureBox11)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(886, 518)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "第一世代"
        '
        'PictureBox12
        '
        Me.PictureBox12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(285, 34)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(209, 230)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 3
        Me.PictureBox12.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox12, "绿")
        '
        'PictureBox13
        '
        Me.PictureBox13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(167, 270)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(198, 230)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 2
        Me.PictureBox13.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox13, "蓝")
        '
        'PictureBox14
        '
        Me.PictureBox14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), System.Drawing.Image)
        Me.PictureBox14.Location = New System.Drawing.Point(500, 57)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(354, 386)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox14.TabIndex = 1
        Me.PictureBox14.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox14, "皮卡丘")
        '
        'PictureBox11
        '
        Me.PictureBox11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(50, 34)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(198, 230)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 0
        Me.PictureBox11.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox11, "红")
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.PictureBox23)
        Me.TabPage2.Controls.Add(Me.PictureBox22)
        Me.TabPage2.Controls.Add(Me.PictureBox21)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(886, 518)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "第二世代"
        '
        'PictureBox23
        '
        Me.PictureBox23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox23.Image = CType(resources.GetObject("PictureBox23.Image"), System.Drawing.Image)
        Me.PictureBox23.Location = New System.Drawing.Point(433, 54)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(329, 401)
        Me.PictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox23.TabIndex = 2
        Me.PictureBox23.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox23, "水晶")
        '
        'PictureBox22
        '
        Me.PictureBox22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox22.Image = CType(resources.GetObject("PictureBox22.Image"), System.Drawing.Image)
        Me.PictureBox22.Location = New System.Drawing.Point(105, 264)
        Me.PictureBox22.Name = "PictureBox22"
        Me.PictureBox22.Size = New System.Drawing.Size(289, 232)
        Me.PictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox22.TabIndex = 1
        Me.PictureBox22.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox22, "银")
        '
        'PictureBox21
        '
        Me.PictureBox21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox21.Image = CType(resources.GetObject("PictureBox21.Image"), System.Drawing.Image)
        Me.PictureBox21.Location = New System.Drawing.Point(105, 26)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(289, 232)
        Me.PictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox21.TabIndex = 0
        Me.PictureBox21.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox21, "金")
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.PictureBox35)
        Me.TabPage3.Controls.Add(Me.PictureBox33)
        Me.TabPage3.Controls.Add(Me.PictureBox32)
        Me.TabPage3.Controls.Add(Me.PictureBox31)
        Me.TabPage3.Controls.Add(Me.PictureBox34)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(886, 518)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "第三世代"
        '
        'PictureBox35
        '
        Me.PictureBox35.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox35.Image = CType(resources.GetObject("PictureBox35.Image"), System.Drawing.Image)
        Me.PictureBox35.Location = New System.Drawing.Point(398, 197)
        Me.PictureBox35.Name = "PictureBox35"
        Me.PictureBox35.Size = New System.Drawing.Size(465, 307)
        Me.PictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox35.TabIndex = 9
        Me.PictureBox35.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox35, "绿宝石")
        '
        'PictureBox33
        '
        Me.PictureBox33.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox33.Image = CType(resources.GetObject("PictureBox33.Image"), System.Drawing.Image)
        Me.PictureBox33.Location = New System.Drawing.Point(363, 22)
        Me.PictureBox33.Name = "PictureBox33"
        Me.PictureBox33.Size = New System.Drawing.Size(244, 165)
        Me.PictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox33.TabIndex = 8
        Me.PictureBox33.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox33, "火红")
        '
        'PictureBox32
        '
        Me.PictureBox32.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox32.Image = CType(resources.GetObject("PictureBox32.Image"), System.Drawing.Image)
        Me.PictureBox32.Location = New System.Drawing.Point(27, 278)
        Me.PictureBox32.Name = "PictureBox32"
        Me.PictureBox32.Size = New System.Drawing.Size(323, 218)
        Me.PictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox32.TabIndex = 7
        Me.PictureBox32.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox32, "蓝宝石")
        '
        'PictureBox31
        '
        Me.PictureBox31.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox31.Image = CType(resources.GetObject("PictureBox31.Image"), System.Drawing.Image)
        Me.PictureBox31.Location = New System.Drawing.Point(27, 28)
        Me.PictureBox31.Name = "PictureBox31"
        Me.PictureBox31.Size = New System.Drawing.Size(323, 215)
        Me.PictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox31.TabIndex = 6
        Me.PictureBox31.TabStop = False
        Me.PictureBox31.Tag = ""
        Me.ToolTip1.SetToolTip(Me.PictureBox31, "红宝石")
        '
        'PictureBox34
        '
        Me.PictureBox34.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox34.Image = CType(resources.GetObject("PictureBox34.Image"), System.Drawing.Image)
        Me.PictureBox34.Location = New System.Drawing.Point(619, 22)
        Me.PictureBox34.Name = "PictureBox34"
        Me.PictureBox34.Size = New System.Drawing.Size(244, 165)
        Me.PictureBox34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox34.TabIndex = 5
        Me.PictureBox34.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox34, "叶绿")
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.PictureBox45)
        Me.TabPage4.Controls.Add(Me.PictureBox44)
        Me.TabPage4.Controls.Add(Me.PictureBox43)
        Me.TabPage4.Controls.Add(Me.PictureBox42)
        Me.TabPage4.Controls.Add(Me.PictureBox41)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(886, 518)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "第四世代"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(886, 518)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "第五世代"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage6.Controls.Add(Me.Label1)
        Me.TabPage6.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage6.Location = New System.Drawing.Point(4, 29)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(886, 518)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "第六世代"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(354, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "3DS仍在发售"
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage7.Controls.Add(Me.Label2)
        Me.TabPage7.Location = New System.Drawing.Point(4, 29)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(886, 518)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "第七世代"
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage8.Controls.Add(Me.Label3)
        Me.TabPage8.Location = New System.Drawing.Point(4, 29)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(886, 518)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "第八世代"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(391, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "即将发售"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "精灵宝可梦"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 15.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(354, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "3DS仍在发售"
        '
        'PictureBox41
        '
        Me.PictureBox41.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox41.Image = CType(resources.GetObject("PictureBox41.Image"), System.Drawing.Image)
        Me.PictureBox41.Location = New System.Drawing.Point(35, 26)
        Me.PictureBox41.Name = "PictureBox41"
        Me.PictureBox41.Size = New System.Drawing.Size(234, 195)
        Me.PictureBox41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox41.TabIndex = 0
        Me.PictureBox41.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox41, "钻石")
        '
        'PictureBox42
        '
        Me.PictureBox42.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox42.Image = CType(resources.GetObject("PictureBox42.Image"), System.Drawing.Image)
        Me.PictureBox42.Location = New System.Drawing.Point(287, 55)
        Me.PictureBox42.Name = "PictureBox42"
        Me.PictureBox42.Size = New System.Drawing.Size(234, 195)
        Me.PictureBox42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox42.TabIndex = 1
        Me.PictureBox42.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox42, "珍珠")
        '
        'PictureBox43
        '
        Me.PictureBox43.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox43.Image = CType(resources.GetObject("PictureBox43.Image"), System.Drawing.Image)
        Me.PictureBox43.Location = New System.Drawing.Point(83, 265)
        Me.PictureBox43.Name = "PictureBox43"
        Me.PictureBox43.Size = New System.Drawing.Size(286, 234)
        Me.PictureBox43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox43.TabIndex = 2
        Me.PictureBox43.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox43, "白金")
        '
        'PictureBox44
        '
        Me.PictureBox44.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox44.Image = CType(resources.GetObject("PictureBox44.Image"), System.Drawing.Image)
        Me.PictureBox44.Location = New System.Drawing.Point(577, 12)
        Me.PictureBox44.Name = "PictureBox44"
        Me.PictureBox44.Size = New System.Drawing.Size(292, 247)
        Me.PictureBox44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox44.TabIndex = 3
        Me.PictureBox44.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox44, "心金")
        '
        'PictureBox45
        '
        Me.PictureBox45.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox45.Image = CType(resources.GetObject("PictureBox45.Image"), System.Drawing.Image)
        Me.PictureBox45.Location = New System.Drawing.Point(488, 265)
        Me.PictureBox45.Name = "PictureBox45"
        Me.PictureBox45.Size = New System.Drawing.Size(289, 247)
        Me.PictureBox45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox45.TabIndex = 4
        Me.PictureBox45.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox45, "魂银")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(894, 580)
        Me.Controls.Add(Me.GenerationTab)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pokemon Launcher"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GenerationTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox34, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.PictureBox41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox45, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GenerationTab As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents 关于PokemonStarterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PictureBox34 As PictureBox
    Friend WithEvents 设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 游戏路径设置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox35 As PictureBox
    Friend WithEvents PictureBox33 As PictureBox
    Friend WithEvents PictureBox32 As PictureBox
    Friend WithEvents PictureBox31 As PictureBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents 版本说明ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents PictureBox22 As PictureBox
    Friend WithEvents PictureBox21 As PictureBox
    Friend WithEvents PictureBox45 As PictureBox
    Friend WithEvents PictureBox44 As PictureBox
    Friend WithEvents PictureBox43 As PictureBox
    Friend WithEvents PictureBox42 As PictureBox
    Friend WithEvents PictureBox41 As PictureBox
    Friend WithEvents Label2 As Label
End Class
