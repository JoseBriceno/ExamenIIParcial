<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdVentaLabel As System.Windows.Forms.Label
        Dim FechaVentaLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim IdProductoLabel As System.Windows.Forms.Label
        Me.MasterDataSet = New ExamenBri.masterDataSet()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New ExamenBri.masterDataSetTableAdapters.VentaTableAdapter()
        Me.TableAdapterManager = New ExamenBri.masterDataSetTableAdapters.TableAdapterManager()
        Me.VentaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdVentaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaVentaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.IdClienteTextBox = New System.Windows.Forms.TextBox()
        Me.IdProductoTextBox = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        IdVentaLabel = New System.Windows.Forms.Label()
        FechaVentaLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        IdClienteLabel = New System.Windows.Forms.Label()
        IdProductoLabel = New System.Windows.Forms.Label()
        CType(Me.MasterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdVentaLabel
        '
        IdVentaLabel.AutoSize = True
        IdVentaLabel.Location = New System.Drawing.Point(29, 104)
        IdVentaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdVentaLabel.Name = "IdVentaLabel"
        IdVentaLabel.Size = New System.Drawing.Size(49, 13)
        IdVentaLabel.TabIndex = 18
        IdVentaLabel.Text = "id Venta:"
        '
        'FechaVentaLabel
        '
        FechaVentaLabel.AutoSize = True
        FechaVentaLabel.Location = New System.Drawing.Point(29, 127)
        FechaVentaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FechaVentaLabel.Name = "FechaVentaLabel"
        FechaVentaLabel.Size = New System.Drawing.Size(68, 13)
        FechaVentaLabel.TabIndex = 20
        FechaVentaLabel.Text = "fecha Venta:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(29, 149)
        PrecioLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(39, 13)
        PrecioLabel.TabIndex = 22
        PrecioLabel.Text = "precio:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(29, 172)
        CantidadLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(51, 13)
        CantidadLabel.TabIndex = 24
        CantidadLabel.Text = "cantidad:"
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Location = New System.Drawing.Point(29, 195)
        IdClienteLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(53, 13)
        IdClienteLabel.TabIndex = 26
        IdClienteLabel.Text = "id Cliente:"
        '
        'IdProductoLabel
        '
        IdProductoLabel.AutoSize = True
        IdProductoLabel.Location = New System.Drawing.Point(29, 218)
        IdProductoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdProductoLabel.Name = "IdProductoLabel"
        IdProductoLabel.Size = New System.Drawing.Size(64, 13)
        IdProductoLabel.TabIndex = 28
        IdProductoLabel.Text = "id Producto:"
        '
        'MasterDataSet
        '
        Me.MasterDataSet.DataSetName = "masterDataSet"
        Me.MasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "Venta"
        Me.VentaBindingSource.DataSource = Me.MasterDataSet
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ExamenBri.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentaTableAdapter = Me.VentaTableAdapter
        '
        'VentaDataGridView
        '
        Me.VentaDataGridView.AutoGenerateColumns = False
        Me.VentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.VentaDataGridView.DataSource = Me.VentaBindingSource
        Me.VentaDataGridView.Location = New System.Drawing.Point(9, 275)
        Me.VentaDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.VentaDataGridView.Name = "VentaDataGridView"
        Me.VentaDataGridView.RowHeadersWidth = 51
        Me.VentaDataGridView.RowTemplate.Height = 24
        Me.VentaDataGridView.Size = New System.Drawing.Size(783, 179)
        Me.VentaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idVenta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idVenta"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fechaVenta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fechaVenta"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "idCliente"
        Me.DataGridViewTextBoxColumn5.HeaderText = "idCliente"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "idProducto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "idProducto"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "REGISTRO DE VENTA"
        '
        'IdVentaTextBox
        '
        Me.IdVentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "idVenta", True))
        Me.IdVentaTextBox.Location = New System.Drawing.Point(100, 101)
        Me.IdVentaTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IdVentaTextBox.Name = "IdVentaTextBox"
        Me.IdVentaTextBox.Size = New System.Drawing.Size(151, 20)
        Me.IdVentaTextBox.TabIndex = 19
        '
        'FechaVentaDateTimePicker
        '
        Me.FechaVentaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentaBindingSource, "fechaVenta", True))
        Me.FechaVentaDateTimePicker.Location = New System.Drawing.Point(100, 124)
        Me.FechaVentaDateTimePicker.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FechaVentaDateTimePicker.Name = "FechaVentaDateTimePicker"
        Me.FechaVentaDateTimePicker.Size = New System.Drawing.Size(151, 20)
        Me.FechaVentaDateTimePicker.TabIndex = 21
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(100, 147)
        Me.PrecioTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(151, 20)
        Me.PrecioTextBox.TabIndex = 23
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(100, 170)
        Me.CantidadTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(151, 20)
        Me.CantidadTextBox.TabIndex = 25
        '
        'IdClienteTextBox
        '
        Me.IdClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "idCliente", True))
        Me.IdClienteTextBox.Location = New System.Drawing.Point(100, 192)
        Me.IdClienteTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IdClienteTextBox.Name = "IdClienteTextBox"
        Me.IdClienteTextBox.Size = New System.Drawing.Size(151, 20)
        Me.IdClienteTextBox.TabIndex = 27
        '
        'IdProductoTextBox
        '
        Me.IdProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentaBindingSource, "idProducto", True))
        Me.IdProductoTextBox.Location = New System.Drawing.Point(100, 215)
        Me.IdProductoTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IdProductoTextBox.Name = "IdProductoTextBox"
        Me.IdProductoTextBox.Size = New System.Drawing.Size(151, 20)
        Me.IdProductoTextBox.TabIndex = 29
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(374, 149)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 19)
        Me.btnEliminar.TabIndex = 32
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(374, 187)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(95, 19)
        Me.btnEditar.TabIndex = 31
        Me.btnEditar.Text = "MODIFICAR"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(374, 110)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(95, 19)
        Me.btnIngresar.TabIndex = 30
        Me.btnIngresar.Text = "INGRESAR"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 502)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(IdVentaLabel)
        Me.Controls.Add(Me.IdVentaTextBox)
        Me.Controls.Add(FechaVentaLabel)
        Me.Controls.Add(Me.FechaVentaDateTimePicker)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(IdClienteLabel)
        Me.Controls.Add(Me.IdClienteTextBox)
        Me.Controls.Add(IdProductoLabel)
        Me.Controls.Add(Me.IdProductoTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VentaDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.MasterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MasterDataSet As masterDataSet
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As masterDataSetTableAdapters.VentaTableAdapter
    Friend WithEvents TableAdapterManager As masterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VentaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents IdVentaTextBox As TextBox
    Friend WithEvents FechaVentaDateTimePicker As DateTimePicker
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents IdClienteTextBox As TextBox
    Friend WithEvents IdProductoTextBox As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnIngresar As Button
End Class
