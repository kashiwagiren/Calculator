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
        Display = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        ButtonAdd = New Button()
        ButtonSubtract = New Button()
        ButtonMultiply = New Button()
        ButtonDivide = New Button()
        Button0 = New Button()
        Dot = New Button()
        ButtonClear = New Button()
        ButtonEquals = New Button()
        SuspendLayout()
        ' 
        ' Display
        ' 
        Display.Enabled = False
        Display.Font = New Font("Visitor TT2 BRK", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Display.Location = New Point(168, 113)
        Display.Multiline = True
        Display.Name = "Display"
        Display.ReadOnly = True
        Display.Size = New Size(227, 30)
        Display.TabIndex = 0
        Display.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Visitor TT2 BRK", 20.25F)
        Button1.Location = New Point(135, 272)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 30)
        Button1.TabIndex = 1
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Visitor TT2 BRK", 20.25F)
        Button2.Location = New Point(241, 272)
        Button2.Name = "Button2"
        Button2.Size = New Size(90, 30)
        Button2.TabIndex = 2
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Visitor TT2 BRK", 20.25F)
        Button3.Location = New Point(348, 272)
        Button3.Name = "Button3"
        Button3.Size = New Size(90, 30)
        Button3.TabIndex = 3
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(135, 228)
        Button4.Name = "Button4"
        Button4.Size = New Size(90, 30)
        Button4.TabIndex = 4
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Visitor TT2 BRK", 20.25F)
        Button5.Location = New Point(241, 228)
        Button5.Name = "Button5"
        Button5.Size = New Size(90, 30)
        Button5.TabIndex = 5
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Visitor TT2 BRK", 20.25F)
        Button6.Location = New Point(348, 228)
        Button6.Name = "Button6"
        Button6.Size = New Size(90, 30)
        Button6.TabIndex = 6
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.Location = New Point(135, 181)
        Button7.Name = "Button7"
        Button7.Size = New Size(90, 30)
        Button7.TabIndex = 7
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button8.Location = New Point(241, 181)
        Button8.Name = "Button8"
        Button8.Size = New Size(90, 30)
        Button8.TabIndex = 8
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button9.Location = New Point(348, 181)
        Button9.Name = "Button9"
        Button9.Size = New Size(90, 30)
        Button9.TabIndex = 9
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' ButtonAdd
        ' 
        ButtonAdd.Font = New Font("Visitor TT2 BRK", 20.25F)
        ButtonAdd.Location = New Point(477, 181)
        ButtonAdd.Name = "ButtonAdd"
        ButtonAdd.Size = New Size(90, 30)
        ButtonAdd.TabIndex = 10
        ButtonAdd.Text = "+"
        ButtonAdd.UseVisualStyleBackColor = True
        ' 
        ' ButtonSubtract
        ' 
        ButtonSubtract.Font = New Font("Visitor TT2 BRK", 20.25F)
        ButtonSubtract.Location = New Point(586, 181)
        ButtonSubtract.Name = "ButtonSubtract"
        ButtonSubtract.Size = New Size(90, 30)
        ButtonSubtract.TabIndex = 11
        ButtonSubtract.Text = "-"
        ButtonSubtract.UseVisualStyleBackColor = True
        ' 
        ' ButtonMultiply
        ' 
        ButtonMultiply.Font = New Font("Visitor TT2 BRK", 20.25F)
        ButtonMultiply.Location = New Point(477, 228)
        ButtonMultiply.Name = "ButtonMultiply"
        ButtonMultiply.Size = New Size(90, 30)
        ButtonMultiply.TabIndex = 12
        ButtonMultiply.Text = "*"
        ButtonMultiply.UseVisualStyleBackColor = True
        ' 
        ' ButtonDivide
        ' 
        ButtonDivide.Font = New Font("Visitor TT2 BRK", 20.25F)
        ButtonDivide.Location = New Point(586, 228)
        ButtonDivide.Name = "ButtonDivide"
        ButtonDivide.Size = New Size(90, 30)
        ButtonDivide.TabIndex = 13
        ButtonDivide.Text = "/"
        ButtonDivide.UseVisualStyleBackColor = True
        ' 
        ' Button0
        ' 
        Button0.Font = New Font("Visitor TT2 BRK", 20.25F)
        Button0.Location = New Point(477, 272)
        Button0.Name = "Button0"
        Button0.Size = New Size(90, 30)
        Button0.TabIndex = 14
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = True
        ' 
        ' Dot
        ' 
        Dot.Font = New Font("Visitor TT2 BRK", 20.25F)
        Dot.Location = New Point(586, 272)
        Dot.Name = "Dot"
        Dot.Size = New Size(90, 30)
        Dot.TabIndex = 15
        Dot.Text = "."
        Dot.UseVisualStyleBackColor = True
        ' 
        ' ButtonClear
        ' 
        ButtonClear.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonClear.Location = New Point(477, 136)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.Size = New Size(90, 30)
        ButtonClear.TabIndex = 16
        ButtonClear.Text = "Clear"
        ButtonClear.UseVisualStyleBackColor = True
        ' 
        ' ButtonEquals
        ' 
        ButtonEquals.Font = New Font("Visitor TT2 BRK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonEquals.Location = New Point(586, 136)
        ButtonEquals.Name = "ButtonEquals"
        ButtonEquals.Size = New Size(90, 30)
        ButtonEquals.TabIndex = 17
        ButtonEquals.Text = "="
        ButtonEquals.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Untitled_design_2_
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonEquals)
        Controls.Add(ButtonClear)
        Controls.Add(Dot)
        Controls.Add(Button0)
        Controls.Add(ButtonDivide)
        Controls.Add(ButtonMultiply)
        Controls.Add(ButtonSubtract)
        Controls.Add(ButtonAdd)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Display)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Display As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonSubtract As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonDivide As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents Dot As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonEquals As Button

End Class
