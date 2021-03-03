<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCari
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
        Me.dgvCari = New System.Windows.Forms.DataGridView()
        Me.btnGetir = New System.Windows.Forms.Button()
        CType(Me.dgvCari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCari
        '
        Me.dgvCari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCari.Location = New System.Drawing.Point(12, 12)
        Me.dgvCari.Name = "dgvCari"
        Me.dgvCari.Size = New System.Drawing.Size(776, 400)
        Me.dgvCari.TabIndex = 0
        '
        'btnGetir
        '
        Me.btnGetir.Location = New System.Drawing.Point(713, 418)
        Me.btnGetir.Name = "btnGetir"
        Me.btnGetir.Size = New System.Drawing.Size(75, 23)
        Me.btnGetir.TabIndex = 1
        Me.btnGetir.Text = "Getir"
        Me.btnGetir.UseVisualStyleBackColor = True
        '
        'frmCari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGetir)
        Me.Controls.Add(Me.dgvCari)
        Me.Name = "frmCari"
        Me.Text = "Web Service Client Demo"
        CType(Me.dgvCari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCari As DataGridView
    Friend WithEvents btnGetir As Button
End Class
