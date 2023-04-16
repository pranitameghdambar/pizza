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
        tabs = New TabControl()
        TabPage1 = New TabPage()
        Button1 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        TabPage2 = New TabPage()
        Button6 = New Button()
        TabPage3 = New TabPage()
        tabs.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabs
        ' 
        tabs.Controls.Add(TabPage1)
        tabs.Controls.Add(TabPage2)
        tabs.Controls.Add(TabPage3)
        tabs.Location = New Point(12, 12)
        tabs.Name = "tabs"
        tabs.SelectedIndex = 0
        tabs.Size = New Size(860, 368)
        tabs.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(Button3)
        TabPage1.Controls.Add(Button2)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(852, 340)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(142, 46)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Button4"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(142, 172)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 1
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(144, 101)
        Button2.Name = "Button2"
        Button2.Size = New Size(73, 49)
        Button2.TabIndex = 0
        Button2.Text = "btn2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Button6)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(852, 340)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(139, 144)
        Button6.Name = "Button6"
        Button6.Size = New Size(44, 77)
        Button6.TabIndex = 0
        Button6.Text = "new page"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(852, 340)
        TabPage3.TabIndex = 2
        TabPage3.Text = "TabPage3"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 392)
        Controls.Add(tabs)
        Name = "Form1"
        Text = "Form1"
        tabs.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents tabs As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button6 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TabPage3 As TabPage
End Class
