Public Class Form1
   Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MembersBindingNavigatorSaveItem.Click
      Me.Validate()
      Me.MembersBindingSource.EndEdit()

      ' line supplemented [line 20171125°2201]
      ' Call EndEdit on all BindingSources! [Beth Massi]
      Me.GuardiansBindingSource.EndEdit()

      Me.TableAdapterManager.UpdateAll(Me.Chessclub5DataSet)

   End Sub

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      '' Load parent before child! [modi 20171125°2202]
      ''''------------------------
      '''''TODO: This line of code loads data into the 'Chessclub4DataSet.Guardians' table. You can move, or remove it, as needed.
      ''''Me.GuardiansTableAdapter.Fill(Me.Chessclub4DataSet.Guardians)
      '''''TODO: This line of code loads data into the 'Chessclub4DataSet.Members' table. You can move, or remove it, as needed.
      ''''Me.MembersTableAdapter.Fill(Me.Chessclub4DataSet.Members)
      ''''------------------------

      ' See issue 20211205°1144 System.InvalidOperationException: 'The 'Microsoft.ACE.OLEDB.12.0' provider is not registered on the local machine.'
      Try
         Me.MembersTableAdapter.Fill(Me.Chessclub5DataSet.Members)
         Me.GuardiansTableAdapter.Fill(Me.Chessclub5DataSet.Guardians)
      Catch ex As Exception
         MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine _
                          + "Please fixe this before running DataSet4Access again." _
                           , "Sorry, your system is missing something" _
                            , MessageBoxButtons.OK _
                             , MessageBoxIcon.Stop
                              )
      End Try

   End Sub

   ' event added [20171125°2203]
   Private Sub GuardiansDataGridView_Enter(sender As Object, e As EventArgs) Handles GuardiansDataGridView.Enter

      ' [line 20171125°2204] after Beth Massi
      ' You must commit the parent row to the DataTable before adding child rows
      ' note : In the walkthrough projects before, this action was placed in
      '         the GuardiansBindingSource_AddingNew event, e.g. 20171125°2034
      Me.MembersBindingSource.EndEdit()

   End Sub

   ' method 20171125°2253
   Private Sub Button_Test1_Click(sender As Object, e As EventArgs) Handles Button_Test1.Click
      chessclub5DataSetTableAdapters.MembersTableAdapter.testMembersDataTable()
   End Sub

   ' method 20171125°2258
   Private Sub Button_Test2_Click(sender As Object, e As EventArgs) Handles Button_Test2.Click
      Dim dataTable As chessclub5DataSetTableAdapters.MembersTableAdapter = New chessclub5DataSetTableAdapters.MembersTableAdapter()
      dataTable.test2MembersDataTable()
   End Sub

   ' method 20171125°2334
   Private Sub Button_Test3_Click(sender As Object, e As EventArgs) Handles Button_Test3.Click
      chessclub5DataSetTableAdapters.GuardiansTableAdapter.testSubForTestButton3()
   End Sub

   '   Private Sub Button_Tes3t2_Click(sender As Object, e As EventArgs) Handles Button_Test2.Click
   '   Dim dataTable As chessclub5DataSetTableAdapters.MembersTableAdapter = New chessclub5DataSetTableAdapters.MembersTableAdapter()
   '      dataTable.test2MembersDataTable()
   '   End Sub

End Class
