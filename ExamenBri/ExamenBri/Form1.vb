Public Class Form1
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MasterDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClienteTableAdapter.Fill(Me.MasterDataSet.cliente)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Me.ClienteTableAdapter.AgregarCliente(IdClienteTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, DireccionTextBox.Text)
        Me.ClienteTableAdapter.Fill(Me.MasterDataSet.cliente)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Me.ClienteTableAdapter.ModificarCliente(IdClienteTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text, DireccionTextBox.Text, IdClienteTextBox.Text)
        Me.ClienteTableAdapter.Fill(Me.MasterDataSet.cliente)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.ClienteTableAdapter.EliminarCliente(IdClienteTextBox.Text)
        Me.ClienteTableAdapter.Fill(Me.MasterDataSet.cliente)

    End Sub

End Class
