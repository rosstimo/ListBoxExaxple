<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListBoxExampleForm
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
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayFileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DisplayFormContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFormContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBoxContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopMenuStrip.SuspendLayout()
        Me.FormContextMenuStrip.SuspendLayout()
        Me.ListBoxContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayListBox
        '
        Me.DisplayListBox.ContextMenuStrip = Me.ListBoxContextMenuStrip
        Me.DisplayListBox.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 28
        Me.DisplayListBox.Location = New System.Drawing.Point(194, 62)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(539, 312)
        Me.DisplayListBox.TabIndex = 0
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenuItem, Me.EditMenuItem, Me.HelpMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(807, 33)
        Me.TopMenuStrip.TabIndex = 1
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileMenuItem
        '
        Me.FileMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayFileMenuItem, Me.ClearFileMenuItem, Me.ExitToolStripMenuItem})
        Me.FileMenuItem.Name = "FileMenuItem"
        Me.FileMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileMenuItem.Text = "&File"
        '
        'DisplayFileMenuItem
        '
        Me.DisplayFileMenuItem.Name = "DisplayFileMenuItem"
        Me.DisplayFileMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.DisplayFileMenuItem.Text = "&Display"
        '
        'ClearFileMenuItem
        '
        Me.ClearFileMenuItem.Name = "ClearFileMenuItem"
        Me.ClearFileMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ClearFileMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditMenuItem
        '
        Me.EditMenuItem.Name = "EditMenuItem"
        Me.EditMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EditMenuItem.Text = "&Edit"
        '
        'HelpMenuItem
        '
        Me.HelpMenuItem.Name = "HelpMenuItem"
        Me.HelpMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpMenuItem.Text = "&Help"
        '
        'FormContextMenuStrip
        '
        Me.FormContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.FormContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayFormContextMenuItem, Me.ClearFormContextMenuItem})
        Me.FormContextMenuStrip.Name = "FormContextMenuStrip"
        Me.FormContextMenuStrip.Size = New System.Drawing.Size(143, 68)
        '
        'DisplayFormContextMenuItem
        '
        Me.DisplayFormContextMenuItem.Name = "DisplayFormContextMenuItem"
        Me.DisplayFormContextMenuItem.Size = New System.Drawing.Size(142, 32)
        Me.DisplayFormContextMenuItem.Text = "&Display"
        '
        'ClearFormContextMenuItem
        '
        Me.ClearFormContextMenuItem.Name = "ClearFormContextMenuItem"
        Me.ClearFormContextMenuItem.Size = New System.Drawing.Size(142, 32)
        Me.ClearFormContextMenuItem.Text = "&Clear"
        '
        'ListBoxContextMenuStrip
        '
        Me.ListBoxContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ListBoxContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveToolStripMenuItem})
        Me.ListBoxContextMenuStrip.Name = "ListBoxContextMenuStrip"
        Me.ListBoxContextMenuStrip.Size = New System.Drawing.Size(241, 69)
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(240, 32)
        Me.RemoveToolStripMenuItem.Text = "&Remove"
        '
        'ListBoxExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 461)
        Me.ContextMenuStrip = Me.FormContextMenuStrip
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "ListBoxExampleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Box Example"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.FormContextMenuStrip.ResumeLayout(False)
        Me.ListBoxContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayFileMenuItem As ToolStripMenuItem
    Friend WithEvents EditMenuItem As ToolStripMenuItem
    Friend WithEvents HelpMenuItem As ToolStripMenuItem
    Friend WithEvents ClearFileMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormContextMenuStrip As ContextMenuStrip
    Friend WithEvents DisplayFormContextMenuItem As ToolStripMenuItem
    Friend WithEvents ClearFormContextMenuItem As ToolStripMenuItem
    Friend WithEvents ListBoxContextMenuStrip As ContextMenuStrip
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
End Class
