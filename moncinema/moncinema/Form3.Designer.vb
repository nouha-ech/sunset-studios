<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        genrebox = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 36)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(330, 92)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(472, 361)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(73, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 15)
        Label1.TabIndex = 2
        Label1.Text = "Home"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Goldenrod
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 178)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(296, 249)
        DataGridView1.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(73, 123)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(126, 23)
        TextBox1.TabIndex = 4
        ' 
        ' genrebox
        ' 
        genrebox.AutoSize = True
        genrebox.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        genrebox.ForeColor = SystemColors.ButtonFace
        genrebox.Location = New Point(12, 92)
        genrebox.Name = "genrebox"
        genrebox.Size = New Size(124, 16)
        genrebox.TabIndex = 5
        genrebox.Text = "Enter movie genre:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gold
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(214, 123)
        Button1.Name = "Button1"
        Button1.Size = New Size(84, 23)
        Button1.TabIndex = 6
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Gold
        Label2.Location = New Point(330, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 15)
        Label2.TabIndex = 7
        Label2.Text = "Trending now "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Gold
        Label3.Location = New Point(441, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 15)
        Label3.TabIndex = 8
        Label3.Text = "our movies"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Gold
        Label4.Location = New Point(538, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 15)
        Label4.TabIndex = 9
        Label4.Text = "Search by genres "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Gold
        Label5.Location = New Point(658, 23)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 15)
        Label5.TabIndex = 10
        Label5.Text = "create an account"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkRed
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(genrebox)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(816, 489)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Search by genre"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents genrebox As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
