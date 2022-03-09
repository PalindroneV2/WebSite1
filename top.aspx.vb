Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Web
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Partial Class top
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
                id_empleado.Value = Encriptacion.Decrypt(Request.QueryString("i"))
                conexion()
                Label1.Text = empleados.obtiene_nombre_empleado(c1, id_empleado.Value)
                foto.Src = "images/fotos_empleados/" & id_empleado.Value & ".jpg"
                c1.Close()


            End If
        Catch ex As Exception
            Response.Write(ex.ToString)
        End Try
    End Sub
    Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
        conexion()
        bitacora.registra_evento(c1, id_empleado.Value, "2")
        c1.Close()

        Dim mb As New MiniBuffer()
        mb.WriteLn("var oDiv=document.createElement('div');")
        mb.WriteLn("oDiv.style='z-index:9999;position:absolute;top:0px;left:0px;right:0px;'")
        mb.Write("oDiv.innerHTML='")
        mb.Write("<p><a href=index.aspx id=""liga_salir"" target=""_parent"">Reingresar</a></p>")
        mb.WriteLn("';")
        mb.WriteLn("document.body.appendChild(oDiv);")
        mb.WriteLn("document.getElementById('liga_salir').click();")
        Me.ClientScript.RegisterClientScriptBlock(Me.GetType(), "acc_salir", mb.ToString(), True)


    End Sub
End Class
