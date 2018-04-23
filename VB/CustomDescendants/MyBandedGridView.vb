Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid.Customization
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Base.Handler
Imports DevExpress.Utils

Namespace TreeListCustomization
	Friend Class MyBandedGridView
		Inherits BandedGridView
		' constructors
		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
		End Sub

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyBandedGridView"
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
