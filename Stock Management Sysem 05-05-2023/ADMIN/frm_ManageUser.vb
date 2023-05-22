Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbcoon()


    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Sub clear()
        txt_Name.Clear()
        Txt_Password.Clear()
        txt_Username.Clear()
        cbo_role.SelectedIndex = -1

    End Sub

    Private Sub btn_Register_Click(sender As Object, e As EventArgs) Handles btn_Register.Click
        Try
            conn.Open()
            cmd = New MySqlCommand("INSERT INTO `tbluser`(`name`, `username`, `password`, `role`) VALUES (@name,@username,@password,@role)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", txt_Name.Text)
            cmd.Parameters.AddWithValue("@username", txt_Username.Text)
            cmd.Parameters.AddWithValue("@password", Txt_Password.Text)
            cmd.Parameters.AddWithValue("@role", cbo_role.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("New User Register Sucess !", Pro_title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("New User Register Failed !", Pro_title, MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
    End Sub
End Class
