<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Me.onebtnrd = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.roundrd = New System.Windows.Forms.RadioButton()
        Me.nextbtn = New System.Windows.Forms.Button()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.adhaarno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mobileno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_details = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'onebtnrd
        '
        Me.onebtnrd.AutoSize = True
        Me.onebtnrd.BackColor = System.Drawing.Color.Transparent
        Me.onebtnrd.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onebtnrd.ForeColor = System.Drawing.Color.Red
        Me.onebtnrd.Location = New System.Drawing.Point(440, 177)
        Me.onebtnrd.Margin = New System.Windows.Forms.Padding(4)
        Me.onebtnrd.Name = "onebtnrd"
        Me.onebtnrd.Size = New System.Drawing.Size(111, 42)
        Me.onebtnrd.TabIndex = 0
        Me.onebtnrd.TabStop = True
        Me.onebtnrd.Text = "Male"
        Me.onebtnrd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Tomato
        Me.Label1.Location = New System.Drawing.Point(399, -1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(639, 97)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Registration"
        '
        'roundrd
        '
        Me.roundrd.AutoSize = True
        Me.roundrd.BackColor = System.Drawing.Color.Transparent
        Me.roundrd.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roundrd.ForeColor = System.Drawing.Color.Red
        Me.roundrd.Location = New System.Drawing.Point(619, 177)
        Me.roundrd.Margin = New System.Windows.Forms.Padding(4)
        Me.roundrd.Name = "roundrd"
        Me.roundrd.Size = New System.Drawing.Size(144, 42)
        Me.roundrd.TabIndex = 2
        Me.roundrd.TabStop = True
        Me.roundrd.Text = "Female"
        Me.roundrd.UseVisualStyleBackColor = False
        '
        'nextbtn
        '
        Me.nextbtn.BackColor = System.Drawing.Color.White
        Me.nextbtn.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextbtn.ForeColor = System.Drawing.Color.Red
        Me.nextbtn.Location = New System.Drawing.Point(521, 802)
        Me.nextbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.nextbtn.Name = "nextbtn"
        Me.nextbtn.Size = New System.Drawing.Size(179, 59)
        Me.nextbtn.TabIndex = 21
        Me.nextbtn.Text = "Submit"
        Me.nextbtn.UseVisualStyleBackColor = False
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(432, 127)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(341, 22)
        Me.txt_username.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(109, 181)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 42)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(111, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 42)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "User Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(111, 250)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 42)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Age"
        '
        'age
        '
        Me.age.Location = New System.Drawing.Point(432, 265)
        Me.age.Margin = New System.Windows.Forms.Padding(4)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(341, 22)
        Me.age.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(111, 300)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 42)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Adhaar No"
        '
        'adhaarno
        '
        Me.adhaarno.Location = New System.Drawing.Point(432, 315)
        Me.adhaarno.Margin = New System.Windows.Forms.Padding(4)
        Me.adhaarno.Name = "adhaarno"
        Me.adhaarno.Size = New System.Drawing.Size(341, 22)
        Me.adhaarno.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(111, 367)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 42)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Mobile No"
        '
        'mobileno
        '
        Me.mobileno.Location = New System.Drawing.Point(432, 382)
        Me.mobileno.Margin = New System.Windows.Forms.Padding(4)
        Me.mobileno.Name = "mobileno"
        Me.mobileno.Size = New System.Drawing.Size(341, 22)
        Me.mobileno.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(111, 423)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 42)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Email ID"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(432, 438)
        Me.email.Margin = New System.Windows.Forms.Padding(4)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(341, 22)
        Me.email.TabIndex = 35
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(432, 490)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(341, 22)
        Me.txt_password.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(111, 537)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 42)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Details"
        '
        'txt_details
        '
        Me.txt_details.Location = New System.Drawing.Point(432, 551)
        Me.txt_details.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_details.Name = "txt_details"
        Me.txt_details.Size = New System.Drawing.Size(341, 22)
        Me.txt_details.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(109, 473)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(323, 42)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Enter the password"
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1816, 912)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_details)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mobileno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.adhaarno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nextbtn)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.roundrd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.onebtnrd)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Registration"
        Me.Text = "Registration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents onebtnrd As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents roundrd As RadioButton
    Friend WithEvents nextbtn As Button
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents age As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents adhaarno As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mobileno As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_details As TextBox
    Friend WithEvents Label8 As Label
End Class
