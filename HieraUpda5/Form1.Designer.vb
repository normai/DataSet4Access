<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
      Me.Chessclub5DataSet = New HieraUpda5.chessclub5DataSet()
      Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.MembersTableAdapter = New HieraUpda5.chessclub5DataSetTableAdapters.MembersTableAdapter()
      Me.TableAdapterManager = New HieraUpda5.chessclub5DataSetTableAdapters.TableAdapterManager()
      Me.GuardiansTableAdapter = New HieraUpda5.chessclub5DataSetTableAdapters.GuardiansTableAdapter()
      Me.MembersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
      Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
      Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
      Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
      Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.MembersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
      Me.MembersDataGridView = New System.Windows.Forms.DataGridView()
      Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.GuardiansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
      Me.GuardiansDataGridView = New System.Windows.Forms.DataGridView()
      Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Button_Test1 = New System.Windows.Forms.Button()
      Me.Button_Test2 = New System.Windows.Forms.Button()
      Me.Button_Test3 = New System.Windows.Forms.Button()
      CType(Me.Chessclub5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.MembersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.MembersBindingNavigator.SuspendLayout()
      CType(Me.MembersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.GuardiansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.GuardiansDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'Chessclub5DataSet
      '
      Me.Chessclub5DataSet.DataSetName = "chessclub5DataSet"
      Me.Chessclub5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
      '
      'MembersBindingSource
      '
      Me.MembersBindingSource.DataMember = "Members"
      Me.MembersBindingSource.DataSource = Me.Chessclub5DataSet
      '
      'MembersTableAdapter
      '
      Me.MembersTableAdapter._adapter = Nothing
      Me.MembersTableAdapter.ClearBeforeFill = True
      '
      'TableAdapterManager
      '
      Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
      Me.TableAdapterManager.GuardiansTableAdapter = Me.GuardiansTableAdapter
      Me.TableAdapterManager.MembersTableAdapter = Me.MembersTableAdapter
      Me.TableAdapterManager.UpdateOrder = HieraUpda5.chessclub5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
      '
      'GuardiansTableAdapter
      '
      Me.GuardiansTableAdapter.ClearBeforeFill = True
      '
      'MembersBindingNavigator
      '
      Me.MembersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
      Me.MembersBindingNavigator.BindingSource = Me.MembersBindingSource
      Me.MembersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
      Me.MembersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
      Me.MembersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MembersBindingNavigatorSaveItem})
      Me.MembersBindingNavigator.Location = New System.Drawing.Point(0, 0)
      Me.MembersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
      Me.MembersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
      Me.MembersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
      Me.MembersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
      Me.MembersBindingNavigator.Name = "MembersBindingNavigator"
      Me.MembersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
      Me.MembersBindingNavigator.Size = New System.Drawing.Size(655, 25)
      Me.MembersBindingNavigator.TabIndex = 0
      Me.MembersBindingNavigator.Text = "BindingNavigator1"
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
      'BindingNavigatorCountItem
      '
      Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
      Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
      Me.BindingNavigatorCountItem.Text = "of {0}"
      Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
      '
      'BindingNavigatorDeleteItem
      '
      Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
      Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorDeleteItem.Text = "Delete"
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
      'BindingNavigatorSeparator1
      '
      Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
      Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'BindingNavigatorMoveNextItem
      '
      Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
      Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMoveNextItem.Text = "Move next"
      '
      'BindingNavigatorMoveLastItem
      '
      Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
      Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
      Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
      Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
      Me.BindingNavigatorMoveLastItem.Text = "Move last"
      '
      'BindingNavigatorSeparator2
      '
      Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
      Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'MembersBindingNavigatorSaveItem
      '
      Me.MembersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.MembersBindingNavigatorSaveItem.Image = CType(resources.GetObject("MembersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
      Me.MembersBindingNavigatorSaveItem.Name = "MembersBindingNavigatorSaveItem"
      Me.MembersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
      Me.MembersBindingNavigatorSaveItem.Text = "Save Data"
      '
      'MembersDataGridView
      '
      Me.MembersDataGridView.AutoGenerateColumns = False
      Me.MembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.MembersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
      Me.MembersDataGridView.DataSource = Me.MembersBindingSource
      Me.MembersDataGridView.Location = New System.Drawing.Point(9, 40)
      Me.MembersDataGridView.Name = "MembersDataGridView"
      Me.MembersDataGridView.Size = New System.Drawing.Size(342, 237)
      Me.MembersDataGridView.TabIndex = 1
      '
      'DataGridViewTextBoxColumn1
      '
      Me.DataGridViewTextBoxColumn1.DataPropertyName = "MemberId"
      Me.DataGridViewTextBoxColumn1.HeaderText = "MemberId"
      Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
      Me.DataGridViewTextBoxColumn1.Width = 40
      '
      'DataGridViewTextBoxColumn2
      '
      Me.DataGridViewTextBoxColumn2.DataPropertyName = "Forename"
      Me.DataGridViewTextBoxColumn2.HeaderText = "Forename"
      Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
      Me.DataGridViewTextBoxColumn2.Width = 80
      '
      'DataGridViewTextBoxColumn3
      '
      Me.DataGridViewTextBoxColumn3.DataPropertyName = "Surname"
      Me.DataGridViewTextBoxColumn3.HeaderText = "Surname"
      Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
      Me.DataGridViewTextBoxColumn3.Width = 80
      '
      'DataGridViewTextBoxColumn4
      '
      Me.DataGridViewTextBoxColumn4.DataPropertyName = "DateOfBirth"
      Me.DataGridViewTextBoxColumn4.HeaderText = "DateOfBirth"
      Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
      Me.DataGridViewTextBoxColumn4.Width = 80
      '
      'GuardiansBindingSource
      '
      Me.GuardiansBindingSource.DataMember = "MembersGuardians"
      Me.GuardiansBindingSource.DataSource = Me.MembersBindingSource
      '
      'GuardiansDataGridView
      '
      Me.GuardiansDataGridView.AutoGenerateColumns = False
      Me.GuardiansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GuardiansDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
      Me.GuardiansDataGridView.DataSource = Me.GuardiansBindingSource
      Me.GuardiansDataGridView.Location = New System.Drawing.Point(357, 40)
      Me.GuardiansDataGridView.Name = "GuardiansDataGridView"
      Me.GuardiansDataGridView.Size = New System.Drawing.Size(288, 155)
      Me.GuardiansDataGridView.TabIndex = 2
      '
      'DataGridViewTextBoxColumn5
      '
      Me.DataGridViewTextBoxColumn5.DataPropertyName = "GuardianId"
      Me.DataGridViewTextBoxColumn5.HeaderText = "GuardianId"
      Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
      Me.DataGridViewTextBoxColumn5.Width = 40
      '
      'DataGridViewTextBoxColumn6
      '
      Me.DataGridViewTextBoxColumn6.DataPropertyName = "MemberId"
      Me.DataGridViewTextBoxColumn6.HeaderText = "MemberId"
      Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
      Me.DataGridViewTextBoxColumn6.Width = 40
      '
      'DataGridViewTextBoxColumn7
      '
      Me.DataGridViewTextBoxColumn7.DataPropertyName = "Forename"
      Me.DataGridViewTextBoxColumn7.HeaderText = "Forename"
      Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
      Me.DataGridViewTextBoxColumn7.Width = 80
      '
      'DataGridViewTextBoxColumn8
      '
      Me.DataGridViewTextBoxColumn8.DataPropertyName = "Surname"
      Me.DataGridViewTextBoxColumn8.HeaderText = "Surname"
      Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
      Me.DataGridViewTextBoxColumn8.Width = 80
      '
      'Button_Test1
      '
      Me.Button_Test1.Location = New System.Drawing.Point(369, 254)
      Me.Button_Test1.Name = "Button_Test1"
      Me.Button_Test1.Size = New System.Drawing.Size(48, 23)
      Me.Button_Test1.TabIndex = 3
      Me.Button_Test1.Text = "Test 1"
      Me.Button_Test1.UseVisualStyleBackColor = True
      '
      'Button_Test2
      '
      Me.Button_Test2.Location = New System.Drawing.Point(428, 254)
      Me.Button_Test2.Name = "Button_Test2"
      Me.Button_Test2.Size = New System.Drawing.Size(48, 23)
      Me.Button_Test2.TabIndex = 4
      Me.Button_Test2.Text = "Test 2"
      Me.Button_Test2.UseVisualStyleBackColor = True
      '
      'Button_Test3
      '
      Me.Button_Test3.Location = New System.Drawing.Point(487, 254)
      Me.Button_Test3.Name = "Button_Test3"
      Me.Button_Test3.Size = New System.Drawing.Size(48, 23)
      Me.Button_Test3.TabIndex = 5
      Me.Button_Test3.Text = "Test 3"
      Me.Button_Test3.UseVisualStyleBackColor = True
      '
      'Form1
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(655, 289)
      Me.Controls.Add(Me.Button_Test3)
      Me.Controls.Add(Me.Button_Test2)
      Me.Controls.Add(Me.Button_Test1)
      Me.Controls.Add(Me.GuardiansDataGridView)
      Me.Controls.Add(Me.MembersDataGridView)
      Me.Controls.Add(Me.MembersBindingNavigator)
      Me.Name = "Form1"
      Me.Text = "DataGridView4AccessDb v0.1"
      CType(Me.Chessclub5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.MembersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
      Me.MembersBindingNavigator.ResumeLayout(False)
      Me.MembersBindingNavigator.PerformLayout()
      CType(Me.MembersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.GuardiansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.GuardiansDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents Chessclub5DataSet As chessclub5DataSet
   Friend WithEvents MembersBindingSource As BindingSource
   Friend WithEvents MembersTableAdapter As chessclub5DataSetTableAdapters.MembersTableAdapter
   Friend WithEvents TableAdapterManager As chessclub5DataSetTableAdapters.TableAdapterManager
   Friend WithEvents MembersBindingNavigator As BindingNavigator
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
   Friend WithEvents MembersBindingNavigatorSaveItem As ToolStripButton
   Friend WithEvents GuardiansTableAdapter As chessclub5DataSetTableAdapters.GuardiansTableAdapter
   Friend WithEvents MembersDataGridView As DataGridView
   Friend WithEvents GuardiansBindingSource As BindingSource
   Friend WithEvents GuardiansDataGridView As DataGridView
   Friend WithEvents Button_Test1 As Button
   Friend WithEvents Button_Test2 As Button
   Friend WithEvents Button_Test3 As Button
   Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
   Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
