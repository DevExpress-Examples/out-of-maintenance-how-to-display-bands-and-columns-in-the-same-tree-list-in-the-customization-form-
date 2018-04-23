Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraTreeList
Imports System.Drawing
Imports DevExpress.XtraTreeList.ViewInfo
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Grid.Handler
Imports DevExpress.XtraTreeList.Painter
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Dragging
Imports DevExpress.XtraGrid
Imports System.Reflection

Namespace TreeListCustomization
	Friend Class TreeListForBands
		Inherits TreeList
		Private downPoint As Point = Point.Empty
		Protected customizationForm_ As TreeListBandedCustomizationForm
		Protected pressedItem_ As Object

		Public ReadOnly Property View() As BandedGridView
			Get
				Return (TryCast(TreeListCustomizationForm.View, BandedGridView))
			End Get
		End Property
		Public ReadOnly Property TreeListCustomizationForm() As TreeListBandedCustomizationForm
			Get
				Return customizationForm_
			End Get
		End Property
		Public ReadOnly Property ViewHandler() As BaseViewHandler
			Get
				If TypeOf View Is MyBandedGridView Then
					Return (TryCast(View, MyBandedGridView)).Handler
				ElseIf TypeOf View Is MyAdvBandedGridView Then
					Return (TryCast(View, MyAdvBandedGridView)).Handler
				Else
					Return Nothing
				End If
			End Get
		End Property

		Public Sub New(ByVal custForm As TreeListBandedCustomizationForm)
			MyBase.New()
			customizationForm_ = custForm
		End Sub

		Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
			Dim p As New Point(e.X, e.Y)
			Dim pp As Point = PointToView(p)
			Dim [me] As New MouseEventArgs(e.Button, e.Clicks, pp.X, pp.Y, e.Delta)
			If IsDragging Then
				Dim controller As DragController = TryCast(GetType(GridControl).GetProperty("DragController", BindingFlags.GetProperty Or BindingFlags.Instance Or BindingFlags.NonPublic).GetValue(View.GridControl, Nothing), DragController)

				If [me].Button <> MouseButtons.Left Then
					controller.CancelDrag()
				Else
					controller.DoDragging([me]) 'DoDragging(me);
				End If
				Return
			End If
			Dim dragSize As Size = System.Windows.Forms.SystemInformation.DragSize
			If PressedItem IsNot Nothing Then
				If (e.Button And MouseButtons.Left) <> 0 Then
					If Math.Abs(p.X - downPoint.X) > dragSize.Width OrElse Math.Abs(p.Y - downPoint.Y) > dragSize.Height Then
						If ViewHandler IsNot Nothing Then
							TryCast(ViewHandler, GridHandler).DownPointHitInfo = View.CalcHitInfo(p)
							TryCast(ViewHandler, GridHandler).DoStartDragObject(PressedItem, New Size(ClientSize.Width, 23))
							If IsDragging Then
								Capture = True
							Else
								PressedItem = Nothing
							End If
							Return
						End If
					End If
				End If
			End If
			MyBase.OnMouseMove(e)
		End Sub

		Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
			MyBase.OnMouseDown(e)
			downPoint = New Point(e.X, e.Y)
			Dim item As Object = ItemByPoint(downPoint)
			PressedItem = item
			If (e.Button And MouseButtons.Left) <> 0 Then
				Capture = True
			End If
		End Sub

		Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Capture = False
			PressedItem = Nothing
			If IsDragging Then
				Dim pp As Point = PointToView(New Point(e.X, e.Y))
				Dim [me] As New MouseEventArgs(e.Button, e.Clicks, pp.X, pp.Y, e.Delta)
				Dim controller As DragController = TryCast(GetType(GridControl).GetProperty("DragController", BindingFlags.GetProperty Or BindingFlags.Instance Or BindingFlags.NonPublic).GetValue(View.GridControl, Nothing), DragController)
				controller.EndDrag(e)
			End If
		End Sub

		Friend Property PressedItem() As Object
			Get
				Return pressedItem_
			End Get
			Set(ByVal value As Object)
				pressedItem_ = value
			End Set
		End Property

		Protected Function ItemByPoint(ByVal pt As Point) As Object
			Dim currentRowInfo As RowInfo = ViewInfo.GetRowInfoByPoint(pt)
			If currentRowInfo IsNot Nothing Then
				Dim band As GridBand = TryCast(currentRowInfo.Node(0), GridBand)
				If band IsNot Nothing AndAlso (Not band.Visible) Then
					Return band
				End If

				Dim gridColumn As BandedGridColumn = TryCast(currentRowInfo.Node(0), BandedGridColumn)
				If gridColumn IsNot Nothing AndAlso ((Not gridColumn.Visible) OrElse gridColumn.OwnerBand Is Nothing) Then
					Return gridColumn
				End If

				Return Nothing
			Else
				Return Nothing
			End If
		End Function

		Private Function PointToView(ByVal p As Point) As Point
			Return TreeListCustomizationForm.ControlOwner.PointToClient(PointToScreen(p))
		End Function

		Private ReadOnly Property IsDragging() As Boolean
			Get
				Return View IsNot Nothing AndAlso (TryCast(View, GridView)).State = GridState.ColumnDragging
			End Get
		End Property
	End Class
End Namespace
