<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Label7 = New Label()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(72, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 15)
        Label1.TabIndex = 3
        Label1.Text = "Home"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(44, 39)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Gold
        Label3.Location = New Point(326, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 16
        Label3.Text = "our movies"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Gold
        Label2.Location = New Point(224, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 15)
        Label2.TabIndex = 15
        Label2.Text = "Trending now "
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Gold
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"ENG", "FR ", "AR"})
        ComboBox1.Location = New Point(408, 22)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(52, 23)
        ComboBox1.TabIndex = 17
        ComboBox1.Text = "ENG"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Gold
        Label4.Location = New Point(15, 123)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 18
        Label4.Text = "E-mail"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ButtonFace
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(15, 150)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 16)
        TextBox1.TabIndex = 19
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ButtonFace
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(15, 212)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(176, 16)
        TextBox2.TabIndex = 21
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Gold
        Label5.Location = New Point(15, 185)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 20
        Label5.Text = "Password"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ButtonFace
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Location = New Point(15, 273)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(176, 16)
        TextBox3.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Gold
        Label6.Location = New Point(15, 246)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 15)
        Label6.TabIndex = 22
        Label6.Text = "Favorite movie genre"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.ButtonFace
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Location = New Point(15, 334)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(176, 16)
        TextBox4.TabIndex = 25
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.Gold
        Label7.Location = New Point(15, 307)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 15)
        Label7.TabIndex = 24
        Label7.Text = "Preferred language"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gold
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("MS Reference Sans Serif", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(62, 376)
        Button1.Name = "Button1"
        Button1.Size = New Size(89, 26)
        Button1.TabIndex = 26
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(197, 71)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(279, 404)
        PictureBox2.TabIndex = 27
        PictureBox2.TabStop = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkRed
        ClientSize = New Size(472, 475)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(Label7)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(488, 514)
        Name = "Form6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration form"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
