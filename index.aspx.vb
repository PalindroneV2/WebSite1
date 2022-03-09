Imports MySql.Data.MySqlClient
Imports System.Data

Partial Class index
    Inherits System.Web.UI.Page

    Public c1 As MySqlConnection
    Public cm1 As MySqlCommand
    Public dr1 As MySqlDataReader

    Public Sub conexion()
        c1 = New MySqlConnection(conectar.conec_string)
        c1.Open()
    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            'Response.Write("<script>alert('Estimado usuario, falta información en el campo usuario');</script>")
            mensaje.mostrar(Me, "Estimado usuario, falta información en el campo usuario")
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            'Response.Write("<script>alert('Estimado usuario, falta información en el campo clave');</script>")
            mensaje.mostrar(Me, "Estimado usuario, falta información en el campo clave")
            TextBox2.Focus()
        Else
            conexion()
            dr1 = empleados.acceso_sistema(c1, TextBox1.Text.Trim, TextBox2.Text.Trim)
            If dr1.Read Then
                'mensaje.mostrar(Me, "Bienvenido " & dr1.Item("nombre").ToString)
                'Response.Redirect("unapagina.aspx?id=" & Encriptacion.Encrypt(dr1.Item("id").ToString))
                Dim id_empleado As String = dr1.Item("id").ToString
                dr1.Close()
                bitacora.registra_evento(c1, id_empleado, "1")
                Response.Redirect("entrada.aspx?id=" & Encriptacion.Encrypt(id_empleado))

            Else
                mensaje.mostrar(Me, "Estimado usuario, los datos no se encuentran")
            End If
            dr1.Close()

            'cm1 = New MySqlCommand("select b.id as 'id', b.nombre as 'nombre' from cat_usuarios a " &
            '    "left join cat_empleados b on b.id=a.id_empleado " &
            '                       "where a.usuario=?usuario And a.clave=?clave", c1)
            'cm1.Parameters.AddWithValue("usuario", TextBox1.Text.Trim)
            'cm1.Parameters.AddWithValue("clave", TextBox2.Text.Trim)
            'dr1 = cm1.ExecuteReader
            'If dr1.Read Then
            '    mensaje.mostrar(Me, "Bienvenido " & dr1.Item("nombre").ToString)
            '    Response.Redirect("entrada.aspx?id=" & Encriptacion.Encrypt(dr1.Item("id").ToString))
            '    'Response.Write("Bienvenido " & dr1.Item("nombre").ToString)
            'Else
            '    dr1.Close()
            '    Response.Write("<script>alert('El usuario no se encuentra');</script>")
            'End If
            'dr1.Close()
            c1.Close()


        End If
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Label2.Text = Now

            'If Not Page.IsPostBack Then
            '    Label1.Text = Now
            'End If
        Catch ex As Exception
            Response.Write(ex.ToString)
        End Try
    End Sub
End Class
