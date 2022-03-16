Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Web
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Partial Class sistema_recursos_humanos_registro_empleados
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
            End If
        Catch ex As Exception
            Response.Write(ex.ToString)
        End Try
    End Sub



    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            mensaje.mostrar(Me, "Estimado usuario, debe introducir un nombre")
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            mensaje.mostrar(Me, "Estimado usuario, debe introducir un apellido paterno")
            TextBox2.Focus()
        ElseIf TextBox3.Text = "" Then
            mensaje.mostrar(Me, "Estimado usuario, debe introducir un apellido materno")
            TextBox3.Focus()
        ElseIf TextBox4.Text = "" Then
            mensaje.mostrar(Me, "Estimado usuario, debe introducir una fecha de nacimiento")
            TextBox4.Focus()
        ElseIf isdate(TextBox4.Text) = False Then
            mensaje.mostrar(Me, "Estimado usuario, debe introducir una fecha válida")
            TextBox4.Focus()
        Else
            conexion()

            cm1 = New MySqlCommand("select * from cat_empleados where apepat=?apepat and apemat=?apemat and nombre=?nombre and fecha_nac=?fecha_nac", c1)
            cm1.Parameters.AddWithValue("apepat", UCase(TextBox2.Text.Trim))
            cm1.Parameters.AddWithValue("apemat", UCase(TextBox3.Text.Trim))
            cm1.Parameters.AddWithValue("nombre", UCase(TextBox1.Text.Trim))
            cm1.Parameters.AddWithValue("fecha_nac", TextBox4.Text.Trim)
            dr1 = cm1.ExecuteReader
            If dr1.Read Then
                dr1.Close()
                mensaje.mostrar(Me, "Estimado usuario, el registro ya existe")
            Else
                dr1.Close()
                cm1 = New MySqlCommand("insert into cat_empleados " &
                "(apepat,apemat,nombre,fecha_nac) " &
                "values " &
                "(?apepat,?apemat,?nombre,?fecha_nac) " &
                                   " ", c1)
                cm1.Parameters.AddWithValue("apepat", UCase(TextBox2.Text.Trim))
                cm1.Parameters.AddWithValue("apemat", UCase(TextBox3.Text.Trim))
                cm1.Parameters.AddWithValue("nombre", UCase(TextBox1.Text.Trim))
                cm1.Parameters.AddWithValue("fecha_nac", TextBox4.Text.Trim)
                cm1.ExecuteNonQuery()
                mensaje.mostrar(Me, "Estimado usuario, se ha registrado correctamente")
                limpia()


            End If
            dr1.Close()


            c1.Close()


        End If
    End Sub

    Public Sub limpia()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

End Class
