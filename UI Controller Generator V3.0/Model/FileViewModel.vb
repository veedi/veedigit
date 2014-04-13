Namespace Models
    Public Class FileViewModel
        Private mTransactionName As String
        Public Property TransactionName() As String
            Get
                Return mTransactionName
            End Get
            Set(ByVal value As String)
                mTransactionName = value
            End Set
        End Property

        Private mIsWorkflowEnabled As Boolean
        Public Property IsWorkflowEnabled() As Boolean
            Get
                Return mIsWorkflowEnabled
            End Get
            Set(ByVal value As Boolean)
                mIsWorkflowEnabled = value
            End Set
        End Property

    End Class
End Namespace
