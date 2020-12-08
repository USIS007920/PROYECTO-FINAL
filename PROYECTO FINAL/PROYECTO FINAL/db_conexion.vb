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

        micomand.CommandText = "select * from empleados"
        miAdapter.SelectCommand = micomand
        miAdapter.Fill(ds, "empleados")

        micomand.CommandText = "select * from Provedores"
        miAdapter.SelectCommand = micomand
        miAdapter.Fill(ds, "Provedores")
        Return ds
    End Function

    Public Function mantenimientoDatosProducto(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Productos (idcategoria,codigo,nombre,marca,dimensiones) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "' )"
            Case "modificar"
                sql = "UPDATE productos SET categoria'" + datos(1) + "',codigo'" + datos(2) + "',nombre'" + datos(3) + "',marca'" + datos(4) + "',dimensiones'" + datos(5) + "'WHERE idProducto='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM productos WHERE idProducto'" + datos(0) + "'"
        End Select
        micomand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            micomand.Parameters("@idCategoria").Value = datos(1)
            micomand.Parameters("@cod").Value = datos(2)
            micomand.Parameters("@nom").Value = datos(3)
            micomand.Parameters("@mar").Value = datos(4)
            micomand.Parameters("@dim").Value = datos(5)
        End If
        If executeSql(sql) > 0 Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function

    Public Function mantenimientoDatosProvedores(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO provedores (codigo,nombre,direccion) VALUES(@cod,@nom,@dir)"
            Case "modificar"
                sql = "UPDATE provedores SET codigo=@cod,nombre=@nom,direccion=@dir WHERE idProvedores=@id"
            Case "eliminar"
                sql = "DELETE FROM provedores WHERE idProvedores=@id"
        End Select
        micomand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            micomand.Parameters("@cod").Value = datos(1)
            micomand.Parameters("@nom").Value = datos(2)
            micomand.Parameters("@dir").Value = datos(3)
        Else 'Accion es eliminar
            mantenimientoDatosProvedores(datos, accion)
        End If
        If (executeSql(sql) > 0) Then
            If accion IsNot "eliminar" Then
                mantenimientoDatosProvedores(datos, accion)
            End If
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function


    Public Function mantenimientoDatosEmpleados(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO empleados (codigo,nombre,telefono, direccion, email) VALUES(@cod,@nom,@dir)"
            Case "modificar"
                sql = "UPDATE empleados SET codigo=@cod,nombre=@nom,telefono=@tel,direccion=@dir,email=@email WHERE idEmpleados=@id"
            Case "eliminar"
                sql = "DELETE FROM empleados WHERE idEmpleados=@id"
        End Select
        micomand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            micomand.Parameters("@ncod").Value = datos(1)
            micomand.Parameters("@nom").Value = datos(2)
            micomand.Parameters("@tel").Value = datos(3)
            micomand.Parameters("@dir").Value = datos(4)
            micomand.Parameters("@email").Value = datos(5)
        Else 'Accion es eliminar
            mantenimientoDatosEmpleados(datos, accion)
        End If
        If (executeSql(sql) > 0) Then
            If accion IsNot "eliminar" Then
                mantenimientoDatosEmpleados(datos, accion)
            End If
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function

    Public Function mantenimientoDatosCliente(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO clientes (codigo,nombre,direccion) VALUES(@cod,@nom,@dir)"
            Case "modificar"
                sql = "UPDATE clientes SET codigo=@cod,nombre=@nom,direccion=@dir WHERE idCliente=@id"
            Case "eliminar"
                sql = "DELETE FROM clientes WHERE idCliente=@id"
        End Select
        micomand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            micomand.Parameters("@cod").Value = datos(1)
            micomand.Parameters("@nom").Value = datos(2)
            micomand.Parameters("@dir").Value = datos(3)
            micomand.Parameters("@tel").Value = datos(4)
            micomand.Parameters("@ema").Value = datos(5)
        Else 'Accion es eliminar
            mantenimientoDatosContacto(datos, accion)
        End If
        If (executeSql(sql) > 0) Then
            If accion IsNot "eliminar" Then
                mantenimientoDatosContacto(datos, accion)
            End If
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function

    Private Sub mantenimientoDatosContacto(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                micomand.Connection = miConexion
                micomand.CommandText = "select MAX(idCliente) AS idCliente from clientes"
                datos(0) = micomand.ExecuteScalar().ToString()

                sql = "INSERT INTO contactos (idPersona,telefono,email) VALUES(@id,@tel,@ema)"
            Case "modificar"
                sql = "UPDATE contactos SET telefono=@tel,email=@ema WHERE idPersona=@id"
            Case "eliminar"
                sql = "DELETE FROM contactos WHERE idPersona=@id"
        End Select
        micomand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            micomand.Parameters("@tel").Value = datos(4)
            micomand.Parameters("@ema").Value = datos(5)
        End If
        executeSql(sql)
    End Sub
    Private Function executeSql(ByVal sql As String)
        micomand.Connection = miConexion
        micomand.CommandText = sql
        Return micomand.ExecuteNonQuery()
    End Function


End Class
