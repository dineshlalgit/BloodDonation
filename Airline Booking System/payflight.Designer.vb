<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payflight
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'payflight
        '
        Me.ClientSize = New System.Drawing.Size(931, 474)
        Me.Name = "payflight"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents namecard As Label
    Friend WithEvents Cardnumber As Label
    Friend WithEvents expiry As Label
    Friend WithEvents CCV As Label
    Friend WithEvents name_card As TextBox
    Friend WithEvents expirydate As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents pay_btn As Button
    Friend WithEvents cancel_btnpay As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents email_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents price As Label
End Class
