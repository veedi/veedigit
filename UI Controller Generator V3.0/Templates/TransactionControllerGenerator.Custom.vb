Namespace My.Templates
    Partial Public Class TransactionControllerGenerator

#Region "Constructor"
        Public Sub New(controllerName As String, isWorkflowEnabled As Boolean)
            TransactionName = controllerName.ToPascalCase
            CamelTransactionName = controllerName.ToCamelCase
            WorkflowEnabled = isWorkflowEnabled
        End Sub
#End Region

#Region "Public Properties"
        Public Property TransactionName As String = String.Empty
        Public Property CamelTransactionName As String = String.Empty
        Public Property WorkstationName As String = Environment.MachineName.ToString
        Public Property UserName As String = Environment.UserName.ToString
        Public Property DomainName As String = Environment.UserDomainName.ToString
        Public Property WorkflowEnabled As Boolean
#End Region
        
    End Class
End Namespace
