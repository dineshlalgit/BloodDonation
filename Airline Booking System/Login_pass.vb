Public Class Login_pass

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "MAGESHVARAN" And PasswordTextBox.Text = "mageshvaran" Then
            Registration.Show()
            Hide()
        Else
            MsgBox("incorrect username or password", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        UsernameTextBox.Refresh()
        PasswordLabel.Refresh()
    End Sub

    Private Sub Login_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameTextBox.Enabled = False
        PasswordTextBox.Enabled = False

    End Sub

    Private Sub adminrd_CheckedChanged(sender As Object, e As EventArgs)

        UsernameTextBox.Refresh()
        PasswordTextBox.Refresh()
    End Sub





    Private Sub userrdbtn_CheckedChanged(sender As Object, e As EventArgs) Handles userrdbtn.CheckedChanged
        If userrdbtn.Enabled = True Then

            UsernameTextBox.Enabled = True
            PasswordTextBox.Enabled = True

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Registration.Show()

    End Sub
End Class
