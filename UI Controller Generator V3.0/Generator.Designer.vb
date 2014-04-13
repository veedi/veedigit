<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Generator
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Generator))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.AddRowButton = New DevExpress.XtraBars.BarButtonItem()
        Me.RemoveRowButton = New DevExpress.XtraBars.BarButtonItem()
        Me.GenerateButton = New DevExpress.XtraBars.BarButtonItem()
        Me.ShowSaveDialogField = New DevExpress.XtraBars.BarCheckItem()
        Me.ExitBarButton = New DevExpress.XtraBars.BarButtonItem()
        Me.SaveFileLocation = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ExitBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.EditTemplateButton = New DevExpress.XtraBars.BarButtonItem()
        Me.VSCheckEdit = New DevExpress.XtraBars.BarCheckItem()
        Me.TextCheckEdit = New DevExpress.XtraBars.BarCheckItem()
        Me.ProgressStaticText = New DevExpress.XtraBars.BarStaticItem()
        Me.ProgressBarEdit = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemMarqueeProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar()
        Me.HelpBarButton = New DevExpress.XtraBars.BarButtonItem()
        Me.GeneratorPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ActionsPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.SettingsPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ConfigurationPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.AdminPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.TemplateRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.EditModePageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RepositoryItemRadioGroup2 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.TransactionsGrid = New DevExpress.XtraGrid.GridControl()
        Me.TransactionsGridview = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TransactionNameColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EnableWorkflowColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WorkflowEnabledCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsGridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkflowEnabledCheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.AddRowButton, Me.RemoveRowButton, Me.GenerateButton, Me.ShowSaveDialogField, Me.ExitBarButton, Me.SaveFileLocation, Me.ExitBarButtonItem, Me.EditTemplateButton, Me.VSCheckEdit, Me.TextCheckEdit, Me.ProgressStaticText, Me.ProgressBarEdit, Me.HelpBarButton})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 27
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.OptionsCustomizationForm.FormIcon = CType(resources.GetObject("resource.FormIcon"), System.Drawing.Icon)
        Me.RibbonControl.PageHeaderItemLinks.Add(Me.HelpBarButton)
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.GeneratorPage, Me.SettingsPage, Me.AdminPage})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit2, Me.RepositoryItemTextEdit1, Me.RepositoryItemRadioGroup1, Me.RepositoryItemRadioGroup2, Me.RepositoryItemMarqueeProgressBar1})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice
        Me.RibbonControl.Size = New System.Drawing.Size(442, 131)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'AddRowButton
        '
        Me.AddRowButton.Caption = "Add Row"
        Me.AddRowButton.Glyph = Global.UIControllerGenerator.My.Resources.Resources.Actions_list_add_icon
        Me.AddRowButton.Hint = "Add Row"
        Me.AddRowButton.Id = 1
        Me.AddRowButton.LargeGlyph = Global.UIControllerGenerator.My.Resources.Resources.Actions_list_add_icon
        Me.AddRowButton.Name = "AddRowButton"
        Me.AddRowButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RemoveRowButton
        '
        Me.RemoveRowButton.Caption = "Remove Row"
        Me.RemoveRowButton.Glyph = Global.UIControllerGenerator.My.Resources.Resources.Button_Delete_icon
        Me.RemoveRowButton.Hint = "Remove Selected Row"
        Me.RemoveRowButton.Id = 2
        Me.RemoveRowButton.LargeGlyph = Global.UIControllerGenerator.My.Resources.Resources.Button_Delete_icon
        Me.RemoveRowButton.Name = "RemoveRowButton"
        Me.RemoveRowButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'GenerateButton
        '
        Me.GenerateButton.Caption = "Generator"
        Me.GenerateButton.Glyph = Global.UIControllerGenerator.My.Resources.Resources.Generate_icon
        Me.GenerateButton.Hint = "Generator"
        Me.GenerateButton.Id = 3
        Me.GenerateButton.LargeGlyph = Global.UIControllerGenerator.My.Resources.Resources.Generate_icon
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'ShowSaveDialogField
        '
        Me.ShowSaveDialogField.Caption = "SaveAs Dialog"
        Me.ShowSaveDialogField.Checked = True
        Me.ShowSaveDialogField.Glyph = Global.UIControllerGenerator.My.Resources.Resources.save_as_icon
        Me.ShowSaveDialogField.Hint = "Enable SaveAs"
        Me.ShowSaveDialogField.Id = 4
        Me.ShowSaveDialogField.LargeGlyph = Global.UIControllerGenerator.My.Resources.Resources.save_as_icon
        Me.ShowSaveDialogField.Name = "ShowSaveDialogField"
        Me.ShowSaveDialogField.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'ExitBarButton
        '
        Me.ExitBarButton.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.ExitBarButton.Caption = "Exit"
        Me.ExitBarButton.Glyph = Global.UIControllerGenerator.My.Resources.Resources.Actions_session_exit_icon
        Me.ExitBarButton.Hint = "Exit"
        Me.ExitBarButton.Id = 7
        Me.ExitBarButton.LargeGlyph = Global.UIControllerGenerator.My.Resources.Resources.Actions_session_exit_icon
        Me.ExitBarButton.Name = "ExitBarButton"
        Me.ExitBarButton.ShortcutKeyDisplayString = "E"
        '
        'SaveFileLocation
        '
        Me.SaveFileLocation.Caption = "Save File @"
        Me.SaveFileLocation.Edit = Me.RepositoryItemButtonEdit2
        Me.SaveFileLocation.Glyph = Global.UIControllerGenerator.My.Resources.Resources.open_file_icon
        Me.SaveFileLocation.Hint = "Save File Location"
        Me.SaveFileLocation.Id = 11
        Me.SaveFileLocation.Name = "SaveFileLocation"
        Me.SaveFileLocation.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        Me.SaveFileLocation.Width = 200
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit2.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'ExitBarButtonItem
        '
        Me.ExitBarButtonItem.Caption = "Exit"
        Me.ExitBarButtonItem.Glyph = Global.UIControllerGenerator.My.Resources.Resources.Actions_session_exit_icon
        Me.ExitBarButtonItem.Hint = "Exit Generator"
        Me.ExitBarButtonItem.Id = 12
        Me.ExitBarButtonItem.LargeGlyph = Global.UIControllerGenerator.My.Resources.Resources.Actions_session_exit_icon
        Me.ExitBarButtonItem.Name = "ExitBarButtonItem"
        '
        'EditTemplateButton
        '
        Me.EditTemplateButton.Caption = "Edit"
        Me.EditTemplateButton.Glyph = Global.UIControllerGenerator.My.Resources.Resources.edit_file_icon
        Me.EditTemplateButton.Hint = "Edit Template"
        Me.EditTemplateButton.Id = 14
        Me.EditTemplateButton.Name = "EditTemplateButton"
        Me.EditTemplateButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'VSCheckEdit
        '
        Me.VSCheckEdit.Caption = "Visual Studio"
        Me.VSCheckEdit.Glyph = Global.UIControllerGenerator.My.Resources.Resources.Apps_Visual_Studio_alt_Metro_icon
        Me.VSCheckEdit.Hint = "Edit in Visual Studio"
        Me.VSCheckEdit.Id = 22
        Me.VSCheckEdit.Name = "VSCheckEdit"
        Me.VSCheckEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'TextCheckEdit
        '
        Me.TextCheckEdit.Caption = "Text Edit"
        Me.TextCheckEdit.Glyph = Global.UIControllerGenerator.My.Resources.Resources.text_icon
        Me.TextCheckEdit.Hint = "Edit in Text"
        Me.TextCheckEdit.Id = 23
        Me.TextCheckEdit.Name = "TextCheckEdit"
        Me.TextCheckEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'ProgressStaticText
        '
        Me.ProgressStaticText.Id = 24
        Me.ProgressStaticText.Name = "ProgressStaticText"
        Me.ProgressStaticText.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'ProgressBarEdit
        '
        Me.ProgressBarEdit.Edit = Me.RepositoryItemMarqueeProgressBar1
        Me.ProgressBarEdit.Id = 25
        Me.ProgressBarEdit.Name = "ProgressBarEdit"
        Me.ProgressBarEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        Me.ProgressBarEdit.Width = 100
        '
        'RepositoryItemMarqueeProgressBar1
        '
        Me.RepositoryItemMarqueeProgressBar1.Name = "RepositoryItemMarqueeProgressBar1"
        '
        'HelpBarButton
        '
        Me.HelpBarButton.Caption = "Help"
        Me.HelpBarButton.Glyph = Global.UIControllerGenerator.My.Resources.Resources.Help_icon
        Me.HelpBarButton.Hint = "Click for help"
        Me.HelpBarButton.Id = 26
        Me.HelpBarButton.Name = "HelpBarButton"
        Me.HelpBarButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'GeneratorPage
        '
        Me.GeneratorPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ActionsPageGroup})
        Me.GeneratorPage.Name = "GeneratorPage"
        Me.GeneratorPage.Text = "Home"
        '
        'ActionsPageGroup
        '
        Me.ActionsPageGroup.ItemLinks.Add(Me.AddRowButton)
        Me.ActionsPageGroup.ItemLinks.Add(Me.RemoveRowButton)
        Me.ActionsPageGroup.ItemLinks.Add(Me.GenerateButton)
        Me.ActionsPageGroup.ItemLinks.Add(Me.ExitBarButtonItem)
        Me.ActionsPageGroup.Name = "ActionsPageGroup"
        Me.ActionsPageGroup.Text = "Actions"
        '
        'SettingsPage
        '
        Me.SettingsPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ConfigurationPageGroup})
        Me.SettingsPage.Name = "SettingsPage"
        Me.SettingsPage.Text = "Settings"
        '
        'ConfigurationPageGroup
        '
        Me.ConfigurationPageGroup.ItemLinks.Add(Me.ShowSaveDialogField)
        Me.ConfigurationPageGroup.ItemLinks.Add(Me.SaveFileLocation)
        Me.ConfigurationPageGroup.Name = "ConfigurationPageGroup"
        Me.ConfigurationPageGroup.Text = "Configuration"
        '
        'AdminPage
        '
        Me.AdminPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.TemplateRibbonPageGroup, Me.EditModePageGroup})
        Me.AdminPage.Name = "AdminPage"
        Me.AdminPage.Text = "Administration"
        '
        'TemplateRibbonPageGroup
        '
        Me.TemplateRibbonPageGroup.ItemLinks.Add(Me.EditTemplateButton)
        Me.TemplateRibbonPageGroup.Name = "TemplateRibbonPageGroup"
        Me.TemplateRibbonPageGroup.Text = "Template"
        '
        'EditModePageGroup
        '
        Me.EditModePageGroup.ItemLinks.Add(Me.VSCheckEdit)
        Me.EditModePageGroup.ItemLinks.Add(Me.TextCheckEdit)
        Me.EditModePageGroup.Name = "EditModePageGroup"
        Me.EditModePageGroup.Text = "Edit Mode"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemRadioGroup1
        '
        Me.RepositoryItemRadioGroup1.Name = "RepositoryItemRadioGroup1"
        '
        'RepositoryItemRadioGroup2
        '
        Me.RepositoryItemRadioGroup2.Name = "RepositoryItemRadioGroup2"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.ExitBarButton)
        Me.RibbonStatusBar.ItemLinks.Add(Me.ProgressBarEdit)
        Me.RibbonStatusBar.ItemLinks.Add(Me.ProgressStaticText)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(442, 31)
        '
        'TransactionsGrid
        '
        Me.TransactionsGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionsGrid.Location = New System.Drawing.Point(0, 131)
        Me.TransactionsGrid.MainView = Me.TransactionsGridview
        Me.TransactionsGrid.MenuManager = Me.RibbonControl
        Me.TransactionsGrid.Name = "TransactionsGrid"
        Me.TransactionsGrid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.WorkflowEnabledCheckEdit})
        Me.TransactionsGrid.Size = New System.Drawing.Size(442, 287)
        Me.TransactionsGrid.TabIndex = 2
        Me.TransactionsGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TransactionsGridview})
        '
        'TransactionsGridview
        '
        Me.TransactionsGridview.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TransactionNameColumn, Me.EnableWorkflowColumn})
        Me.TransactionsGridview.GridControl = Me.TransactionsGrid
        Me.TransactionsGridview.Name = "TransactionsGridview"
        Me.TransactionsGridview.OptionsView.ShowGroupPanel = False
        '
        'TransactionNameColumn
        '
        Me.TransactionNameColumn.Caption = "Transaction Name"
        Me.TransactionNameColumn.FieldName = "TransactionName"
        Me.TransactionNameColumn.Name = "TransactionNameColumn"
        Me.TransactionNameColumn.OptionsColumn.AllowMove = False
        Me.TransactionNameColumn.OptionsColumn.AllowShowHide = False
        Me.TransactionNameColumn.OptionsColumn.AllowSize = False
        Me.TransactionNameColumn.OptionsFilter.AllowAutoFilter = False
        Me.TransactionNameColumn.OptionsFilter.AllowFilter = False
        Me.TransactionNameColumn.Visible = True
        Me.TransactionNameColumn.VisibleIndex = 0
        '
        'EnableWorkflowColumn
        '
        Me.EnableWorkflowColumn.Caption = "Enable Workflow"
        Me.EnableWorkflowColumn.ColumnEdit = Me.WorkflowEnabledCheckEdit
        Me.EnableWorkflowColumn.FieldName = "IsWorkflowEnabled"
        Me.EnableWorkflowColumn.Name = "EnableWorkflowColumn"
        Me.EnableWorkflowColumn.OptionsColumn.AllowMove = False
        Me.EnableWorkflowColumn.OptionsColumn.AllowShowHide = False
        Me.EnableWorkflowColumn.OptionsColumn.AllowSize = False
        Me.EnableWorkflowColumn.OptionsFilter.AllowAutoFilter = False
        Me.EnableWorkflowColumn.OptionsFilter.AllowFilter = False
        Me.EnableWorkflowColumn.Visible = True
        Me.EnableWorkflowColumn.VisibleIndex = 1
        '
        'WorkflowEnabledCheckEdit
        '
        Me.WorkflowEnabledCheckEdit.AutoHeight = False
        Me.WorkflowEnabledCheckEdit.Name = "WorkflowEnabledCheckEdit"
        '
        'Generator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 449)
        Me.ControlBox = False
        Me.Controls.Add(Me.TransactionsGrid)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Generator"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Generator"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsGridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkflowEnabledCheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents GeneratorPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ActionsPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents AddRowButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RemoveRowButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GenerateButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ShowSaveDialogField As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents SettingsPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ConfigurationPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents TransactionsGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents TransactionsGridview As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TransactionNameColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EnableWorkflowColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkflowEnabledCheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ExitBarButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SaveFileLocation As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ExitBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AdminPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents TemplateRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents EditTemplateButton As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents VSCheckEdit As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents TextCheckEdit As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents RepositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents RepositoryItemRadioGroup2 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents EditModePageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ProgressStaticText As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents ProgressBarEdit As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemMarqueeProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
    Friend WithEvents HelpBarButton As DevExpress.XtraBars.BarButtonItem


End Class
