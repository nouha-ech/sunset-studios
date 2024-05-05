<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gold
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("MS Reference Sans Serif", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(610, 295)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 60)
        Button1.TabIndex = 0
        Button1.Text = "Book a movie now!"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Segoe Script", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(209, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(520, 57)
        Label1.TabIndex = 1
        Label1.Text = "Welcome to Sunset Studios"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(443, 206)
        Label2.Name = "Label2"
        Label2.Size = New Size(349, 64)
        Label2.TabIndex = 2
        Label2.Text = "Your gateway to captivating stories" & vbCrLf & "So grab your popcorn, dim the lights, " & vbCrLf & "and let Cinema Home take you on a" & vbCrLf & "cinematic journey unlike any other!"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(815, 435)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(831, 474)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Welcome to Sunset Studios"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
