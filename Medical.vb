Public Class frmMedical
    Private Sub frmMedical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet3.Med' table. You can move, or remove it, as needed.
        Me.MedTableAdapter.Fill(Me.Database2DataSet3.Med)

    End Sub

    Private Sub btnSave2_Click(sender As Object, e As EventArgs) Handles btnSave2.Click

        MedBindingSource.EndEdit()
        MedTableAdapter.Update(Database2DataSet3)
        MessageBox.Show("Data Saved")

    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click

        txtMedicineName.Text = ""
        txtQuantity.Text = ""

    End Sub

    Private Sub btnPrevious2_Click(sender As Object, e As EventArgs) Handles btnPrevious2.Click

        MedBindingSource.MovePrevious()

    End Sub

    Private Sub btnNew2_Click(sender As Object, e As EventArgs) Handles btnNew2.Click

        MedBindingSource.AddNew()

    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click

        MedBindingSource.MoveNext()

    End Sub
End Class