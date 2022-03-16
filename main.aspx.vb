Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Web
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Partial Class main
    Inherits System.Web.UI.Page
    Public c1 As MySqlConnection
    Public cm1 As MySqlCommand
    Public dr1 As MySqlDataReader



    Public Sub conexion()
        c1 = New MySqlConnection(conectar.conec_string)
        c1.Open()
    End Sub


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then
                cemp.Value = Encriptacion.Decrypt(Request.QueryString("i"))


                conexion()
                cm1 = New MySqlCommand("select nombre as 'nombre' from cat_empleados where id=?id", c1)
                cm1.Parameters.AddWithValue("id", cemp.Value)
                dr1 = cm1.ExecuteReader
                If dr1.Read Then
                    Label1.Text = "Bienvenido " & dr1.Item("nombre").ToString
                End If
                dr1.Close()
                c1.Close()


                Label2.Text = "<a href=menu.aspx?i=" & Encriptacion.Encrypt(cemp.Value) & "&op=" & Encriptacion.Encrypt("recursos_humanos") & " target=leftFrame ><img src=images/iconos/1.png /></a>"


            End If
        Catch ex As Exception
            Response.Write(ex.ToString)
        End Try
    End Sub




End Class
