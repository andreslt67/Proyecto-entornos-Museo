<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEliminar
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.cbxObra = New System.Windows.Forms.ComboBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.Black
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(-7, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(383, 80)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Elimina una obra del catálogo"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(95, 98)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(167, 18)
        Me.lblId.TabIndex = 26
        Me.lblId.Text = "Selecciona una obra:"
        '
        'cbxObra
        '
        Me.cbxObra.FormattingEnabled = True
        Me.cbxObra.Location = New System.Drawing.Point(12, 140)
        Me.cbxObra.Name = "cbxObra"
        Me.cbxObra.Size = New System.Drawing.Size(353, 21)
        Me.cbxObra.TabIndex = 27
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Location = New System.Drawing.Point(119, 197)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(113, 23)
        Me.btnEliminar.TabIndex = 28
        Me.btnEliminar.Text = "Eliminar obra"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'formEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 244)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.cbxObra)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "formEliminar"
        Me.Text = "Elimina una obra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents cbxObra As System.Windows.Forms.ComboBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
