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
        GroupBox1 = New GroupBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        ListBox1 = New ListBox()
        Button5 = New Button()
        Button6 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(195, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(295, 155)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(149, 112)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(128, 23)
        TextBox3.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(149, 72)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(128, 23)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(149, 34)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(128, 23)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(6, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 18)
        Label3.TabIndex = 2
        Label3.Text = "Step"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(6, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 18)
        Label2.TabIndex = 1
        Label2.Text = "Batas Akhir"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(6, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 18)
        Label1.TabIndex = 0
        Label1.Text = "Batas Awal"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Location = New Point(108, 192)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(487, 79)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(361, 35)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 3
        Button4.Text = "While"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(228, 35)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 2
        Button3.Text = "Do Until"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(116, 35)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 1
        Button2.Text = "Do While"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(15, 35)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "For"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(270, 277)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(167, 139)
        ListBox1.TabIndex = 2
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(555, 343)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 3
        Button5.Text = "Close"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(555, 393)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 23)
        Button6.TabIndex = 4
        Button6.Text = "Clear"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        ClientSize = New Size(681, 450)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(ListBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
