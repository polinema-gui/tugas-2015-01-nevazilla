Public Class Form1

    Private Sub Change_Click(sender As Object, e As EventArgs) Handles Change.Click
        If Me.BackColor() = Color.LightPink Then
            Me.BackColor() = Color.Aquamarine
        Else
            Me.BackColor() = Color.LightPink
        End If
    End Sub
End Class
