Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class empleados
    Public Shared Function acceso_sistema(c1 As MySqlConnection, usuario1 As String, clave1 As String) As MySqlDataReader
        Dim Command_1 As MySqlCommand
        Command_1 = New MySqlCommand("select b.nombre as 'nombre' from cat_usuarios a " &
            "left join cat_empleados b on b.id=a.id_empleado " &
                               "where a.usuario=?usuario And a.clave=?clave", c1)
        Command_1.Parameters.AddWithValue("usuario", usuario1)
        Command_1.Parameters.AddWithValue("clave", clave1)
        Dim DataReader_1 As MySqlDataReader
        DataReader_1 = Command_1.ExecuteReader
        Return DataReader_1
    End Function
End Class
