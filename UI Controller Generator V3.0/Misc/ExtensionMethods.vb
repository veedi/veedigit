Imports System.ComponentModel

Module ExtensionMethods

    <System.Runtime.CompilerServices.Extension()> _
    Public Function ToCamelCase(ByVal inputString As String) As String
        If (inputString Is Nothing OrElse inputString.Length < 2) Then Return inputString
        Dim words() As String = inputString.Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries)
        Dim result As String = words(0).ToLower()
        For i As Integer = 1 To words.Length - 1
            result &= words(i).Substring(0, 1).ToUpper() & words(i).Substring(1)
        Next i
        Return result
    End Function

    <System.Runtime.CompilerServices.Extension()> _
    Public Function ToPascalCase(ByVal inputString As String) As String
        If (inputString Is Nothing) Then Return inputString
        If (inputString.Length < 2) Then Return inputString.ToUpper()
        Dim words() As String = inputString.Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries)
        Dim result As String = ""
        For Each word As String In words
            result &= word.Substring(0, 1).ToUpper() & word.Substring(1)
        Next word
        Return result
    End Function

    <System.Runtime.CompilerServices.Extension()> _
    Public Function ToList(Of T)(ByVal items As BindingList(Of T)) As List(Of T)
        Dim list As New List(Of T)()
        If items Is Nothing Then
            Throw New ArgumentNullException("items")
        End If
        For i As Integer = 0 To items.Count - 1
            list.Add(items(i))
        Next
        Return list
    End Function
End Module
