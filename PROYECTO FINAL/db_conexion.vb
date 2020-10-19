Imports System.Data
Imports System.Data.SqlClient
Public Class db_conexion
    Dim miConexion As New SqlConnection
    Dim micomand As New SqlCommand
    Dim miAdapter As New SqlDataAdapter
    Dim ds As New DataSet


    Public Sub New()
        Dim cadenaConexion As String
        cadenaConexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Db_Sistema.mdf;Integrated Security=True"
        miConexion.ConnectionString = cadenaConexion

        miConexion.Open()

    End Sub

    Public Function obtenerDatos()
        ds.Clear()

        micomand.Connection = miConexion

        micomand.CommandText = "select * from Productos"
        miAdapter.SelectCommand = micomand
        miAdapter.Fill(ds, "Productos")

        Return ds
    End Function

    Private Sub mantenimientoDatosProducto(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Productos (idcategoria,codigo,nombre,marca,dimensiones) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "' )"
            Case "modificar"
                sql = "UPDATE productos SET categoria'" + datos(1) + "',codigo'" + datos(2) + "',nombre'" + datos(3) + "',marca'" + datos(4) + "',dimensiones'" + datos(5) + "'WHERE idProducto='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM productos WHERE idProducto'" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "Accion realizada con exito"
        Else
            msg = "error"
        End If
        executeSql(sql)
    End Sub
    Private Function executeSql(ByVal sql As String)
        micomand.Connection = miConexion
        micomand.CommandText = sql
        Return micomand.ExecuteNonQuery()
    End Function


End Class
