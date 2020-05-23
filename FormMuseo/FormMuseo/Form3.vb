﻿Imports Proyecto
Public Class formAnadir

    Private Sub formAnadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cbxMaterial.Items.Add(Escultura.Materiales.arcilla)
        Me.cbxMaterial.Items.Add(Escultura.Materiales.marmol)
        Me.cbxMaterial.Items.Add(Escultura.Materiales.piedra)
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        Dim titulo As String = textTitulo.Text
        Dim id As Integer = txtId.Text
        Dim anno As String = txtAnno.Text
        Dim autor As String = txtAutor.Text
        Dim altura As Integer = txtAltura.Text
        Dim anchura As Integer = txtAnchura.Text
        Dim soporte As String = txtSoporte.Text
        Dim pinturaTipo As String = txtPintura.Text

        Dim pintura As Pintura = New Pintura(titulo, id, anno, autor, altura, anchura, soporte, pinturaTipo)
        If formPrincipal.catalogo.addObra(pintura) = False Then
            MsgBox("Obra añadida con exitó")
        Else
            MsgBox("La obra ya se encuentra en el Catálogo")
        End If


    End Sub

    Private Sub btnAnadirE_Click(sender As Object, e As EventArgs) Handles btnAnadirE.Click
        Dim titulo As String = txtTituloE.Text
        Dim id As Integer = txtIdE.Text
        Dim anno As String = txtAnnoE.Text
        Dim autor As String = txtAutorE.Text
        Dim altura As Integer = txtAlturaE.Text
        Dim material As Escultura.Materiales = cbxMaterial.SelectedItem

        Dim escultura As Escultura = New Escultura(titulo, id, anno, autor, altura, material)
        If formPrincipal.catalogo.addObra(escultura) = False Then
            MsgBox("Obra añadida con exitó")
        Else
            MsgBox("La obra ya se encuentra en el Catálogo")
        End If

    End Sub
End Class