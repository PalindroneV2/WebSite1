Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Public Class mensaje
    Public Shared Sub mostrar(paginaActual As Page, texto As String)
        Dim resultado As String = ""
        resultado += "<script>alert('" + texto + "');</script>"
        paginaActual.Response.Write(resultado)
    End Sub

End Class
