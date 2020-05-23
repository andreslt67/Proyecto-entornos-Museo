<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPrincipal
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnMostrarLista = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnMasAlta = New System.Windows.Forms.Button()
        Me.btnSuperficie = New System.Windows.Forms.Button()
        Me.lblPanel = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.Black
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(332, 80)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Bienvenido/a al Museo"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(50, 95)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(228, 18)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Elija una opción del Catálogo"
        '
        'btnMostrarLista
        '
        Me.btnMostrarLista.BackColor = System.Drawing.SystemColors.Control
        Me.btnMostrarLista.ForeColor = System.Drawing.Color.Black
        Me.btnMostrarLista.Location = New System.Drawing.Point(101, 136)
        Me.btnMostrarLista.Name = "btnMostrarLista"
        Me.btnMostrarLista.Size = New System.Drawing.Size(113, 23)
        Me.btnMostrarLista.TabIndex = 2
        Me.btnMostrarLista.Text = "Mostrar Catálogo"
        Me.btnMostrarLista.UseVisualStyleBackColor = False
        '
        'btnAñadir
        '
        Me.btnAñadir.BackColor = System.Drawing.SystemColors.Control
        Me.btnAñadir.ForeColor = System.Drawing.Color.Black
        Me.btnAñadir.Location = New System.Drawing.Point(101, 180)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(113, 23)
        Me.btnAñadir.TabIndex = 3
        Me.btnAñadir.Text = "Añadir obra"
        Me.btnAñadir.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Location = New System.Drawing.Point(101, 222)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(113, 23)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar obra"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Location = New System.Drawing.Point(101, 265)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(113, 23)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar obra"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Black
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel1.Controls.Add(Me.btnMasAlta)
        Me.panel1.Controls.Add(Me.btnSuperficie)
        Me.panel1.Controls.Add(Me.lblPanel)
        Me.panel1.Location = New System.Drawing.Point(-3, 306)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(342, 100)
        Me.panel1.TabIndex = 6
        '
        'btnMasAlta
        '
        Me.btnMasAlta.BackColor = System.Drawing.SystemColors.Control
        Me.btnMasAlta.ForeColor = System.Drawing.Color.Black
        Me.btnMasAlta.Location = New System.Drawing.Point(182, 43)
        Me.btnMasAlta.Name = "btnMasAlta"
        Me.btnMasAlta.Size = New System.Drawing.Size(113, 23)
        Me.btnMasAlta.TabIndex = 8
        Me.btnMasAlta.Text = "Record altura"
        Me.btnMasAlta.UseVisualStyleBackColor = False
        '
        'btnSuperficie
        '
        Me.btnSuperficie.BackColor = System.Drawing.SystemColors.Control
        Me.btnSuperficie.ForeColor = System.Drawing.Color.Black
        Me.btnSuperficie.Location = New System.Drawing.Point(33, 43)
        Me.btnSuperficie.Name = "btnSuperficie"
        Me.btnSuperficie.Size = New System.Drawing.Size(113, 23)
        Me.btnSuperficie.TabIndex = 7
        Me.btnSuperficie.Text = "Superficie"
        Me.btnSuperficie.UseVisualStyleBackColor = False
        '
        'lblPanel
        '
        Me.lblPanel.AutoSize = True
        Me.lblPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanel.ForeColor = System.Drawing.Color.White
        Me.lblPanel.Location = New System.Drawing.Point(99, 11)
        Me.lblPanel.Name = "lblPanel"
        Me.lblPanel.Size = New System.Drawing.Size(126, 13)
        Me.lblPanel.TabIndex = 0
        Me.lblPanel.Text = "Te puede interesar..."
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Location = New System.Drawing.Point(101, 436)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(113, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'formPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(332, 486)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.btnMostrarLista)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblHeader)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "formPrincipal"
        Me.Text = "Catálogo del museo"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnMostrarLista As System.Windows.Forms.Button
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnMasAlta As System.Windows.Forms.Button
    Friend WithEvents btnSuperficie As System.Windows.Forms.Button
    Friend WithEvents lblPanel As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class
