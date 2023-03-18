Imports MySql.Data.MySqlClient
Public Class Student_Form
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles firstNameTextBox.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles loadStudentsButton.Click
        Me.DataGridView1.Rows.Clear()
        DataGridView1.Columns.Add("Column1", "Student ID")
        DataGridView1.Columns.Add("Column2", "First Name")
        DataGridView1.Columns.Add("Column3", "Last Name")
        DataGridView1.Columns.Add("Column4", "Email")
        DataGridView1.Columns.Add("Column5", "Birthday")
        DataGridView1.Columns.Add("Column6", "Address")
        DataGridView1.Columns.Add("Column7", "Organization")
        DataGridView1.Columns.Add("Column8", "Club")
        DataGridView1.Columns.Add("Column9", "Course")
        DataGridView1.Columns.Add("Column10", "Tuition Fee")
        Dim strSQL As String
        Dim command As New MySqlCommand
        strSQL = "Select * from students"
        Connect_to_DB()
        With command
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strSQL
        End With
        Dim myReader As MySqlDataReader
        myReader = command.ExecuteReader
        While myReader.Read()
            Me.DataGridView1.Rows.Add(New Object() {myReader.Item("stud_ID"), myReader.Item("first_name"), myReader.Item("last_name"), myReader.Item("email"), myReader.Item("birthday"), myReader.Item("address"), myReader.Item("org_Number"), myReader.Item("club_Number"), myReader.Item("course_Number"), myReader.Item("tuition_fee")})
        End While
        myReader.Close()
        myReader.Dispose()
        Disconnect_to_DB()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles backButton.Click
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Student_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Add_Stud_Button_Click(sender As Object, e As EventArgs) Handles Add_Stud_Button.Click
        Dim strsql As String = "insert into students values('" & Me.Stud_IDTextBox3.Text & "','" & Me.firstNameTextBox.Text & "','" & Me.LastName_TextBox2.Text & "','" & Me.Email_TextBox5.Text & "','" & Me.Birthday_TextBox4.Text & "','" & Me.Address_TextBox6.Text & "','" & Me.OrgNo_TextBox9.Text & "','" & Me.ClubNo_TextBox7.Text & "','" & Me.CourseNo_TextBox10.Text & "','" & Me.Tuition_TextBox8.Text & "')"
        Connect_to_DB()
        Dim mycmmd As New MySqlCommand
        Try
            mycmmd.Connection = myconn
            mycmmd.CommandText = strsql
            mycmmd.ExecuteNonQuery()
            MsgBox("Student Successfully Added!", MsgBoxStyle.Information)
            Call Clear_Boxes()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .Stud_IDTextBox3.Text = ""
            .firstNameTextBox.Text = ""
            .LastName_TextBox2.Text = ""
            .Email_TextBox5.Text = ""
            .Birthday_TextBox4.Text = ""
            .Address_TextBox6.Text = ""
            .OrgNo_TextBox9.Text = ""
            .ClubNo_TextBox7.Text = ""
            .CourseNo_TextBox10.Text = ""
            .Tuition_TextBox8.Text = ""
        End With
    End Sub
End Class