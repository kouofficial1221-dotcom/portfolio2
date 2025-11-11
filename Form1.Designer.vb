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
        Btn_ShowMsg = New Button()
        SuspendLayout()
        ' 
        ' Btn_ShowMsg
        ' 
        Btn_ShowMsg.BackColor = Color.Fuchsia
        Btn_ShowMsg.Location = New Point(314, 119)
        Btn_ShowMsg.Name = "Btn_ShowMsg"
        Btn_ShowMsg.Size = New Size(148, 74)
        Btn_ShowMsg.TabIndex = 0
        Btn_ShowMsg.Text = "Click Me"
        Btn_ShowMsg.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_ShowMsg)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btn_ShowMsg As Button

End Class
