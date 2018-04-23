Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Dragging

Namespace TreeListCustomization
	Friend Class MyGridControl
		Inherits GridControl
		Protected Overrides Function CreateDefaultView() As BaseView
			Return CreateView("MyBandedGridView")
		End Function
		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyBandedGridViewInfoRegistrator())
			collection.Add(New MyAdvBandedGridViewInfoRegistrator())
		End Sub

		Friend Shadows ReadOnly Property DragController() As DragController
			Get
				Return MyBase.DragController
			End Get
		End Property
	End Class

End Namespace
