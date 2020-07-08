Public Class Form2
    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MasterDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ProductoTableAdapter.Fill(Me.MasterDataSet.producto)

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Me.ProductoTableAdapter.IngresoProducto(IdProductoTextBox.Text, NombreProductoTextBox.Text, DescripcionTextBox.Text)
        Me.ProductoTableAdapter.Fill(Me.MasterDataSet.producto)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.ProductoTableAdapter.EliminarProducto(IdProductoTextBox.Text)
        Me.ProductoTableAdapter.Fill(Me.MasterDataSet.producto)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.ProductoTableAdapter.ModificarProducto(IdProductoTextBox.Text, NombreProductoTextBox.Text, DescripcionTextBox.Text, IdProductoTextBox.Text)
        Me.ProductoTableAdapter.Fill(Me.MasterDataSet.producto)
    End Sub
End Class