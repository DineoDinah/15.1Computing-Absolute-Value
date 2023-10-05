Imports System.Reflection.Metadata.BlobBuilder

Public Class Form1
	Private Sub BtnComputing_Click(sender As Object, e As EventArgs) Handles BtnComputing.Click
		TextBox2.Text = Math.Abs(Val(TextBox1.Text))
	End Sub
End Class
