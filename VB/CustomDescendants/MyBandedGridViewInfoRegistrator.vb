Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base.Handler

Namespace TreeListCustomization
	Friend Class MyBandedGridViewInfoRegistrator
		Inherits BandedGridInfoRegistrator
		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyBandedGridView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyBandedGridView(grid)
		End Function
	End Class
End Namespace
