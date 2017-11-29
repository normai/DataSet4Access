Imports System.Data.OleDb

Public Class AccessIDHelper

   ''' <summary>
   ''' This class is to retrieve the primary key autonumber values from Access.
   ''' </summary>
   ''' <remarks>
   ''' Class [20171125°2231] written by after Beth Massi, see
   ''' - https://blogs.msdn.microsoft.com/bethmassi/2009/05/14/using-tableadapters-to-insert-related-data-into-an-ms-access-database/
   ''' - or https://www.facebook.com/note.php?note_id=78517206533
   ''' </remarks>

   Public Shared Sub SetPrimaryKey(ByVal trans As OleDbTransaction, ByVal e As OleDbRowUpdatedEventArgs)

      If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then

         ' If this is an INSERT operation ...
         Dim pk = e.Row.Table.PrimaryKey

         ' and a primary key column exists ...
         If pk IsNot Nothing AndAlso pk.Count = 1 Then

            Dim cmdGetIdentity As New OleDbCommand(“SELECT @@IDENTITY”, trans.Connection, trans)

            ' Execute the post-update query to fetch new @@Identity
            e.Row(pk(0)) = CInt(cmdGetIdentity.ExecuteScalar)
            e.Row.AcceptChanges()

         End If
      End If

   End Sub

End Class
