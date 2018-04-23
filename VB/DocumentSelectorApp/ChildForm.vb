Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.Samples.DocumentSelector
	Partial Public Class ChildForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Shared groupIndex As Integer = 0
		Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			AddHandler gridView1.FocusedRowChanged, AddressOf Form2_FocusedRowChanged
			Dim photos As IList(Of Photo) = New List(Of Photo)()
			Dim group() As Integer = photoGroups((groupIndex) Mod photoGroups.Length)
			groupIndex += 1
			For i As Integer = 0 To group.Length - 1
				photos.Add(New Photo(String.Format("Photo{0}", group(i)), String.Format("Images\0{0}.jpg", group(i))))
			Next i
			gridControl1.DataSource = photos
			gridView1.BestFitColumns()
		End Sub
		Private Sub Form2_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs)
			If e.FocusedRowHandle = GridControl.InvalidRowHandle Then
				Return
			End If
			pictureBox1.Image = LoadImage(CStr(gridView1.GetRowCellValue(e.FocusedRowHandle, "Path")))
		End Sub
		Private Shared Function LoadImage(ByVal path As String) As System.Drawing.Image
			Dim currentAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetAssembly(GetType(ChildForm))
			Return ResourceImageHelper.CreateImageFromResources("DevExpress.Samples.DocumentSelector." & path.Replace("\", "."), currentAssembly)
		End Function
		Private Shared photoGroups()() As Integer = { New Integer() { 5, 3, 7 }, New Integer() { 3, 4 }, New Integer() { 2, 3, 4, 5 }, New Integer() { 0, 1, 6, 8 } }
	End Class
	Friend Class Photo
		Public Sub New(ByVal name As String, ByVal path As String)
			nameCore = name
			pathCore = path
		End Sub
		Private nameCore As String
		Private pathCore As String
		Public ReadOnly Property Name() As String
			Get
				Return nameCore
			End Get
		End Property
		Public ReadOnly Property Path() As String
			Get
				Return pathCore
			End Get
		End Property
	End Class
End Namespace