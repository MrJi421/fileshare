<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralSetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecuritySettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Iptext = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Sharebtn = New System.Windows.Forms.Button()
        Me.Newbtn = New System.Windows.Forms.Button()
        Me.lab = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BrowsePath = New System.Windows.Forms.TextBox()
        Me.Browsebtn = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ListGBox = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ListGBox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.UserToolStripMenuItem.Text = "&User"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "&Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Log&out"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(109, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralSetToolStripMenuItem, Me.SecuritySettingsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'GeneralSetToolStripMenuItem
        '
        Me.GeneralSetToolStripMenuItem.Name = "GeneralSetToolStripMenuItem"
        Me.GeneralSetToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.GeneralSetToolStripMenuItem.Text = "&General Settings"
        '
        'SecuritySettingsToolStripMenuItem
        '
        Me.SecuritySettingsToolStripMenuItem.Name = "SecuritySettingsToolStripMenuItem"
        Me.SecuritySettingsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SecuritySettingsToolStripMenuItem.Text = "&Security Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripMenuItem1.Text = "&Contact us"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Iptext)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Sharebtn)
        Me.GroupBox1.Controls.Add(Me.Newbtn)
        Me.GroupBox1.Controls.Add(Me.lab)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BrowsePath)
        Me.GroupBox1.Controls.Add(Me.Browsebtn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 225)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a File to Share"
        '
        'Iptext
        '
        Me.Iptext.Location = New System.Drawing.Point(11, 168)
        Me.Iptext.Name = "Iptext"
        Me.Iptext.Size = New System.Drawing.Size(228, 20)
        Me.Iptext.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(381, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Select the DID from the list, if not there, add the device by clicking on NEW btn" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Sharebtn
        '
        Me.Sharebtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Sharebtn.Location = New System.Drawing.Point(318, 165)
        Me.Sharebtn.Name = "Sharebtn"
        Me.Sharebtn.Size = New System.Drawing.Size(67, 23)
        Me.Sharebtn.TabIndex = 4
        Me.Sharebtn.Text = "Share"
        '
        'Newbtn
        '
        Me.Newbtn.Location = New System.Drawing.Point(245, 166)
        Me.Newbtn.Name = "Newbtn"
        Me.Newbtn.Size = New System.Drawing.Size(67, 23)
        Me.Newbtn.TabIndex = 7
        Me.Newbtn.Text = "New"
        Me.Newbtn.UseVisualStyleBackColor = True
        '
        'lab
        '
        Me.lab.FormattingEnabled = True
        Me.lab.Location = New System.Drawing.Point(9, 139)
        Me.lab.Name = "lab"
        Me.lab.Size = New System.Drawing.Size(376, 21)
        Me.lab.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select the file:"
        '
        'BrowsePath
        '
        Me.BrowsePath.Location = New System.Drawing.Point(6, 51)
        Me.BrowsePath.Name = "BrowsePath"
        Me.BrowsePath.Size = New System.Drawing.Size(379, 20)
        Me.BrowsePath.TabIndex = 1
        '
        'Browsebtn
        '
        Me.Browsebtn.Location = New System.Drawing.Point(310, 77)
        Me.Browsebtn.Name = "Browsebtn"
        Me.Browsebtn.Size = New System.Drawing.Size(75, 23)
        Me.Browsebtn.TabIndex = 0
        Me.Browsebtn.Text = "Browse"
        Me.Browsebtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'ListGBox
        '
        Me.ListGBox.Controls.Add(Me.DataGridView1)
        Me.ListGBox.Location = New System.Drawing.Point(458, 45)
        Me.ListGBox.Name = "ListGBox"
        Me.ListGBox.Size = New System.Drawing.Size(330, 393)
        Me.ListGBox.TabIndex = 4
        Me.ListGBox.TabStop = False
        Me.ListGBox.Text = "List of Shared Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(324, 374)
        Me.DataGridView1.TabIndex = 0
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListGBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Home"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ListGBox.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GeneralSetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SecuritySettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents BrowsePath As TextBox
    Friend WithEvents Browsebtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListGBox As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Sharebtn As Button
    Friend WithEvents Newbtn As Button
    Friend WithEvents lab As ComboBox
    Friend WithEvents Iptext As TextBox
End Class
