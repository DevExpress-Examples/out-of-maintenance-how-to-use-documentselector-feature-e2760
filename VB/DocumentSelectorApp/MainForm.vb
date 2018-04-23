Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTabbedMdi

Namespace DevExpress.Samples.DocumentSelector
	Partial Public Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			'** Floating options **
			xtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True
			xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.True
			xtraTabbedMdiManager1.FloatPageDragMode = FloatPageDragMode.Preview
'			#Region "#1"
			'** To show child forms' icons in page headers **
			xtraTabbedMdiManager1.UseFormIconAsPageImage = DefaultBoolean.True
			'** Enable the Document Selector feature (use CTRL+TAB) **
			xtraTabbedMdiManager1.UseDocumentSelector = DefaultBoolean.True
'			#End Region ' #1
			AddHandler xtraTabbedMdiManager1.CustomDocumentSelectorSettings, AddressOf xtraTabbedMdiManager1_CustomDocumentSelectorSettings
			AddHandler xtraTabbedMdiManager1.CustomDocumentSelectorItem, AddressOf xtraTabbedMdiManager1_CustomDocumentSelectorItem
		End Sub
		#Region "#2"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			AddChild("Recent", "Shows the recently viewed photos")
			AddChild("Favorites", "My favorite photos")
			AddChild("Published", "These photos are published in my blog")
			AddChild("Unsorted", "Not reviewed photos")
		End Sub
		Private Sub AddChild(ByVal category As String, ByVal tag As String)
			Dim categoryForm As New ChildForm()
			categoryForm.Text = category
			categoryForm.MdiParent = Me
			categoryForm.Tag = tag
			categoryForm.Show()
		End Sub
		Private Sub xtraTabbedMdiManager1_CustomDocumentSelectorSettings(ByVal sender As Object, ByVal e As CustomDocumentSelectorSettingsEventArgs)
			' Define max visible row count (12 by default )
			e.Selector.GalleryMaxRows = 4
			' Define width of item column (by default this value is calculated automatically)
			e.Selector.GalleryColumnWidth = 140

			e.Selector.ShowHeader = True
			e.Selector.ShowFooter = True

			e.Selector.HeaderHeight = 50
			e.Selector.FooterHeight = 50
		End Sub
		Private Sub xtraTabbedMdiManager1_CustomDocumentSelectorItem(ByVal sender As Object, ByVal e As CustomDocumentSelectorItemEventArgs)
			e.Item.FooterText = CStr(e.Item.Page.MdiChild.Tag)
			e.Item.HeaderText = String.Format("Photo Category: {0}", e.Item.Caption)
		End Sub
		#End Region ' #2
	End Class
End Namespace