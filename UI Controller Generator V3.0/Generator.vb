Imports System.ComponentModel
Imports UIControllerGenerator.Models

Public Class Generator

#Region "Public Methods"
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ProgressBarEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        ' Add any initialization after the InitializeComponent() call.
        SetDatasource()
    End Sub
#End Region

    Public Property MultiFileGeneratorModel As BindingList(Of FileViewModel)

#Region "Private Methods/Events"
    Private Sub SetDatasource()
        MultiFileGeneratorModel = New BindingList(Of FileViewModel)
        TransactionsGrid.DataSource = MultiFileGeneratorModel
        SaveFileLocation.EditValue = Configuration.ConfigurationManager.AppSettings("SaveInDirectory")
    End Sub

    Private Sub AddRowButton_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles AddRowButton.ItemClick
        MultiFileGeneratorModel.AddNew()
    End Sub

    Private Sub RemoveRowButton_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles RemoveRowButton.ItemClick
        Dim selectedRow = CType(TransactionsGridview.GetFocusedRow, FileViewModel)
        MultiFileGeneratorModel.Remove(selectedRow)
    End Sub

    Private Sub GenerateButton_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles GenerateButton.ItemClick
        If ValidateData() Then
            Using generator As New CodeGenerator
                ProgressBarEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                ProgressStatictext.Caption = "Code Generator Initialized..."
                If ShowSaveDialogField.Checked Then generator.SaveDialogRequired = True Else generator.SaveDialogRequired = False
                generator.ZipDirectoryPath = SaveFileLocation.EditValue
                generator.InitialDirectorySettingByUser = SaveFileLocation.EditValue
                generator.ControllerList = MultiFileGeneratorModel.ToList
                ProgressStatictext.Caption = "Processing Code Generation..."
                If generator.ProcessCodeGeneration() Then
                    ProgressStatictext.Caption = "Code Generation Successful"
                Else
                    ProgressStatictext.Caption = "Code Generation Cancelled"
                End If
                ProgressBarEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            End Using
        End If
    End Sub

    Private Function ValidateData() As Boolean
        ProgressStatictext.Caption = "Validation Transaction List..."
        If Not MultiFileGeneratorModel.Any Then
            MsgBox("Enter atleast one transaction name", MsgBoxStyle.Critical)
            Return False
        End If
        Dim itemWithoutTransactionName = MultiFileGeneratorModel.Where(Function(item) String.IsNullOrWhiteSpace(item.TransactionName))
        If itemWithoutTransactionName.Any Then
            MsgBox("Enter missing transaction names", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function

    Private Sub RepositoryItemButtonEdit2_Click(sender As Object, e As System.EventArgs) Handles RepositoryItemButtonEdit2.Click
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Select folder path to save generated code files"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            SaveFileLocation.EditValue = dialog.SelectedPath + "\"
        End If
    End Sub

    Private Sub ExitBarButton_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ExitBarButton.ItemClick
        Me.Close()
    End Sub

    Private Sub ExitBarButtonItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ExitBarButtonItem.ItemClick
        Me.Close()
    End Sub

    Private Sub VSCheckEdit_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles VSCheckEdit.CheckedChanged
        If VSCheckEdit.Checked Then
            TextCheckEdit.Checked = False
        Else
            TextCheckEdit.Checked = True
        End If
    End Sub

    Private Sub TextCheckEdit_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles TextCheckEdit.CheckedChanged
        If TextCheckEdit.Checked Then
            VSCheckEdit.Checked = False
        Else
            VSCheckEdit.Checked = True
        End If
    End Sub

    Private Sub EditTemplateButton_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles EditTemplateButton.ItemClick
        If VSCheckEdit.Checked Then
            EditInVsIde()
        ElseIf TextCheckEdit.Checked Then
            EditInText()
        Else
            MsgBox("Please select atleast one edit mode", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub EditInVsIde()
        Dim vsIdeType As Type
        Dim vsIdeDte As EnvDTE.DTE
        vsIdeType = Type.GetTypeFromProgID("VisualStudio.DTE.10.0")
        vsIdeDte = DirectCast(System.Activator.CreateInstance(vsIdeType), EnvDTE.DTE)
        'vsIdeDte.MainWindow.Visible = False
        vsIdeDte.UserControl = True
        'vsIdeDte.MainWindow.WindowState = EnvDTE.vsWindowState.vsWindowStateMaximize
        vsIdeDte.ItemOperations.OpenFile("C:\Users\veedi\Documents\MyProjects\DMV\RI\T4 Templates\Working Solution\UI Controller Generator\Templates\TransactionControllerGenerator.tt", EnvDTE.Constants.vsWindowKindClassView)
    End Sub

    Private Sub EditInText()
        System.Diagnostics.Process.Start("Notepad.Exe", "C:\Users\veedi\Documents\MyProjects\DMV\RI\T4 Templates\Working Solution\UI Controller Generator\Templates\TransactionControllerGenerator.tt")
    End Sub

    Private Sub HelpBarButton_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles HelpBarButton.ItemClick
        Help.ShowHelp(Me, "C:\Users\veedi\Documents\MyProjects\DMV\RI\T4 Templates\Working Solution\UI Controller Generator\Help.chm", HelpNavigator.TableOfContents)
    End Sub
#End Region

End Class