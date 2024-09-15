Imports MySql.Data.MySqlClient

Public Class CONNECTION

    Private connection As New MySqlConnection("datasource=localhost;port=3306;username = root;password=;database=vbnet_hotel_reservation_db")
    'return the connection

    Function getConnection() As MySqlConnection
        Return connection

    End Function

    'open the connection
    Sub openConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()


        End If
    End Sub

    'close the connection 
    Sub closeConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()

        End If
    End Sub


End Class
