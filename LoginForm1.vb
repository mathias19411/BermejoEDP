Imports MySql.Data.MySqlClient
Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        With Me
            Call Connect_to_DB()
            Dim myCommand As New MySqlCommand
            Dim myReader As MySqlDataReader


            strSQL = "Select * from accounts where username = '" _
                & .UsernameTextBox.Text & "' and password = md5('" _
                & .PasswordTextBox.Text & "')"
            'MsgBox(strSQL)
            myCommand.CommandText = strSQL
            myCommand.Connection = myconn

            myReader = myCommand.ExecuteReader
            If myReader.HasRows Then
                .Hide()
                mainMenu.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_DB()
            Call Clear_Boxes()
        End With
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegisterButton1_Click(sender As Object, e As EventArgs) Handles RegisterButton1.Click
        Me.Hide()
        SignUpForm.Show()
    End Sub
    Private Sub Clear_Boxes()
        With Me
            .UsernameTextBox.Text = ""
            .PasswordTextBox.Text = ""
        End With
    End Sub
End Class
