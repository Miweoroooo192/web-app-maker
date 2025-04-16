<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        website = New TextBox()
        title = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        Edge = New RadioButton()
        Chrome = New RadioButton()
        Label4 = New Label()
        port = New TextBox()
        RelayBoings = New Button()
        Path = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 20)
        Label1.TabIndex = 0
        Label1.Text = "Directory"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(286, 20)
        Label2.TabIndex = 1
        Label2.Text = "Website (how will have app will look like):"
        ' 
        ' website
        ' 
        website.Location = New Point(42, 142)
        website.Name = "website"
        website.Size = New Size(257, 27)
        website.TabIndex = 2
        ' 
        ' title
        ' 
        title.Location = New Point(47, 222)
        title.Name = "title"
        title.Size = New Size(252, 27)
        title.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 4
        Label3.Text = "Title:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(619, 357)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 5
        Button1.Text = "Make it!"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Edge
        ' 
        Edge.AutoSize = True
        Edge.Location = New Point(448, 118)
        Edge.Name = "Edge"
        Edge.Size = New Size(92, 24)
        Edge.TabIndex = 6
        Edge.TabStop = True
        Edge.Text = "Use Edge"
        Edge.UseVisualStyleBackColor = True
        ' 
        ' Chrome
        ' 
        Chrome.AutoSize = True
        Chrome.Location = New Point(448, 148)
        Chrome.Name = "Chrome"
        Chrome.Size = New Size(286, 24)
        Chrome.TabIndex = 7
        Chrome.TabStop = True
        Chrome.Text = "Use Chrome/Chromium based browser"
        Chrome.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(47, 270)
        Label4.Name = "Label4"
        Label4.Size = New Size(703, 20)
        Label4.TabIndex = 8
        Label4.Text = "Port (optional but do not blank it also it might be useful of you have another app created with this thing):"
        ' 
        ' port
        ' 
        port.Location = New Point(47, 318)
        port.Name = "port"
        port.Size = New Size(252, 27)
        port.TabIndex = 9
        port.Text = "8080"
        ' 
        ' RelayBoings
        ' 
        RelayBoings.Location = New Point(326, 64)
        RelayBoings.Name = "RelayBoings"
        RelayBoings.Size = New Size(94, 29)
        RelayBoings.TabIndex = 11
        RelayBoings.Text = "Browse..."
        RelayBoings.UseVisualStyleBackColor = True
        ' 
        ' Path
        ' 
        Path.AutoSize = True
        Path.Location = New Point(47, 64)
        Path.Name = "Path"
        Path.Size = New Size(148, 20)
        Path.TabIndex = 12
        Path.Text = "Deafult: Temp Folder"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Path)
        Controls.Add(RelayBoings)
        Controls.Add(port)
        Controls.Add(Label4)
        Controls.Add(Chrome)
        Controls.Add(Edge)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(title)
        Controls.Add(website)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Web App Maker"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents website As TextBox
    Friend WithEvents title As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Edge As RadioButton
    Friend WithEvents Chrome As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents port As TextBox
    Friend WithEvents RelayBoings As Button
    Friend WithEvents Path As Label

End Class
