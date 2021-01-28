Public Class payflight
    Private Sub pay_btn_Click(sender As Object, e As EventArgs)

        confirm.Show()
        Me.Hide()
    End Sub

    Private Sub cancel_btnpay_Click(sender As Object, e As EventArgs)
        Hide()
    End Sub

    Private Sub payflight_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub name_card_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub email_id_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub price_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub expirydate_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub CCV_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub expiry_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cardnumber_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub namecard_Click(sender As Object, e As EventArgs)

    End Sub
End Class