Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid.Customization
Imports DevExpress.XtraGrid.Views.Base.Handler

Namespace TreeListCustomization
	Friend Class MyAdvBandedGridView
		Inherits AdvBandedGridView
		' constructors
		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
		End Sub

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyAdvBandedGridView"
			End Get
		End Property

		Protected Overrides Function CreateCustomizationForm() As CustomizationForm
			Return New TreeListBandedCustomizationForm(Me)
		End Function

		Friend Shadows ReadOnly Property Handler() As BaseViewHandler
			Get
				Return MyBase.Handler
			End Get
		End Property
	End Class
End Namespace
