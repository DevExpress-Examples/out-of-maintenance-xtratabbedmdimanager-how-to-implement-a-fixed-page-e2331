Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTabbedMdi
Imports DevExpress.XtraTab

Namespace WindowsApplication1
	Public Class MyMDIManager
		Inherits XtraTabbedMdiManager

		Private _FixedPage As XtraMdiTabPage
		Public Property FixedPage() As XtraMdiTabPage
			Get
				Return _FixedPage
			End Get
			Set(ByVal value As XtraMdiTabPage)
				_FixedPage = value
				InitFixedPage()
			End Set
		End Property

		Public Sub New()
			AddHandler BeginFloating, AddressOf OnBeginFloating
		End Sub



		Public Sub SetFixedForm(ByVal form As Form)
			form.MdiParent = MdiParent
			form.Show()
			FixedPage = PageByForm(form)
		End Sub

		Private Function PageByForm(ByVal form As Form) As XtraMdiTabPage
			For Each page As XtraMdiTabPage In Pages
				If page.MdiChild Is form Then
					Return page
				End If
			Next page
			Return Nothing
		End Function
		Private Sub InitFixedPage()
			If _FixedPage IsNot Nothing Then
				_FixedPage.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False
				CheckFixedPage()
			End If
		End Sub

		Protected Overrides Sub DoDragDrop()
			If SelectedPage Is FixedPage Then
				Return
			End If
			MyBase.DoDragDrop()
			CheckFixedPage()
		End Sub

		Private Sub CheckFixedPage()
			If _FixedPage Is Nothing Then
				Return
			End If
			If Pages.IndexOf(FixedPage) <> 0 Then
				Pages.Remove(FixedPage)
				Pages.Insert(0, FixedPage)
				LayoutChanged()
			End If
		End Sub


		Private Sub OnBeginFloating(ByVal sender As Object, ByVal e As FloatingCancelEventArgs)
			e.Cancel = PageByForm(e.ChildForm) Is FixedPage
		End Sub

	End Class
End Namespace
