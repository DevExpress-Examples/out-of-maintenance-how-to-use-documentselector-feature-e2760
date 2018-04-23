Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Samples.DocumentSelector
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.xtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
			CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabbedMdiManager1
			' 
			Me.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold)
			Me.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseFont = True
			Me.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader
			Me.xtraTabbedMdiManager1.MdiParent = Me
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(819, 484)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.IsMdiContainer = True
			Me.Name = "Form1"
			Me.Text = "Simple Photo Album"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.xtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
	End Class
End Namespace

