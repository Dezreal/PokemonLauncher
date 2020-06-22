<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingForm
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Emulator", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ROM", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("VisualBoyAdvance", 0)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("DeSmuME", 1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Citra", 33)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("红", 2)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"绿", ""}, 3)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"蓝", ""}, 4)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"皮卡丘", ""}, 5)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"金", ""}, 6)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"银", ""}, 7)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("水晶", 8)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("红宝石", 9)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("蓝宝石", 10)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("火红", 11)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("叶绿", 12)
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("绿宝石", 13)
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("钻石", 14)
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("珍珠", 15)
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("白金", 16)
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("心金", 17)
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("魂银", 18)
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("黑", 19)
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("白", 20)
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("黑2", 21)
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("白2", 22)
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("X", 23)
        Dim ListViewItem26 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Y", 24)
        Dim ListViewItem27 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("欧米伽红宝石", 25)
        Dim ListViewItem28 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("阿尔法蓝宝石", 26)
        Dim ListViewItem29 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("太阳", 27)
        Dim ListViewItem30 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("月亮", 28)
        Dim ListViewItem31 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("究极之日", 29)
        Dim ListViewItem32 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("究极之月", 30)
        Dim ListViewItem33 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("剑", 31)
        Dim ListViewItem34 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("盾", 32)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingForm))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListView1.GridLines = True
        ListViewGroup1.Header = "Emulator"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "ROM"
        ListViewGroup2.Name = "ListViewGroup2"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        ListViewItem1.Group = ListViewGroup1
        ListViewItem2.Group = ListViewGroup1
        ListViewItem3.Group = ListViewGroup1
        ListViewItem4.Group = ListViewGroup2
        ListViewItem4.StateImageIndex = 0
        ListViewItem5.Group = ListViewGroup2
        ListViewItem5.StateImageIndex = 0
        ListViewItem6.Group = ListViewGroup2
        ListViewItem6.StateImageIndex = 0
        ListViewItem7.Group = ListViewGroup2
        ListViewItem7.StateImageIndex = 0
        ListViewItem8.Group = ListViewGroup2
        ListViewItem8.StateImageIndex = 0
        ListViewItem9.Group = ListViewGroup2
        ListViewItem9.StateImageIndex = 0
        ListViewItem10.Group = ListViewGroup2
        ListViewItem10.StateImageIndex = 0
        ListViewItem11.Group = ListViewGroup2
        ListViewItem11.StateImageIndex = 0
        ListViewItem12.Group = ListViewGroup2
        ListViewItem12.StateImageIndex = 0
        ListViewItem13.Group = ListViewGroup2
        ListViewItem13.StateImageIndex = 0
        ListViewItem14.Group = ListViewGroup2
        ListViewItem14.StateImageIndex = 0
        ListViewItem15.Group = ListViewGroup2
        ListViewItem15.StateImageIndex = 0
        ListViewItem16.Group = ListViewGroup2
        ListViewItem16.StateImageIndex = 0
        ListViewItem17.Group = ListViewGroup2
        ListViewItem17.StateImageIndex = 0
        ListViewItem18.Group = ListViewGroup2
        ListViewItem18.StateImageIndex = 0
        ListViewItem19.Group = ListViewGroup2
        ListViewItem19.StateImageIndex = 0
        ListViewItem20.Group = ListViewGroup2
        ListViewItem21.Group = ListViewGroup2
        ListViewItem22.Group = ListViewGroup2
        ListViewItem23.Group = ListViewGroup2
        ListViewItem24.Group = ListViewGroup2
        ListViewItem25.Group = ListViewGroup2
        ListViewItem26.Group = ListViewGroup2
        ListViewItem27.Group = ListViewGroup2
        ListViewItem28.Group = ListViewGroup2
        ListViewItem29.Group = ListViewGroup2
        ListViewItem30.Group = ListViewGroup2
        ListViewItem31.Group = ListViewGroup2
        ListViewItem32.Group = ListViewGroup2
        ListViewItem33.Group = ListViewGroup2
        ListViewItem34.Group = ListViewGroup2
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21, ListViewItem22, ListViewItem23, ListViewItem24, ListViewItem25, ListViewItem26, ListViewItem27, ListViewItem28, ListViewItem29, ListViewItem30, ListViewItem31, ListViewItem32, ListViewItem33, ListViewItem34})
        Me.ListView1.LargeImageList = Me.ImageList2
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(713, 479)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 241
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Path"
        Me.ColumnHeader2.Width = 800
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "VisualBoyAdvance_00001.png")
        Me.ImageList2.Images.SetKeyName(1, "DeSmuME_v.0.9.7_x64_release_wifi_00001.png")
        Me.ImageList2.Images.SetKeyName(2, "pic_quark_1554910187825.jpg")
        Me.ImageList2.Images.SetKeyName(3, "pic_quark_1554910205273.jpg")
        Me.ImageList2.Images.SetKeyName(4, "pic_quark_1554910218664.jpg")
        Me.ImageList2.Images.SetKeyName(5, "pic_quark_1554910237007.jpg")
        Me.ImageList2.Images.SetKeyName(6, "pic_quark_1554910345505.jpg")
        Me.ImageList2.Images.SetKeyName(7, "pic_quark_1554910357125.jpg")
        Me.ImageList2.Images.SetKeyName(8, "pic_quark_1554910384492.jpg")
        Me.ImageList2.Images.SetKeyName(9, "精灵宝可梦_红宝石_日版封面.png")
        Me.ImageList2.Images.SetKeyName(10, "精灵宝可梦_蓝宝石_日版封面.png")
        Me.ImageList2.Images.SetKeyName(11, "精灵宝可梦_火红_日版封面.png")
        Me.ImageList2.Images.SetKeyName(12, "精灵宝可梦_叶绿_日版封面.png")
        Me.ImageList2.Images.SetKeyName(13, "精灵宝可梦_绿宝石_日版封面.png")
        Me.ImageList2.Images.SetKeyName(14, "精灵宝可梦_钻石_日版封面.jpg")
        Me.ImageList2.Images.SetKeyName(15, "精灵宝可梦_珍珠_日版封面.jpg")
        Me.ImageList2.Images.SetKeyName(16, "精灵宝可梦_白金_日版封面.png")
        Me.ImageList2.Images.SetKeyName(17, "精灵宝可梦_心金_日版封面.jpg")
        Me.ImageList2.Images.SetKeyName(18, "精灵宝可梦_魂银_日版封面.jpg")
        Me.ImageList2.Images.SetKeyName(19, "Pokemon_Black_Boxart_JP.png")
        Me.ImageList2.Images.SetKeyName(20, "Pokemon_White_Boxart_JP.png")
        Me.ImageList2.Images.SetKeyName(21, "Pokemon_Black_2_Boxart_JP.png")
        Me.ImageList2.Images.SetKeyName(22, "Pokemon_White_2_Boxart_JP.png")
        Me.ImageList2.Images.SetKeyName(23, "Pokemon_X_Boxart_JP.png")
        Me.ImageList2.Images.SetKeyName(24, "Pokemon_Y_Boxart_JP.png")
        Me.ImageList2.Images.SetKeyName(25, "Omegaruby_Boxart_JP.png")
        Me.ImageList2.Images.SetKeyName(26, "Alphasapphire_Boxart_JP.png")
        Me.ImageList2.Images.SetKeyName(27, "精靈寶可夢太陽_封面_繁體中文.png")
        Me.ImageList2.Images.SetKeyName(28, "精靈寶可夢月亮_封面_繁體中文.png")
        Me.ImageList2.Images.SetKeyName(29, "精靈寶可夢究極之日_封面_繁體中文.png")
        Me.ImageList2.Images.SetKeyName(30, "精靈寶可夢究極之月_封面_繁體中文.png")
        Me.ImageList2.Images.SetKeyName(31, "寶可夢_劍_封面_繁體中文.png")
        Me.ImageList2.Images.SetKeyName(32, "寶可夢_盾_封面_繁體中文.png")
        Me.ImageList2.Images.SetKeyName(33, "citra.png")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "VisualBoyAdvance_00001.png")
        Me.ImageList1.Images.SetKeyName(1, "DeSmuME_v.0.9.7_x64_release_wifi_00001.png")
        Me.ImageList1.Images.SetKeyName(2, "pic_quark_1554910187825.jpg")
        Me.ImageList1.Images.SetKeyName(3, "pic_quark_1554910205273.jpg")
        Me.ImageList1.Images.SetKeyName(4, "pic_quark_1554910218664.jpg")
        Me.ImageList1.Images.SetKeyName(5, "pic_quark_1554910237007.jpg")
        Me.ImageList1.Images.SetKeyName(6, "pic_quark_1554910345505.jpg")
        Me.ImageList1.Images.SetKeyName(7, "pic_quark_1554910357125.jpg")
        Me.ImageList1.Images.SetKeyName(8, "pic_quark_1554910384492.jpg")
        Me.ImageList1.Images.SetKeyName(9, "精灵宝可梦_红宝石_日版封面.png")
        Me.ImageList1.Images.SetKeyName(10, "精灵宝可梦_蓝宝石_日版封面.png")
        Me.ImageList1.Images.SetKeyName(11, "精灵宝可梦_火红_日版封面.png")
        Me.ImageList1.Images.SetKeyName(12, "精灵宝可梦_叶绿_日版封面.png")
        Me.ImageList1.Images.SetKeyName(13, "精灵宝可梦_绿宝石_日版封面.png")
        Me.ImageList1.Images.SetKeyName(14, "精灵宝可梦_钻石_日版封面.jpg")
        Me.ImageList1.Images.SetKeyName(15, "精灵宝可梦_珍珠_日版封面.jpg")
        Me.ImageList1.Images.SetKeyName(16, "精灵宝可梦_白金_日版封面.png")
        Me.ImageList1.Images.SetKeyName(17, "精灵宝可梦_心金_日版封面.jpg")
        Me.ImageList1.Images.SetKeyName(18, "精灵宝可梦_魂银_日版封面.jpg")
        Me.ImageList1.Images.SetKeyName(19, "Pokemon_Black_Boxart_JP.png")
        Me.ImageList1.Images.SetKeyName(20, "Pokemon_White_Boxart_JP.png")
        Me.ImageList1.Images.SetKeyName(21, "Pokemon_Black_2_Boxart_JP.png")
        Me.ImageList1.Images.SetKeyName(22, "Pokemon_White_2_Boxart_JP.png")
        Me.ImageList1.Images.SetKeyName(23, "Pokemon_X_Boxart_JP.png")
        Me.ImageList1.Images.SetKeyName(24, "Pokemon_Y_Boxart_JP.png")
        Me.ImageList1.Images.SetKeyName(25, "Omegaruby_Boxart_JP.png")
        Me.ImageList1.Images.SetKeyName(26, "Alphasapphire_Boxart_JP.png")
        Me.ImageList1.Images.SetKeyName(27, "精靈寶可夢太陽_封面_繁體中文.png")
        Me.ImageList1.Images.SetKeyName(28, "精靈寶可夢月亮_封面_繁體中文.png")
        Me.ImageList1.Images.SetKeyName(29, "精靈寶可夢究極之日_封面_繁體中文.png")
        Me.ImageList1.Images.SetKeyName(30, "精靈寶可夢究極之月_封面_繁體中文.png")
        Me.ImageList1.Images.SetKeyName(31, "寶可夢_劍_封面_繁體中文.png")
        Me.ImageList1.Images.SetKeyName(32, "寶可夢_盾_封面_繁體中文.png")
        Me.ImageList1.Images.SetKeyName(33, "citra.png")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(731, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 76)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "切换视图"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 523)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(860, 570)
        Me.Name = "SettingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "路径选择"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
End Class
