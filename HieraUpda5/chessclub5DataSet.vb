Imports System.Reflection ' for MethodBase

Partial Class chessclub5DataSet
End Class

Namespace chessclub5DataSetTableAdapters

   ' wrongly created by the wizzard
   Partial Public Class MembersDataTable
   End Class

   ' [class 20171125°2331]
   '  The wizzard created class MembersDataTable, but we need MembersTableAdapter
   Partial Public Class MembersTableAdapter
      Inherits Global.System.ComponentModel.Component ' JUST A TRY

      ' [method 20171125°2341]
      Private Sub _adapter_RowUpdated(ByVal sender As Object, ByVal e As System.Data.OleDb.OleDbRowUpdatedEventArgs) Handles _adapter.RowUpdated
         AccessIDHelper.SetPrimaryKey(Me.Transaction, e)
      End Sub

      'Public Sub testMembersDataTable()
      Public Shared Sub testMembersDataTable() ' as Shared, the method is accessible from the test button
         MsgBox("This is trivial static method testMembersDataTable().")

      End Sub

      ' [method 20171125°2255]
      Public Sub test2MembersDataTable()

         ' refer to nasty experiment 20171125°2256
         Dim s As String = ""
         Dim x As Global.System.Data.OleDb.OleDbDataAdapter
         ' Heureka -- with the correct namespace, _adapter is visible! Though
         '  the usage here is not useful, because that is not the one wanted
         '  instance used from the Form1 TableAdapterManager [note 20171125°2321]
         x = Me._adapter
         If x Is Nothing Then
            s = "Nothing"
         Else
            s = x.InsertCommand.GetType.FullName
         End If
         MsgBox("Hello object test2MembersDataTable" _
                + Environment.NewLine + "Example property:" _
                 + Environment.NewLine + "_adapter.InsertCommand.GetType.FullName = " _
                  + Environment.NewLine _
                   + Environment.NewLine + s
                    )

      End Sub

   End Class


   ' wrongly created by the wizzard
   Partial Public Class GuardiansDataTable
   End Class

   ' [class 20171125°2332]
   ' The wizzard created class GuardiansDataTable, but we need GuardiansTableAdapter
   Partial Public Class GuardiansTableAdapter

      ' 20171125°2333 called from test button 3
      ' note : This test should show some value from Me._adapter. But this is not so
      '    easily possible because : (1) A normal method cannot be called form the main
      '    form without having the relevant object from the DataSet designer at hand.
      '    (2) A static method does not help accessing the private variable Me._adapter.
      Public Shared Sub testSubForTestButton3()
         Dim s As String
         's = Me._adapter.GetType.FullName
         s = MethodBase.GetCurrentMethod.Name
         MsgBox("This is class " + s)
      End Sub

      ' method 20171125°2342
      Private Sub _adapter_RowUpdated(ByVal sender As Object, ByVal e As System.Data.OleDb.OleDbRowUpdatedEventArgs) Handles _adapter.RowUpdated
         AccessIDHelper.SetPrimaryKey(Me.Transaction, e)
      End Sub

   End Class
End Namespace
