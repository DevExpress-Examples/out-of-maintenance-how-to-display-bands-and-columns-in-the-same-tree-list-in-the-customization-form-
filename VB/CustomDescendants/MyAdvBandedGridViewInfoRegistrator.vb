Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Namespace TreeListCustomization
	Friend Class MyAdvBandedGridViewInfoRegistrator
		Inherits AdvBandedGridInfoRegistrator
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyAdvBandedGridView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyAdvBandedGridView(grid)
		End Function
	End Class
End Namespace
