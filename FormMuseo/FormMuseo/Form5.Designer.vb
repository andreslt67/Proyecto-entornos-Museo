<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBuscar
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cbxObra = New System.Windows.Forms.ComboBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Location = New System.Drawing.Point(123, 207)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(113, 23)
        Me.btnBuscar.TabIndex = 32
        Me.btnBuscar.Text = "Mostrar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cbxObra
        '
        Me.cbxObra.FormattingEnabled = True
        Me.cbxObra.Location = New System.Drawing.Point(12, 150)
        Me.cbxObra.Name = "cbxObra"
        Me.cbxObra.Size = New System.Drawing.Size(353, 21)
        Me.cbxObra.TabIndex = 31
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(100, 99)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(167, 18)
        Me.lblId.TabIndex = 30
        Me.lblId.Text = "Selecciona una obra:"
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.Black
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(-3, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(383, 80)
        Me.lblHeader.TabIndex = 29
        Me.lblHeader.Text = "Busca una obra del catálogo"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 261)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cbxObra)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "formBuscar"
        Me.Text = "Busca una Obra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cbxObra As System.Windows.Forms.ComboBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
End Class
