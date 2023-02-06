'Name:          Koric Test
'Purpose:       Choose and show ice cream flavors
'Programmer:    Sophia on 02.06.23


Public Class frmMain
    Private Sub lstIce_Click(sender As Object, e As EventArgs) Handles lstIce.Click
        If lstIce.SelectedIndex = 0 Then
            picIce.Image = My.Resources.mango

        ElseIf lstIce.SelectedIndex = 1 Then
            picIce.Image = My.Resources.boba

        ElseIf lstIce.SelectedIndex = 2 Then
            picIce.Image = My.Resources.green

        ElseIf lstIce.SelectedIndex = 3 Then
            picIce.Image = My.Resources.caramel

        ElseIf lstIce.SelectedIndex = 4 Then
            picIce.Image = My.Resources.orange
        End If
    End Sub
End Class
