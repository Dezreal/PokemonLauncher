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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.游戏路径设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于PokemonStarterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerationTab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureBox35 = New System.Windows.Forms.PictureBox()
        Me.PictureBox33 = New System.Windows.Forms.PictureBox()
        Me.PictureBox32 = New System.Windows.Forms.PictureBox()
        Me.PictureBox31 = New System.Windows.Forms.PictureBox()
        Me.PictureBox34 = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GenerationTab.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox34, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
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
        Me.关于ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关于PokemonStarterToolStripMenuItem})
        Me.关于ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.关于ToolStripMenuItem.Text = "帮助"
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(886, 518)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "第一世代"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(886, 518)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "第二世代"
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
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(391, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "仍在发售"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(391, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "仍在发售"
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
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureBox35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox34, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
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
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents Label3 As Label
End Class
