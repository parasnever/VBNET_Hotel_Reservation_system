Imports MySql.Data.MySqlClient

Public Class Reservation
    Dim connection As New CONNECTION()
    'add reservation function
    'edit reservation function
    'remove reservation function

    'get all reservation function
    Function getAllReservation() As DataTable
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()

        Dim selectQuery As String = "SELECT * FROM `reservation`"
        command.CommandText = selectQuery
        command.Connection = CONNECTION.getConnection()



        adapter.SelectCommand = command

        adapter.Fill(table)
        Return table
    End Function
End Class
