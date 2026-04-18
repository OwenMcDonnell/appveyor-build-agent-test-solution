Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Http

Public Module Program
    Public Sub Main(args As String())
        Dim builder = WebApplication.CreateBuilder(args)
        Dim app = builder.Build()

        app.MapGet("/", Function() "Hello from the Visual Basic web project.")
        app.MapGet("/health", Function() Results.Ok(New With {.status = "ok", .language = "VB"}))

        app.Run()
    End Sub
End Module
