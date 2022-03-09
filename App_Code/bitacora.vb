Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class bitacora
    Public Shared Sub registra_evento(c1 As MySqlConnection, id_empleado1 As String, id_evento1 As String)
        Dim cm1 As MySqlCommand
        cm1 = New MySqlCommand("insert into bitacora " &
                                       "(id_empleado,fecha_evento,id_evento) " &
                                       "values " &
                                       "(?id_empleado,now(),?id_evento) " &
                                       " ", c1)
        cm1.Parameters.AddWithValue("id_empleado", id_empleado1)
        cm1.Parameters.AddWithValue("id_evento", id_evento1)
        cm1.ExecuteNonQuery()
    End Sub
End Class
