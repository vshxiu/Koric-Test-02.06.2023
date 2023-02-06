<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lstIce = New System.Windows.Forms.ListBox()
        Me.picIce = New System.Windows.Forms.PictureBox()
        CType(Me.picIce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstIce
        '
        Me.lstIce.FormattingEnabled = True
        Me.lstIce.Items.AddRange(New Object() {"Mango", "Boba", "Green", "Caramel", "Orange"})
        Me.lstIce.Location = New System.Drawing.Point(41, 54)
        Me.lstIce.Name = "lstIce"
        Me.lstIce.Size = New System.Drawing.Size(120, 95)
        Me.lstIce.TabIndex = 1
        '
        'picIce
        '
        Me.picIce.Location = New System.Drawing.Point(228, 54)
        Me.picIce.Name = "picIce"
        Me.picIce.Size = New System.Drawing.Size(120, 95)
        Me.picIce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIce.TabIndex = 2
        Me.picIce.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 209)
        Me.Controls.Add(Me.picIce)
        Me.Controls.Add(Me.lstIce)
        Me.Name = "frmMain"
        Me.Text = "Ice Cream!"
        CType(Me.picIce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstIce As ListBox
    Friend WithEvents picIce As PictureBox
End Class
