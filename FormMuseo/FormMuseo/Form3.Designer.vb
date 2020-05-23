<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAnadir
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
        Me.tab1 = New System.Windows.Forms.TabControl()
        Me.tabPage = New System.Windows.Forms.TabPage()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.textTitulo = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblAnno = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.lblAnchura = New System.Windows.Forms.Label()
        Me.lblSoporte = New System.Windows.Forms.Label()
        Me.lblPintura = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtAnno = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtAnchura = New System.Windows.Forms.TextBox()
        Me.txtSoporte = New System.Windows.Forms.TextBox()
        Me.txtPintura = New System.Windows.Forms.TextBox()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnAnadirE = New System.Windows.Forms.Button()
        Me.txtAlturaE = New System.Windows.Forms.TextBox()
        Me.txtAutorE = New System.Windows.Forms.TextBox()
        Me.txtAnnoE = New System.Windows.Forms.TextBox()
        Me.txtIdE = New System.Windows.Forms.TextBox()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.lblAlturaE = New System.Windows.Forms.Label()
        Me.lblAutorE = New System.Windows.Forms.Label()
        Me.lblAnnoE = New System.Windows.Forms.Label()
        Me.lblIdE = New System.Windows.Forms.Label()
        Me.txtTituloE = New System.Windows.Forms.TextBox()
        Me.lblTituloE = New System.Windows.Forms.Label()
        Me.cbxMaterial = New System.Windows.Forms.ComboBox()
        Me.tab1.SuspendLayout()
        Me.tabPage.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.Black
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(-1, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(674, 80)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Añade una obra"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tab1
        '
        Me.tab1.Controls.Add(Me.tabPage)
        Me.tab1.Controls.Add(Me.tabPage2)
        Me.tab1.Location = New System.Drawing.Point(4, 83)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedIndex = 0
        Me.tab1.Size = New System.Drawing.Size(669, 338)
        Me.tab1.TabIndex = 3
        '
        'tabPage
        '
        Me.tabPage.BackColor = System.Drawing.Color.White
        Me.tabPage.Controls.Add(Me.btnAnadir)
        Me.tabPage.Controls.Add(Me.txtPintura)
        Me.tabPage.Controls.Add(Me.txtSoporte)
        Me.tabPage.Controls.Add(Me.txtAnchura)
        Me.tabPage.Controls.Add(Me.txtAltura)
        Me.tabPage.Controls.Add(Me.txtAutor)
        Me.tabPage.Controls.Add(Me.txtAnno)
        Me.tabPage.Controls.Add(Me.txtId)
        Me.tabPage.Controls.Add(Me.lblPintura)
        Me.tabPage.Controls.Add(Me.lblSoporte)
        Me.tabPage.Controls.Add(Me.lblAnchura)
        Me.tabPage.Controls.Add(Me.lblAltura)
        Me.tabPage.Controls.Add(Me.lblAutor)
        Me.tabPage.Controls.Add(Me.lblAnno)
        Me.tabPage.Controls.Add(Me.lblId)
        Me.tabPage.Controls.Add(Me.textTitulo)
        Me.tabPage.Controls.Add(Me.lblTitulo)
        Me.tabPage.Location = New System.Drawing.Point(4, 22)
        Me.tabPage.Name = "tabPage"
        Me.tabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage.Size = New System.Drawing.Size(661, 312)
        Me.tabPage.TabIndex = 0
        Me.tabPage.Text = "Añadir Pintura"
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.cbxMaterial)
        Me.tabPage2.Controls.Add(Me.btnAnadirE)
        Me.tabPage2.Controls.Add(Me.txtAlturaE)
        Me.tabPage2.Controls.Add(Me.txtAutorE)
        Me.tabPage2.Controls.Add(Me.txtAnnoE)
        Me.tabPage2.Controls.Add(Me.txtIdE)
        Me.tabPage2.Controls.Add(Me.lblMaterial)
        Me.tabPage2.Controls.Add(Me.lblAlturaE)
        Me.tabPage2.Controls.Add(Me.lblAutorE)
        Me.tabPage2.Controls.Add(Me.lblAnnoE)
        Me.tabPage2.Controls.Add(Me.lblIdE)
        Me.tabPage2.Controls.Add(Me.txtTituloE)
        Me.tabPage2.Controls.Add(Me.lblTituloE)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(661, 312)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Añadir Escultura"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(24, 19)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(148, 18)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Introduce un título:"
        '
        'textTitulo
        '
        Me.textTitulo.Location = New System.Drawing.Point(273, 20)
        Me.textTitulo.Name = "textTitulo"
        Me.textTitulo.Size = New System.Drawing.Size(365, 20)
        Me.textTitulo.TabIndex = 3
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(24, 53)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(127, 18)
        Me.lblId.TabIndex = 4
        Me.lblId.Text = "Introduce un ID:"
        '
        'lblAnno
        '
        Me.lblAnno.AutoSize = True
        Me.lblAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnno.Location = New System.Drawing.Point(24, 84)
        Me.lblAnno.Name = "lblAnno"
        Me.lblAnno.Size = New System.Drawing.Size(178, 18)
        Me.lblAnno.TabIndex = 5
        Me.lblAnno.Text = "¿En que año se creó?:"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutor.Location = New System.Drawing.Point(24, 114)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(234, 18)
        Me.lblAutor.TabIndex = 6
        Me.lblAutor.Text = "Introduce el nombre del autor:"
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltura.Location = New System.Drawing.Point(24, 144)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(162, 18)
        Me.lblAltura.TabIndex = 7
        Me.lblAltura.Text = "Introduce una altura:"
        '
        'lblAnchura
        '
        Me.lblAnchura.AutoSize = True
        Me.lblAnchura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnchura.Location = New System.Drawing.Point(24, 172)
        Me.lblAnchura.Name = "lblAnchura"
        Me.lblAnchura.Size = New System.Drawing.Size(180, 18)
        Me.lblAnchura.TabIndex = 8
        Me.lblAnchura.Text = "Introduce una anchura:"
        '
        'lblSoporte
        '
        Me.lblSoporte.AutoSize = True
        Me.lblSoporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoporte.Location = New System.Drawing.Point(24, 204)
        Me.lblSoporte.Name = "lblSoporte"
        Me.lblSoporte.Size = New System.Drawing.Size(164, 18)
        Me.lblSoporte.TabIndex = 9
        Me.lblSoporte.Text = "Introduce el soporte:"
        '
        'lblPintura
        '
        Me.lblPintura.AutoSize = True
        Me.lblPintura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPintura.Location = New System.Drawing.Point(24, 237)
        Me.lblPintura.Name = "lblPintura"
        Me.lblPintura.Size = New System.Drawing.Size(213, 18)
        Me.lblPintura.TabIndex = 10
        Me.lblPintura.Text = "Introduce el tipo de pintura:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(273, 54)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(365, 20)
        Me.txtId.TabIndex = 11
        '
        'txtAnno
        '
        Me.txtAnno.Location = New System.Drawing.Point(273, 84)
        Me.txtAnno.Name = "txtAnno"
        Me.txtAnno.Size = New System.Drawing.Size(365, 20)
        Me.txtAnno.TabIndex = 12
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(273, 115)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(365, 20)
        Me.txtAutor.TabIndex = 13
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(273, 145)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(365, 20)
        Me.txtAltura.TabIndex = 14
        '
        'txtAnchura
        '
        Me.txtAnchura.Location = New System.Drawing.Point(273, 173)
        Me.txtAnchura.Name = "txtAnchura"
        Me.txtAnchura.Size = New System.Drawing.Size(365, 20)
        Me.txtAnchura.TabIndex = 15
        '
        'txtSoporte
        '
        Me.txtSoporte.Location = New System.Drawing.Point(273, 205)
        Me.txtSoporte.Name = "txtSoporte"
        Me.txtSoporte.Size = New System.Drawing.Size(365, 20)
        Me.txtSoporte.TabIndex = 16
        '
        'txtPintura
        '
        Me.txtPintura.Location = New System.Drawing.Point(273, 238)
        Me.txtPintura.Name = "txtPintura"
        Me.txtPintura.Size = New System.Drawing.Size(365, 20)
        Me.txtPintura.TabIndex = 17
        '
        'btnAnadir
        '
        Me.btnAnadir.BackColor = System.Drawing.SystemColors.Control
        Me.btnAnadir.ForeColor = System.Drawing.Color.Black
        Me.btnAnadir.Location = New System.Drawing.Point(262, 272)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(113, 23)
        Me.btnAnadir.TabIndex = 18
        Me.btnAnadir.Text = "Añadir Pintura"
        Me.btnAnadir.UseVisualStyleBackColor = False
        '
        'btnAnadirE
        '
        Me.btnAnadirE.BackColor = System.Drawing.SystemColors.Control
        Me.btnAnadirE.ForeColor = System.Drawing.Color.Black
        Me.btnAnadirE.Location = New System.Drawing.Point(260, 240)
        Me.btnAnadirE.Name = "btnAnadirE"
        Me.btnAnadirE.Size = New System.Drawing.Size(113, 23)
        Me.btnAnadirE.TabIndex = 35
        Me.btnAnadirE.Text = "Añadir Escultura"
        Me.btnAnadirE.UseVisualStyleBackColor = False
        '
        'txtAlturaE
        '
        Me.txtAlturaE.Location = New System.Drawing.Point(275, 144)
        Me.txtAlturaE.Name = "txtAlturaE"
        Me.txtAlturaE.Size = New System.Drawing.Size(365, 20)
        Me.txtAlturaE.TabIndex = 31
        '
        'txtAutorE
        '
        Me.txtAutorE.Location = New System.Drawing.Point(275, 114)
        Me.txtAutorE.Name = "txtAutorE"
        Me.txtAutorE.Size = New System.Drawing.Size(365, 20)
        Me.txtAutorE.TabIndex = 30
        '
        'txtAnnoE
        '
        Me.txtAnnoE.Location = New System.Drawing.Point(275, 83)
        Me.txtAnnoE.Name = "txtAnnoE"
        Me.txtAnnoE.Size = New System.Drawing.Size(365, 20)
        Me.txtAnnoE.TabIndex = 29
        '
        'txtIdE
        '
        Me.txtIdE.Location = New System.Drawing.Point(275, 53)
        Me.txtIdE.Name = "txtIdE"
        Me.txtIdE.Size = New System.Drawing.Size(365, 20)
        Me.txtIdE.TabIndex = 28
        '
        'lblMaterial
        '
        Me.lblMaterial.AutoSize = True
        Me.lblMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterial.Location = New System.Drawing.Point(26, 171)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(184, 18)
        Me.lblMaterial.TabIndex = 25
        Me.lblMaterial.Text = "Selecciona un material:"
        '
        'lblAlturaE
        '
        Me.lblAlturaE.AutoSize = True
        Me.lblAlturaE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlturaE.Location = New System.Drawing.Point(26, 143)
        Me.lblAlturaE.Name = "lblAlturaE"
        Me.lblAlturaE.Size = New System.Drawing.Size(162, 18)
        Me.lblAlturaE.TabIndex = 24
        Me.lblAlturaE.Text = "Introduce una altura:"
        '
        'lblAutorE
        '
        Me.lblAutorE.AutoSize = True
        Me.lblAutorE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutorE.Location = New System.Drawing.Point(26, 113)
        Me.lblAutorE.Name = "lblAutorE"
        Me.lblAutorE.Size = New System.Drawing.Size(234, 18)
        Me.lblAutorE.TabIndex = 23
        Me.lblAutorE.Text = "Introduce el nombre del autor:"
        '
        'lblAnnoE
        '
        Me.lblAnnoE.AutoSize = True
        Me.lblAnnoE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnoE.Location = New System.Drawing.Point(26, 83)
        Me.lblAnnoE.Name = "lblAnnoE"
        Me.lblAnnoE.Size = New System.Drawing.Size(178, 18)
        Me.lblAnnoE.TabIndex = 22
        Me.lblAnnoE.Text = "¿En que año se creó?:"
        '
        'lblIdE
        '
        Me.lblIdE.AutoSize = True
        Me.lblIdE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdE.Location = New System.Drawing.Point(26, 52)
        Me.lblIdE.Name = "lblIdE"
        Me.lblIdE.Size = New System.Drawing.Size(127, 18)
        Me.lblIdE.TabIndex = 21
        Me.lblIdE.Text = "Introduce un ID:"
        '
        'txtTituloE
        '
        Me.txtTituloE.Location = New System.Drawing.Point(275, 19)
        Me.txtTituloE.Name = "txtTituloE"
        Me.txtTituloE.Size = New System.Drawing.Size(365, 20)
        Me.txtTituloE.TabIndex = 20
        '
        'lblTituloE
        '
        Me.lblTituloE.AutoSize = True
        Me.lblTituloE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloE.Location = New System.Drawing.Point(26, 18)
        Me.lblTituloE.Name = "lblTituloE"
        Me.lblTituloE.Size = New System.Drawing.Size(148, 18)
        Me.lblTituloE.TabIndex = 19
        Me.lblTituloE.Text = "Introduce un título:"
        '
        'cbxMaterial
        '
        Me.cbxMaterial.FormattingEnabled = True
        Me.cbxMaterial.Location = New System.Drawing.Point(275, 172)
        Me.cbxMaterial.Name = "cbxMaterial"
        Me.cbxMaterial.Size = New System.Drawing.Size(365, 21)
        Me.cbxMaterial.TabIndex = 36
        '
        'formAnadir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(672, 420)
        Me.Controls.Add(Me.tab1)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "formAnadir"
        Me.Text = "Añade una obra"
        Me.tab1.ResumeLayout(False)
        Me.tabPage.ResumeLayout(False)
        Me.tabPage.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents tab1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPage As System.Windows.Forms.TabPage
    Friend WithEvents tabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblAltura As System.Windows.Forms.Label
    Friend WithEvents lblAutor As System.Windows.Forms.Label
    Friend WithEvents lblAnno As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents textTitulo As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtPintura As System.Windows.Forms.TextBox
    Friend WithEvents txtSoporte As System.Windows.Forms.TextBox
    Friend WithEvents txtAnchura As System.Windows.Forms.TextBox
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents txtAnno As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lblPintura As System.Windows.Forms.Label
    Friend WithEvents lblSoporte As System.Windows.Forms.Label
    Friend WithEvents lblAnchura As System.Windows.Forms.Label
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents btnAnadirE As System.Windows.Forms.Button
    Friend WithEvents txtAlturaE As System.Windows.Forms.TextBox
    Friend WithEvents txtAutorE As System.Windows.Forms.TextBox
    Friend WithEvents txtAnnoE As System.Windows.Forms.TextBox
    Friend WithEvents txtIdE As System.Windows.Forms.TextBox
    Friend WithEvents lblMaterial As System.Windows.Forms.Label
    Friend WithEvents lblAlturaE As System.Windows.Forms.Label
    Friend WithEvents lblAutorE As System.Windows.Forms.Label
    Friend WithEvents lblAnnoE As System.Windows.Forms.Label
    Friend WithEvents lblIdE As System.Windows.Forms.Label
    Friend WithEvents txtTituloE As System.Windows.Forms.TextBox
    Friend WithEvents lblTituloE As System.Windows.Forms.Label
    Friend WithEvents cbxMaterial As System.Windows.Forms.ComboBox
End Class
