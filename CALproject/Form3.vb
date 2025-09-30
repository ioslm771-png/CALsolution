Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form3
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        X = Integer.Parse(TextBox1.Text)
        Y = Integer.Parse(TextBox2.Text)
        If RadioButton1.Checked = True Then
            TextBox3.Text = (X Mod Y).tostring
        End If
        If RadioButton2.Checked = True Then
            TextBox3.Text = (X ^ Y).tosring
        End If
        If RadioButton3.Checked = True Then
            TextBox3.Text = System.Math.Sqrt(x).ToString
        End If
        If RadioButton4.Checked = True Then
            TextBox3.Text = System.Math.Sqrt(Y).ToString
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class