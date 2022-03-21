Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Web
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Partial Class sistema_reportes_reporte_empleados
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
                reporte_tabla()
                reporte_grid()
                c1.Close()

            End If
        Catch ex As Exception
            Response.Write(ex.ToString)
        End Try
    End Sub

    Public Sub reporte_grid()
        cm1 = New MySqlCommand("select " &
                                     "nombre as 'Nombre', " &
                                     "apepat as 'Apellido Paterno', " &
                                     "apemat as 'Apellido Materno', " &
                                     "date_format(fecha_nac,'%d/%m/%Y') as 'Fecha de Nacimiento' " &
                                     " from cat_empleados " &
                                     "where visible<>99 " &
                               " ", c1)
        dr1 = cm1.ExecuteReader
        dg1.DataSource = dr1
        dg1.DataBind()
        dr1.Close()

        If dg1.Items.Count > 0 Then
            Label3.Text = "Total de registros encontrados: " & dg1.Items.Count.ToString & "<br>"
        Else
            Label3.Text = "Total de registros encontrados: 0" & "<br>"
        End If


    End Sub


    Public Sub reporte_tabla()
        Dim conta1 As Integer = 0
        cm1 = New MySqlCommand("select " &
                                       "apepat as 'apepat', " &
                                       "apemat as 'apemat', " &
                                       "nombre as 'nombre', " &
                                       "date_format(fecha_nac,'%d/%m/%Y') as 'fecha_nac' " &
                                       " from cat_empleados " &
                                       "where visible<>99 " &
                               " ", c1)
        dr1 = cm1.ExecuteReader

        Dim a As String = ""
        a = a + "<table style='width:100%;' class='w3-table w3-striped'>"
        a = a + "<tr class='w3-teal'>"
        a = a + "<td>Nombre"
        a = a + "</td>"
        a = a + "<td>Apellido Paterno"
        a = a + "</td>"
        a = a + "<td>Apellido Materno"
        a = a + "</td>"
        a = a + "<td>Fecha de Nacimiento"
        a = a + "</td>"
        a = a + "</tr>"

        While dr1.Read
            conta1 = conta1 + 1
            a = a + "<tr>"
            a = a + "<td>" & dr1.Item("nombre").ToString
            a = a + "</td>"
            a = a + "<td>" & dr1.Item("apepat").ToString
            a = a + "</td>"
            a = a + "<td>" & dr1.Item("apemat").ToString
            a = a + "</td>"
            a = a + "<td>" & dr1.Item("fecha_nac").ToString
            a = a + "</td>"
            a = a + "</tr>"
        End While
        dr1.Close()
        a = a + "</table>"
        Label2.Text = a
        Label1.Text = "Total de registros encontrados " & conta1.ToString & "<br>"
    End Sub




End Class
