Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Web
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Partial Class sistema_recursos_humanos_modificar_empleados
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
                'reporte_grid()
                c1.Close()

            End If
        Catch ex As Exception
            Response.Write(ex.ToString)
        End Try
    End Sub

    Public Sub reporte_grid(valor1 As String)

        Dim cadena1 As String = ""

        If valor1 <> "*" Then
            cadena1 = "where apepat like '%" & valor1 & "%' or apemat like '%" & valor1 & "%' or nombre like '%" & valor1 & "%' "
        End If

        cm1 = New MySqlCommand("select " &
                                "id as 'id', " &
                                "nombre as 'Nombre', " &
                                "apepat as 'Apellido Paterno', " &
                                "apemat as 'Apellido Materno', " &
                                "visible as 'estatus', " &
                                "date_format(fecha_nac,'%d/%m/%Y') as 'Fecha de Nacimiento' " &
                                " from cat_empleados " &
                                " " & cadena1 & " " &
                                " ", c1)
        dr1 = cm1.ExecuteReader
        dg1.DataSource = dr1
        dg1.DataBind()
        dr1.Close()

        If dg1.Items.Count > 0 Then
            Label3.Text = "Total de registros encontrados: " & dg1.Items.Count.ToString & "<br>"
            dg1.Visible = True
        Else
            Label3.Text = "Total de registros encontrados: 0" & "<br>"
            dg1.Visible = False
        End If


    End Sub

    Sub dg1_Update(ByVal sender As Object, ByVal e As DataGridCommandEventArgs) Handles dg1.EditCommand
        Dim aid As String = ""
        Dim aestatus As String = ""
        aid = CType(e.Item.FindControl("id1"), Label).Text
        aestatus = CType(e.Item.FindControl("estatus1"), Label).Text

        Dim aoperacion As String = e.CommandArgument.ToString

        If aoperacion = "MODIFICAR" Then
            tabla_modificar.Visible = True
            dg1.Visible = False
            Label4.Text = aid

            conexion()
            cm1 = New MySqlCommand("select *, date_format(fecha_nac,'%Y-%m-%d') as 'fecha_nacimiento' from cat_empleados where id=?id", c1)
            cm1.Parameters.AddWithValue("id", aid)
            dr1 = cm1.ExecuteReader
            If dr1.Read Then
                TextBox2.Text = dr1.Item("nombre").ToString
                TextBox3.Text = dr1.Item("apepat").ToString
                TextBox4.Text = dr1.Item("apemat").ToString
                TextBox5.Text = dr1.Item("fecha_nacimiento").ToString
            End If
            dr1.Close()

            c1.Close()


            If aestatus = "1" Then
                Button4.Visible = True
                Button5.Visible = False
                Button3.Visible = True
            ElseIf aestatus = "99" Then
                Button4.Visible = False
                Button5.Visible = True
                Button3.Visible = False
            End If


        End If



    End Sub





    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tabla_modificar.Visible = False
        If TextBox1.Text = "" Then
            mensaje.mostrar(Me, "Estimado usuario, debe introducir un valor")
            TextBox1.Focus()
        Else
            conexion()
            reporte_grid(TextBox1.Text)
            c1.Close()
        End If


    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tabla_modificar.Visible = False
        dg1.Visible = True
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox2.Text = "" Then
            mensaje.mostrar(Me, "Estimado usuario, debe introducir un nombre")
            TextBox2.Focus()
        ElseIf TextBox3.Text = "" Then
            mensaje.mostrar(Me, "Estimado usuario, debe introducir un apellido paterno")
            TextBox3.Focus()
        ElseIf TextBox4.Text = "" Then
            mensaje.mostrar(Me, "Estimado usuario, debe introducir un apellido materno")
            TextBox4.Focus()
        ElseIf TextBox5.Text = "" Then
            mensaje.mostrar(Me, "Estimado usuario, debe introducir una fecha de nacimiento")
            TextBox5.Focus()
        ElseIf IsDate(TextBox5.Text) = False Then
            mensaje.mostrar(Me, "Estimado usuario, debe introducir una fecha válida")
            TextBox5.Focus()
        Else
            conexion()
            cm1 = New MySqlCommand("update cat_empleados set nombre=?nombre, apepat=?apepat, apemat=?apemat, fecha_nac=?fecha_nac where id=?id", c1)
            cm1.Parameters.AddWithValue("nombre", UCase(TextBox2.Text.Trim))
            cm1.Parameters.AddWithValue("apepat", UCase(TextBox3.Text.Trim))
            cm1.Parameters.AddWithValue("apemat", UCase(TextBox4.Text.Trim))
            cm1.Parameters.AddWithValue("fecha_nac", TextBox5.Text.Trim)
            cm1.Parameters.AddWithValue("id", Label4.Text)
            cm1.ExecuteNonQuery()
            reporte_grid(TextBox1.Text)
            tabla_modificar.Visible = False
            mensaje.mostrar(Me, "Estimado usuario, el registro se ha modificado correctamente")
            c1.Close()

        End If

    End Sub
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        conexion()
        cm1 = New MySqlCommand("update cat_empleados set visible=99 where id=?id", c1)
        cm1.Parameters.AddWithValue("id", Label4.Text)
        cm1.ExecuteNonQuery()
        reporte_grid(TextBox1.Text)
        tabla_modificar.Visible = False
        mensaje.mostrar(Me, "Estimado usuario, el registro se ha eliminado correctamente")
        c1.Close()
    End Sub
    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        conexion()
        cm1 = New MySqlCommand("update cat_empleados set visible=1 where id=?id", c1)
        cm1.Parameters.AddWithValue("id", Label4.Text)
        cm1.ExecuteNonQuery()
        reporte_grid(TextBox1.Text)
        tabla_modificar.Visible = False
        mensaje.mostrar(Me, "Estimado usuario, el registro se ha reactivado correctamente")
        c1.Close()
    End Sub
End Class
