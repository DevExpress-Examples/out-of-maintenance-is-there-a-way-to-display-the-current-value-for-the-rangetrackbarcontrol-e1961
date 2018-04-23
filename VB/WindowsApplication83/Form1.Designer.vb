Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication83
	Partial Public Class Form1
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
			Me.myRangeTrackBarControl1 = New WindowsApplication83.MyRangeTrackBarControl()
			CType(Me.myRangeTrackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myRangeTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myRangeTrackBarControl1
			' 
			Me.myRangeTrackBarControl1.EditValue = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 0)
			Me.myRangeTrackBarControl1.Location = New System.Drawing.Point(48, 94)
			Me.myRangeTrackBarControl1.Name = "myRangeTrackBarControl1"
			Me.myRangeTrackBarControl1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
			Me.myRangeTrackBarControl1.Properties.Appearance.Options.UseForeColor = True
			Me.myRangeTrackBarControl1.Size = New System.Drawing.Size(303, 56)
			Me.myRangeTrackBarControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(423, 269)
			Me.Controls.Add(Me.myRangeTrackBarControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myRangeTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myRangeTrackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myRangeTrackBarControl1 As MyRangeTrackBarControl
	End Class
End Namespace

