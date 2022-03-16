Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Web
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Partial Class menu
    Inherits System.Web.UI.Page
    Public sb1 As New StringBuilder




    Public Sub crea_menu()
        sb1.Append("<div id='cssmenu'>")
        sb1.Append("<ul>")
        sb1.Append("<li><a onclick=""$('.menu_quitar').hide()"" href=main.aspx?i=" & Encriptacion.Encrypt(cemp.Value) & " target='mainFrame'><span class='icon-home'></span>&nbsp;Inicio</a></li>")
        sb1.Append("</ul>")

        Select Case operacion.Value
            Case "recursos_humanos" : menu_recursos_humanos(sb1)

        End Select
        sb1.Append("</div'>")

        Label1.Text = sb1.ToString

    End Sub


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then
                cemp.Value = Encriptacion.Decrypt(Request.QueryString("i"))

                If Request.QueryString("op") <> "" Then
                    operacion.Value = Encriptacion.Decrypt(Request.QueryString("op"))
                End If
                crea_menu()
            End If
        Catch ex As Exception
            Response.Write(ex.ToString)
        End Try

    End Sub

    Public Function menu_recursos_humanos(sb1 As StringBuilder) As String
        sb1.Append("<ul>")
        sb1.Append("<li class='has-sub'>")
        sb1.Append("<a href='#'><span class='icon-hand-up'></span>&nbsp;Empleados</a>")
        sb1.Append("<ul>")
        sb1.Append("<li><a title='Registro de Empleados' href='sistema/recursos_humanos/registro_empleados.aspx?i=" & Encriptacion.Encrypt(cemp.Value) & "' target='mainFrame'>&nbsp;Registro</a></li>")
        sb1.Append("<li><a title='Modificación de Empleados' href='sistema/recursos_humanos/modificar_empleados.aspx?i=" & Encriptacion.Encrypt(cemp.Value) & "' target='mainFrame'>&nbsp;Modificar</a></li>")
        sb1.Append("<li><a title='Reporte de Empleados' href='sistema/reportes/reporte_empleados.aspx?i=" & Encriptacion.Encrypt(cemp.Value) & "' target='mainFrame'>&nbsp;Reporte</a></li>")
        sb1.Append("</ul>")
        sb1.Append("</li>")
        sb1.Append("</ul>")

        Return sb1.ToString
    End Function

End Class
