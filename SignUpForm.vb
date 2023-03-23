Imports MySql.Data.MySqlClient
Public Class SignUpForm
    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RegisterButton1_Click(sender As Object, e As EventArgs) Handles RegisterButton1.Click
        Dim strsql As String = "insert into `bermejoact2`.`accounts` (`username`, `password`) values('" & Me.UsernameTextBox.Text & "', md5('" & Me.PasswordTextBox.Text & "'))"
        Connect_to_DB()
        Dim mycmmd As New MySqlCommand
        Try
            mycmmd.Connection = myconn
            mycmmd.CommandText = strsql
            mycmmd.ExecuteNonQuery()
            MsgBox("Account Registration Successful!", MsgBoxStyle.Information)
            Call Clear_Boxes()
            Me.Hide()
            LoginForm1.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .UsernameTextBox.Text = ""
            .PasswordTextBox.Text = ""
        End With
    End Sub
End Class