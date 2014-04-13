Imports System.IO

Public Class CodeGenerator
    Implements IDisposable
    Public Property ControllerList As List(Of Models.FileViewModel)
    Private ZipDirectoryName As String = "TransactionController_"
    Public ZipDirectoryPath As String = Configuration.ConfigurationManager.AppSettings("SaveInDirectory") + "\"
    Public SaveDialogRequired As Boolean
    Public InitialDirectorySettingByUser As String
    Public IsGeneratedSuccessful As Boolean = False

#Region "Public Methods"
    ''' <summary>
    ''' To process the generation of code files and save the generated code files in ZIP format in a specified location mentioned in configuration
    ''' </summary>
    ''' <remarks></remarks>
    Public Function ProcessCodeGeneration() As Boolean
        SetDirectory()
        Using zipFile As New Ionic.Zip.ZipFile
            ControllerList.ForEach(Sub(controller)
                                       If Not String.IsNullOrWhiteSpace(controller.TransactionName) Then
                                           Dim fileDetail = GenerateFile(transactionName:=controller.TransactionName, isWorkflowEnabled:=controller.IsWorkflowEnabled)
                                           zipFile.AddEntry(fileDetail.Item1, fileDetail.Item2)
                                       Else
                                           MsgBox("Transaction name is empty", MsgBoxStyle.Critical)
                                       End If
                                   End Sub)
            zipFile.Save(ZipDirectoryPath)
        End Using
        If SaveDialogRequired Then
            SaveDialog()
        End If
        Return IsGeneratedSuccessful
    End Function
#End Region

#Region "Private Methods"
    ''' <summary>
    ''' To create directory to save the generated code
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetDirectory()
        ZipDirectoryName = ZipDirectoryName + DateTime.Now.ToString("dd_mm_yyyy_hh_mm_ss")
        ZipDirectoryPath = ZipDirectoryPath + ZipDirectoryName + ".zip"
        Dim directory As New DirectoryInfo(ZipDirectoryName)
        If directory.Exists Then
            directory.Delete()
        End If
    End Sub

    ''' <summary>
    ''' Generate code file based on the pattern selected to use appropriate T4 template
    ''' </summary>
    ''' <param name="transactionName">unique name for transaction controller generation</param>
    ''' <remarks></remarks>
    Private Function GenerateFile(transactionName As String, isWorkflowEnabled As Boolean) As Tuple(Of String, String)
        Dim myTemplate As New My.Templates.TransactionControllerGenerator(controllerName:=transactionName, isWorkflowEnabled:=isWorkflowEnabled)
        Dim controllerContent = myTemplate.TransformText
        Dim fileName As String = myTemplate.TransactionName + "Controller.vb"
        Dim fileContent = Tuple.Create(fileName, controllerContent)
        Return fileContent
    End Function

    ''' <summary>
    ''' Method to pop up save dialog for the user to save the generated code files in customized location.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveDialog()
        Dim SaveFile As New SaveFileDialog
        SaveFile.Title = "Save generated controller code file as"
        SaveFile.FileName = ZipDirectoryName
        SaveFile.DefaultExt = "zip"
        SaveFile.Filter = "All Files (*.zip)|*.zip"
        SaveFile.InitialDirectory = InitialDirectorySettingByUser
        SaveFile.OverwritePrompt = False
        If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            If ZipDirectoryPath.Equals(SaveFile.FileName) Then
                System.IO.File.Copy(ZipDirectoryPath, SaveFile.FileName)
                Dim file As New FileInfo(ZipDirectoryPath)
                file.Delete()
            End If
            IsGeneratedSuccessful = True
        End If
        SaveFile.Dispose()
    End Sub
#End Region

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ControllerList = Nothing
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
