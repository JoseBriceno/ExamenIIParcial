Public Class Form3
    Private Sub VentaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VentaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MasterDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VentaTableAdapter.Fill(Me.MasterDataSet.Venta)

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Me.VentaTableAdapter.IngresoVenta(IdProductoTextBox.Text, FechaVentaDateTimePicker.CustomFormat, PrecioTextBox.Text, CantidadTextBox.Text, IdClienteTextBox.Text, IdProductoTextBox.Text)
        Me.VentaTableAdapter.Fill(Me.MasterDataSet.Venta)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.VentaTableAdapter.EliminarVenta(IdProductoTextBox.Text)
        Me.VentaTableAdapter.Fill(Me.MasterDataSet.Venta)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.VentaTableAdapter.ModificarVenta(IdProductoTextBox.Text, FechaVentaDateTimePicker.CustomFormat, PrecioTextBox.Text, CantidadTextBox.Text, IdClienteTextBox.Text, IdProductoTextBox.Text, IdVentaTextBox.Text)
        Me.VentaTableAdapter.Fill(Me.MasterDataSet.Venta)
    End Sub

    Private Sub VentaBindingNavigator_RefreshItems(sender As Object, e As EventArgs)

    End Sub
End Class