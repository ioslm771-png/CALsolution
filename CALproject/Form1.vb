Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        x = Integer.Parse(TextBox1.Text)
        y = Integer.Parse(TextBox2.Text)
        If RadioButton1.Checked = True Then
            TextBox3.Text = (x + y).tostring
        End If
        If RadioButton2.Checked = True Then
            TextBox3.Text = (x - y).tosring
        End If
        If RadioButton3.Checked = True Then
            TextBox3.Text = (x * y).tostring
        End If
        If RadioButton4.Checked = True Then
            TextBox3.Text = (X / y).tostring
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.show()
    End Sub

    Private Sub Button3_Click() Handles Button3.Click
        End
    End Sub
End Class
