Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports System.Data


Public Class empleados
    Public Shared Function acceso_sistema(c1 As MySqlConnection, usuario1 As String, clave1 As String) As MySqlDataReader
        Dim cm1 As MySqlCommand
        cm1 = New MySqlCommand("select b.id as 'id', b.nombre as 'nombre' from cat_usuarios a " &
                "left join cat_empleados b on b.id=a.id_empleado " &
                                   "where a.usuario=?usuario And a.clave=?clave", c1)
        cm1.Parameters.AddWithValue("usuario", usuario1)
        cm1.Parameters.AddWithValue("clave", clave1)
        Dim dr1 As MySqlDataReader
        dr1 = cm1.ExecuteReader
        Return dr1
    End Function

    Public Shared Function obtiene_nombre_empleado(c1 As MySqlConnection, id1 As String) As String
        Dim res As String = ""
        Dim cm1 As MySqlCommand
        Dim dr1 As MySqlDataReader
        cm1 = New MySqlCommand("select concat_ws(' ',nombre,apepat,apemat) as 'nombre_empleado' from cat_empleados where id=?id", c1)
        cm1.Parameters.AddWithValue("id", id1)
        dr1 = cm1.ExecuteReader
        If dr1.Read Then
            res = dr1.Item("nombre_empleado").ToString
        End If
        dr1.Close()
        Return res
    End Function

End Class
