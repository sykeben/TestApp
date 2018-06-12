<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.HelloWorldText = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.InfoButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HelloWorldText
        '
        Me.HelloWorldText.AutoSize = True
        Me.HelloWorldText.BackColor = System.Drawing.Color.Transparent
        Me.HelloWorldText.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelloWorldText.ForeColor = System.Drawing.Color.White
        Me.HelloWorldText.Location = New System.Drawing.Point(3, 2)
        Me.HelloWorldText.Name = "HelloWorldText"
        Me.HelloWorldText.Size = New System.Drawing.Size(409, 86)
        Me.HelloWorldText.TabIndex = 0
        Me.HelloWorldText.Text = "Hello, World!"
        '
        'CloseButton
        '
        Me.CloseButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(373, 88)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(61, 27)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'InfoButton
        '
        Me.InfoButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InfoButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.InfoButton.Location = New System.Drawing.Point(1, 92)
        Me.InfoButton.Name = "InfoButton"
        Me.InfoButton.Size = New System.Drawing.Size(21, 23)
        Me.InfoButton.TabIndex = 2
        Me.InfoButton.Text = "i"
        Me.InfoButton.UseVisualStyleBackColor = False
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TestApp.My.Resources.Resources.Woods
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(435, 116)
        Me.Controls.Add(Me.InfoButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.HelloWorldText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HelloWorldText As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents InfoButton As Button
End Class
