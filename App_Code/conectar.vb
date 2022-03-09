Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports System.Data


Public Class conectar
    Public Shared Function conec_string() As String
        Dim strConnString As String = ""
        strConnString = "Server=127.0.0.1;User id=root;Password=123456;Database=empresa_servicios;pooling=false;port=3306;default command timeout=0;CharSet=utf8;"
        Return strConnString
    End Function
End Class
'Comentario nuevo 2