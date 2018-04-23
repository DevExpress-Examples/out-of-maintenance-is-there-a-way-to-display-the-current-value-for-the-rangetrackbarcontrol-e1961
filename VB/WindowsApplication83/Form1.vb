Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils.Drawing

Namespace WindowsApplication83
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class MyRangeTrackBarControl
		Inherits RangeTrackBarControl

		Public Sub New()
			Properties.Appearance.ForeColor = Color.Black
		End Sub

		Protected ReadOnly Property RangeViewInfo() As RangeTrackBarViewInfo
			Get
				Return TryCast(ViewInfo, RangeTrackBarViewInfo)
			End Get
		End Property

		Protected ReadOnly Property ThumbTextIndent() As Integer
			Get
				Return 7
			End Get
		End Property

		Protected ReadOnly Property MinTextPos() As Point
			Get
				Return New Point(RangeViewInfo.MinThumbBounds.Left, RangeViewInfo.MinThumbBounds.Bottom + ThumbTextIndent)
			End Get
		End Property

		Protected ReadOnly Property MaxTextPos() As Point
			Get
				Return New Point(RangeViewInfo.MaxThumbBounds.Left - 5, RangeViewInfo.MaxThumbBounds.Bottom + ThumbTextIndent)
			End Get
		End Property

		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			MyBase.OnPaint(e)
			Dim cache As New GraphicsCache(e.Graphics)
			e.Graphics.DrawString(Value.Minimum.ToString(), ViewInfo.PaintAppearance.Font, ViewInfo.PaintAppearance.GetForeBrush(cache), MinTextPos)
			e.Graphics.DrawString(Value.Maximum.ToString(), ViewInfo.PaintAppearance.Font, ViewInfo.PaintAppearance.GetForeBrush(cache), MaxTextPos)
		End Sub
	End Class
End Namespace