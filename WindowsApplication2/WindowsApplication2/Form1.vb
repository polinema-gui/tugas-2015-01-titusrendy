Public Class FormWarna

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Change.Click
        If Me.BackColor = Color.Red Then
            Me.BackColor = Color.Blue
        Else
            Me.BackColor = Color.Red

        End If
    End Sub

    Private Sub FormWarna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Blue
    End Sub
End Class
