Imports MySql.Data.MySqlClient
Public Class UpdateStudentForm
    Private Sub UpdateStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Update_Stud_Button_Click(sender As Object, e As EventArgs) Handles Update_Stud_Button.Click
        Dim strsql As String = "update students set first_name = '" & Me.firstNameTextBox.Text & "', last_name = '" & Me.LastName_TextBox2.Text & "', email = '" & Me.Email_TextBox5.Text & "', birthday = '" & Me.Birthday_TextBox4.Text & "', address = '" & Me.Address_TextBox6.Text & "', org_Number = " & Me.OrgNo_TextBox9.Text & ", club_Number = " & Me.ClubNo_TextBox7.Text & ", course_Number = " & Me.CourseNo_TextBox10.Text & ", tuition_fee = " & Me.Tuition_TextBox8.Text & " where stud_ID = " & Me.Stud_IDTextBox3.Text & " "
        MsgBox("Are you sure you want to UPDATE the student with ID = " & Me.Stud_IDTextBox3.Text & "?")
        Connect_to_DB()
        Dim mycmmd As New MySqlCommand
        Try
            mycmmd.Connection = myconn
            mycmmd.CommandText = strsql
            mycmmd.ExecuteNonQuery()
            MsgBox("Student Successfully Updated!", MsgBoxStyle.Information)
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

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Hide()
        Student_Form.Show()
    End Sub
End Class