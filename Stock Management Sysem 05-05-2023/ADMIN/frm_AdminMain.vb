Public Class frm_AdminMain
    Private Sub frm_AdminMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ManageProducts_Click(sender As Object, e As EventArgs) Handles btn_ManageProducts.Click
        frm_manageProducts.ShowDialog()

    End Sub

    Private Sub btnManageStock_Click(sender As Object, e As EventArgs) Handles btnManageStock.Click

    End Sub

    Private Sub btn_ManageUsers_Click(sender As Object, e As EventArgs) Handles btn_ManageUsers.Click

    End Sub

    Private Sub btn_ChangePassword_Click(sender As Object, e As EventArgs) Handles btn_ChangePassword.Click

    End Sub

    Private Sub btn_Report_Click(sender As Object, e As EventArgs) Handles btn_Report.Click

    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Hide()
        frm_login.Show()

    End Sub
End Class