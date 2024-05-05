<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        PictureBox2 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(44, 39)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(72, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 15)
        Label1.TabIndex = 1
        Label1.Text = "Home"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Gold
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"ENG", "FR ", "AR"})
        ComboBox1.Location = New Point(418, 22)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(52, 23)
        ComboBox1.TabIndex = 4
        ComboBox1.Text = "ENG"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, 94)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(225, 391)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.DarkRed
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.OldLace
        TextBox1.Location = New Point(243, 303)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(227, 182)
        TextBox1.TabIndex = 6
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.DarkRed
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.OldLace
        TextBox2.Location = New Point(243, 75)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(226, 222)
        TextBox2.TabIndex = 7
        TextBox2.Text = resources.GetString("TextBox2.Text")
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Gold
        Label4.Location = New Point(301, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 15)
        Label4.TabIndex = 10
        Label4.Text = "create an account"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkRed
        ClientSize = New Size(481, 507)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(497, 546)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Currently in our cinema"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
End Class
