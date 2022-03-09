Imports Microsoft.VisualBasic

Public Class MiniBuffer
    Private _buffer As StringBuilder

    Public Sub New()
        _buffer = New StringBuilder()
    End Sub
    Public Sub Write(text As String)
        _buffer.Append(text)
    End Sub
    Public Sub WriteLn(text As String)
        Me.Write(text & vbCrLf)
    End Sub

    Public Sub HtmlLINK(href As String)
        Me.WriteLn(String.Format("<link href='{0}' rel='stylesheet' />", href))
    End Sub
    Public Sub HtmlScript(src As String)
        Me.WriteLn(String.Format("<script src='{0}'></script>", src))
    End Sub
    Public Overrides Function ToString() As String
        Return _buffer.ToString()

    End Function
End Class
