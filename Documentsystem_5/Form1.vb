Public Class frmmain
    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If MessageBox.Show("ທ່ານຕ້ອງການອອກຈາກລະບົບແທ້ບໍ່", "ຄໍາຖາມ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub

End Class
