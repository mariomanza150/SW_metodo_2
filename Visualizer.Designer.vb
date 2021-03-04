<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visualizer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Visualizer))
        Dim IDLabel1 As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim RazaLabel As System.Windows.Forms.Label
        Dim BandoLabel As System.Windows.Forms.Label
        Dim EdadLabel As System.Windows.Forms.Label
        Me.bttn_exit = New System.Windows.Forms.Button()
        Me.SW_dataDataSet = New SW_metodo_2.SW_dataDataSet()
        Me.CharactersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CharactersTableAdapter = New SW_metodo_2.SW_dataDataSetTableAdapters.CharactersTableAdapter()
        Me.TableAdapterManager = New SW_metodo_2.SW_dataDataSetTableAdapters.TableAdapterManager()
        Me.CharactersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CharactersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.RazaTextBox = New System.Windows.Forms.TextBox()
        Me.BandoTextBox = New System.Windows.Forms.TextBox()
        Me.EdadTextBox = New System.Windows.Forms.TextBox()
        Me.ImagenPictureBox = New System.Windows.Forms.PictureBox()
        IDLabel1 = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        RazaLabel = New System.Windows.Forms.Label()
        BandoLabel = New System.Windows.Forms.Label()
        EdadLabel = New System.Windows.Forms.Label()
        CType(Me.SW_dataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharactersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharactersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CharactersBindingNavigator.SuspendLayout()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttn_exit
        '
        Me.bttn_exit.Location = New System.Drawing.Point(575, 351)
        Me.bttn_exit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bttn_exit.Name = "bttn_exit"
        Me.bttn_exit.Size = New System.Drawing.Size(120, 62)
        Me.bttn_exit.TabIndex = 27
        Me.bttn_exit.Text = "Salir"
        Me.bttn_exit.UseVisualStyleBackColor = True
        '
        'SW_dataDataSet
        '
        Me.SW_dataDataSet.DataSetName = "SW_dataDataSet"
        Me.SW_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CharactersBindingSource
        '
        Me.CharactersBindingSource.DataMember = "Characters"
        Me.CharactersBindingSource.DataSource = Me.SW_dataDataSet
        '
        'CharactersTableAdapter
        '
        Me.CharactersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CharactersTableAdapter = Me.CharactersTableAdapter
        Me.TableAdapterManager.UpdateOrder = SW_metodo_2.SW_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CharactersBindingNavigator
        '
        Me.CharactersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CharactersBindingNavigator.BindingSource = Me.CharactersBindingSource
        Me.CharactersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CharactersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CharactersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CharactersBindingNavigatorSaveItem})
        Me.CharactersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CharactersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CharactersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CharactersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CharactersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CharactersBindingNavigator.Name = "CharactersBindingNavigator"
        Me.CharactersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CharactersBindingNavigator.Size = New System.Drawing.Size(844, 25)
        Me.CharactersBindingNavigator.TabIndex = 28
        Me.CharactersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CharactersBindingNavigatorSaveItem
        '
        Me.CharactersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CharactersBindingNavigatorSaveItem.Image = CType(resources.GetObject("CharactersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CharactersBindingNavigatorSaveItem.Name = "CharactersBindingNavigatorSaveItem"
        Me.CharactersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CharactersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel1
        '
        IDLabel1.AutoSize = True
        IDLabel1.Location = New System.Drawing.Point(411, 62)
        IDLabel1.Name = "IDLabel1"
        IDLabel1.Size = New System.Drawing.Size(30, 20)
        IDLabel1.TabIndex = 29
        IDLabel1.Text = "ID:"
        '
        'IDTextBox1
        '
        Me.IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CharactersBindingSource, "ID", True))
        Me.IDTextBox1.Location = New System.Drawing.Point(486, 59)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(262, 26)
        Me.IDTextBox1.TabIndex = 30
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(411, 94)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(69, 20)
        NombreLabel.TabIndex = 31
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CharactersBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(486, 91)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(262, 26)
        Me.NombreTextBox.TabIndex = 32
        '
        'RazaLabel
        '
        RazaLabel.AutoSize = True
        RazaLabel.Location = New System.Drawing.Point(411, 126)
        RazaLabel.Name = "RazaLabel"
        RazaLabel.Size = New System.Drawing.Size(51, 20)
        RazaLabel.TabIndex = 33
        RazaLabel.Text = "Raza:"
        '
        'RazaTextBox
        '
        Me.RazaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CharactersBindingSource, "Raza", True))
        Me.RazaTextBox.Location = New System.Drawing.Point(486, 123)
        Me.RazaTextBox.Name = "RazaTextBox"
        Me.RazaTextBox.Size = New System.Drawing.Size(262, 26)
        Me.RazaTextBox.TabIndex = 34
        '
        'BandoLabel
        '
        BandoLabel.AutoSize = True
        BandoLabel.Location = New System.Drawing.Point(411, 158)
        BandoLabel.Name = "BandoLabel"
        BandoLabel.Size = New System.Drawing.Size(60, 20)
        BandoLabel.TabIndex = 35
        BandoLabel.Text = "Bando:"
        '
        'BandoTextBox
        '
        Me.BandoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CharactersBindingSource, "Bando", True))
        Me.BandoTextBox.Location = New System.Drawing.Point(486, 155)
        Me.BandoTextBox.Name = "BandoTextBox"
        Me.BandoTextBox.Size = New System.Drawing.Size(262, 26)
        Me.BandoTextBox.TabIndex = 36
        '
        'EdadLabel
        '
        EdadLabel.AutoSize = True
        EdadLabel.Location = New System.Drawing.Point(411, 190)
        EdadLabel.Name = "EdadLabel"
        EdadLabel.Size = New System.Drawing.Size(51, 20)
        EdadLabel.TabIndex = 37
        EdadLabel.Text = "Edad:"
        '
        'EdadTextBox
        '
        Me.EdadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CharactersBindingSource, "Edad", True))
        Me.EdadTextBox.Location = New System.Drawing.Point(486, 187)
        Me.EdadTextBox.Name = "EdadTextBox"
        Me.EdadTextBox.Size = New System.Drawing.Size(262, 26)
        Me.EdadTextBox.TabIndex = 38
        '
        'ImagenPictureBox
        '
        Me.ImagenPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CharactersBindingSource, "Imagen", True))
        Me.ImagenPictureBox.Location = New System.Drawing.Point(38, 59)
        Me.ImagenPictureBox.Name = "ImagenPictureBox"
        Me.ImagenPictureBox.Size = New System.Drawing.Size(332, 354)
        Me.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenPictureBox.TabIndex = 39
        Me.ImagenPictureBox.TabStop = False
        '
        'Visualizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 464)
        Me.Controls.Add(Me.ImagenPictureBox)
        Me.Controls.Add(IDLabel1)
        Me.Controls.Add(Me.IDTextBox1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(RazaLabel)
        Me.Controls.Add(Me.RazaTextBox)
        Me.Controls.Add(BandoLabel)
        Me.Controls.Add(Me.BandoTextBox)
        Me.Controls.Add(EdadLabel)
        Me.Controls.Add(Me.EdadTextBox)
        Me.Controls.Add(Me.CharactersBindingNavigator)
        Me.Controls.Add(Me.bttn_exit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Visualizer"
        Me.Text = "Form1"
        CType(Me.SW_dataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharactersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharactersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CharactersBindingNavigator.ResumeLayout(False)
        Me.CharactersBindingNavigator.PerformLayout()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttn_exit As Button
    Friend WithEvents SW_dataDataSet As SW_dataDataSet
    Friend WithEvents CharactersBindingSource As BindingSource
    Friend WithEvents CharactersTableAdapter As SW_dataDataSetTableAdapters.CharactersTableAdapter
    Friend WithEvents TableAdapterManager As SW_dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CharactersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CharactersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox1 As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents RazaTextBox As TextBox
    Friend WithEvents BandoTextBox As TextBox
    Friend WithEvents EdadTextBox As TextBox
    Friend WithEvents ImagenPictureBox As PictureBox
End Class
