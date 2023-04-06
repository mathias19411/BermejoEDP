﻿Imports MySql.Data.MySqlClient
Public Class AddClubForm
    Private Sub AddClubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub addClubButton_Click(sender As Object, e As EventArgs) Handles addClubButton.Click
        Dim strsql As String = "insert into clubs values('" & Me.ClubIDTextBox.Text & "','" & Me.ClubNameTextBox.Text & "','" & Me.ClubPresTextBox.Text & "','" & Me.ClubDescTextBox.Text & "')"
        MsgBox("Are you sure to ADD this new club to the records?")
        Connect_to_DB()
        Dim mycmmd As New MySqlCommand
        Try
            mycmmd.Connection = myconn
            mycmmd.CommandText = strsql
            mycmmd.ExecuteNonQuery()
            MsgBox("Club Successfully Added!", MsgBoxStyle.Information)
            Call Clear_Boxes()
            Me.Hide()
            Club_Form.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
    End Sub
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Call Clear_Boxes()
        Club_Form.Show()
        Me.Hide()
    End Sub
    Private Sub Clear_Boxes()
        With Me
            .ClubIDTextBox.Text = ""
            .ClubNameTextBox.Text = ""
            .ClubPresTextBox.Text = ""
            .ClubDescTextBox.Text = ""
        End With
    End Sub
End Class
