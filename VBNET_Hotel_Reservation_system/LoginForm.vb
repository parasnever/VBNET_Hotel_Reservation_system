Imports MySql.Data.MySqlClient


Public Class LoginForm
    Private Sub TextBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsername.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'download mysql connector from -> https://dev.mysql.com/downloads/connector/net/
    'add the mysql connector to the project 
    'open xampp server
    'start mysql and apache
    'create database by using phpmyadmin ( http://localhost/phpmyadmin/ )
    'create a table users with 3 columns (id,username,password) for the login
    'create connection class to connect our app with mysql database 

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim connection As New CONNECTION()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand()
        Dim table As New DataTable()
        Dim username As String = TextBoxUsername.Text
        Dim password As String = TextBoxPassword.Text
        Dim selectQuery As String = "SELECT * FROM `users` WHERE `username` =@un AND `password`=@1paras"
        command.CommandText = selectQuery
        command.Connection = connection.getConnection()
        command.Parameters.Add("@un", MySqlDbType.VarChar).Value = username
        command.Parameters.Add("@1paras", MySqlDbType.VarChar).Value = password



        adapter.SelectCommand = command

        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Dim mainForm As New MainForm()
            mainForm.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                            )





        End If











    End Sub
End Class