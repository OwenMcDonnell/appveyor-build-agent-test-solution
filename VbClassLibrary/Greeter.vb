Public Class Greeter
    Public Function Greet(name As String) As String
        If String.IsNullOrWhiteSpace(name) Then
            Return "Hello from VB class library."
        End If

        Return $"Hello, {name}, from the Visual Basic class library."
    End Function
End Class
