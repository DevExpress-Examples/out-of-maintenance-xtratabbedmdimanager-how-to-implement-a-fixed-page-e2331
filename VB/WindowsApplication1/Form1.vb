Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTabbedMdi

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private r As New Random()
		Private Function GetRandomColor() As Color
			Return Color.FromArgb(r.Next(255), r.Next(255), r.Next(255))
		End Function

		Public Sub New()
			InitializeComponent()
			For i As Integer = 0 To 9
				Dim form As New Form()
				form.MdiParent = Me
				form.Show()
				form.Text = String.Format("Page{0}", i)
				form.BackColor = GetRandomColor()
			Next i
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			myMDIManager1.SetFixedForm(New StartPage())
		End Sub
	End Class
End Namespace