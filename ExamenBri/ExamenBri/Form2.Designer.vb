<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim IdProductoLabel As System.Windows.Forms.Label
        Dim NombreProductoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Me.MasterDataSet = New ExamenBri.masterDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New ExamenBri.masterDataSetTableAdapters.productoTableAdapter()
        Me.TableAdapterManager = New ExamenBri.masterDataSetTableAdapters.TableAdapterManager()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreProductoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        IdProductoLabel = New System.Windows.Forms.Label()
        NombreProductoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.MasterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdProductoLabel
        '
        IdProductoLabel.AutoSize = True
        IdProductoLabel.Location = New System.Drawing.Point(19, 68)
        IdProductoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdProductoLabel.Name = "IdProductoLabel"
        IdProductoLabel.Size = New System.Drawing.Size(64, 13)
        IdProductoLabel.TabIndex = 2
        IdProductoLabel.Text = "id Producto:"
        '
        'NombreProductoLabel
        '
        NombreProductoLabel.AutoSize = True
        NombreProductoLabel.Location = New System.Drawing.Point(19, 91)
        NombreProductoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NombreProductoLabel.Name = "NombreProductoLabel"
        NombreProductoLabel.Size = New System.Drawing.Size(91, 13)
        NombreProductoLabel.TabIndex = 4
        NombreProductoLabel.Text = "nombre Producto:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(19, 114)
        DescripcionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(64, 13)
        DescripcionLabel.TabIndex = 6
        DescripcionLabel.Text = "descripcion:"
        '
        'MasterDataSet
        '
        Me.MasterDataSet.DataSetName = "masterDataSet"
        Me.MasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.MasterDataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.UpdateOrder = ExamenBri.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(21, 161)
        Me.ProductoDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.RowHeadersWidth = 51
        Me.ProductoDataGridView.RowTemplate.Height = 24
        Me.ProductoDataGridView.Size = New System.Drawing.Size(354, 179)
        Me.ProductoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idProducto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idProducto"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombreProducto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombreProducto"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'IdProductoTextBox
        '
        Me.IdProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProducto", True))
        Me.IdProductoTextBox.Location = New System.Drawing.Point(114, 66)
        Me.IdProductoTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IdProductoTextBox.Name = "IdProductoTextBox"
        Me.IdProductoTextBox.Size = New System.Drawing.Size(76, 20)
        Me.IdProductoTextBox.TabIndex = 3
        '
        'NombreProductoTextBox
        '
        Me.NombreProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "nombreProducto", True))
        Me.NombreProductoTextBox.Location = New System.Drawing.Point(114, 89)
        Me.NombreProductoTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NombreProductoTextBox.Name = "NombreProductoTextBox"
        Me.NombreProductoTextBox.Size = New System.Drawing.Size(76, 20)
        Me.NombreProductoTextBox.TabIndex = 5
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(114, 111)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(76, 20)
        Me.DescripcionTextBox.TabIndex = 7
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(226, 87)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(95, 19)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(226, 124)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(95, 19)
        Me.btnEditar.TabIndex = 15
        Me.btnEditar.Text = "MODIFICAR"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(226, 48)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(95, 19)
        Me.btnIngresar.TabIndex = 14
        Me.btnIngresar.Text = "INGRESAR"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "REGISTRO DE PRODUCTO"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 367)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(IdProductoLabel)
        Me.Controls.Add(Me.IdProductoTextBox)
        Me.Controls.Add(NombreProductoLabel)
        Me.Controls.Add(Me.NombreProductoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.MasterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MasterDataSet As masterDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As masterDataSetTableAdapters.productoTableAdapter
    Friend WithEvents TableAdapterManager As masterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents IdProductoTextBox As TextBox
    Friend WithEvents NombreProductoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label1 As Label
End Class
