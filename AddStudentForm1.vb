Imports MySql.Data.MySqlClient
Public Class AddStudentForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Add_Stud_Button_Click(sender As Object, e As EventArgs) Handles Add_Stud_Button.Click
        Dim strsql As String = "insert into students values('" & Me.Stud_IDTextBox3.Text & "','" & Me.firstNameTextBox.Text & "','" & Me.LastName_TextBox2.Text & "','" & Me.Email_TextBox5.Text & "','" & Me.Birthday_TextBox4.Text & "','" & Me.Address_TextBox6.Text & "','" & Me.OrgNo_TextBox9.Text & "','" & Me.ClubNo_TextBox7.Text & "','" & Me.CourseNo_TextBox10.Text & "','" & Me.Tuition_TextBox8.Text & "')"
        MsgBox("Are you sure to ADD this new student to the records?")
        Connect_to_DB()
        Dim mycmmd As New MySqlCommand
        Try
            mycmmd.Connection = myconn
            mycmmd.CommandText = strsql
            mycmmd.ExecuteNonQuery()
            MsgBox("Student Successfully Added!", MsgBoxStyle.Information)
            Call Clear_Boxes()
            Me.Hide()
            Student_Form.Show()
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

    Private Sub backButton_Click_1(sender As Object, e As EventArgs) Handles backButton.Click
        Call Clear_Boxes()
        Me.Hide()
        Student_Form.Show()
    End Sub
End Class