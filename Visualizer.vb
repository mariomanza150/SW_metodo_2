Public Class Visualizer
    Private Sub bttn_exit_Click(sender As Object, e As EventArgs) Handles bttn_exit.Click
        End
    End Sub

    Private Sub CharactersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CharactersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CharactersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SW_dataDataSet)

    End Sub

    Private Sub Visualizer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SW_dataDataSet.Characters' table. You can move, or remove it, as needed.
        Me.CharactersTableAdapter.Fill(Me.SW_dataDataSet.Characters)

    End Sub
End Class
