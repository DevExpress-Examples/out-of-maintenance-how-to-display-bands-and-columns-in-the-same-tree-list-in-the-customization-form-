Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Views.BandedGrid.Customization
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Columns
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Columns
Imports System.Collections
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing

Namespace TreeListCustomization
	Friend Class TreeListBandedCustomizationForm
		Inherits BandedCustomizationForm
		Private bandsColumnTreeList_ As TreeList
		Private ReadOnly Property BandsColumnTreeList() As TreeList
			Get
				Return bandsColumnTreeList_
			End Get
		End Property
		Private UnvisibleList As New ArrayList()
		Private customCellPainter As New SkinHeaderObjectPainter(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel)

		Public Sub New(ByVal gridView As BandedGridView)
			MyBase.New(gridView)
		End Sub

		Protected Overrides Sub CreateListBox()
			bandsColumnTreeList_ = New TreeListForBands(Me)
			Dim newColumn As TreeListColumn = bandsColumnTreeList_.Columns.Add()
			newColumn.FieldName = "Content"
			newColumn.VisibleIndex = 0
			newColumn.OptionsColumn.AllowEdit = False
			newColumn.OptionsColumn.ReadOnly = True

			bandsColumnTreeList_.OptionsView.ShowColumns = False
			bandsColumnTreeList_.OptionsView.ShowIndicator = False
			FillBandsColumnTreeList()
			bandsColumnTreeList_.Dock = DockStyle.Fill
			Controls.Add(bandsColumnTreeList_)
			AddHandler BandsColumnTreeList.CustomDrawNodeCell, AddressOf BandsColumnTreeList_CustomDrawNodeCell
		End Sub

		Private Sub BandsColumnTreeList_CustomDrawNodeCell(ByVal sender As Object, ByVal e As CustomDrawNodeCellEventArgs)
			Dim band As GridBand = TryCast(e.Node(0), GridBand)
			If band IsNot Nothing AndAlso (Not band.Visible) Then
				DrawNodeElementAsColumn(e)
			End If

			Dim gridColumn As BandedGridColumn = TryCast(e.Node(0), BandedGridColumn)
			If gridColumn IsNot Nothing AndAlso ((Not gridColumn.Visible) OrElse gridColumn.OwnerBand Is Nothing) Then
				DrawNodeElementAsColumn(e)
			End If
		End Sub

		Private Sub DrawNodeElementAsColumn(ByVal e As CustomDrawNodeCellEventArgs)
			Dim infoArgs As New HeaderObjectInfoArgs()
			infoArgs.Bounds = Rectangle.Inflate(e.Bounds, -1, 0)
			infoArgs.Cache = e.Cache
			infoArgs.Caption = e.CellText
			infoArgs.CaptionRect = e.Bounds
			infoArgs.TopLeft = New Point(infoArgs.CaptionRect.X, infoArgs.CaptionRect.Y + 3)
			customCellPainter.DrawObject(infoArgs)
			e.Handled = True
		End Sub

		Public Overrides Sub UpdateListBox()
		End Sub

		Protected Overrides Sub SetDefaultFormSize()
		End Sub

		Public Overrides Sub CheckAndUpdate()
			BandsColumnTreeList.Nodes.Clear()
			FillBandsColumnTreeList()
		End Sub

		Private Sub FillUnvisibleElementsArray()
			UnvisibleList.Clear()
			For Each band As GridBand In View.Bands
				If (Not band.Visible) AndAlso band.OptionsBand.ShowInCustomizationForm Then
					UnvisibleList.Add(band)
				End If
				AddBandChildren(band)
			Next band
			For Each column As GridColumn In View.Columns
				If column.CanShowInCustomizationForm Then
					UnvisibleList.Add(column)
				End If
			Next column
		End Sub

		Private Sub AddBandChildren(ByVal band As GridBand)
			If (Not band.HasChildren) Then
				Return
			End If
			For Each bd As GridBand In band.Children
				If (Not bd.Visible) AndAlso bd.OptionsBand.ShowInCustomizationForm Then
					UnvisibleList.Add(bd)
					AddBandChildren(bd)
				End If
			Next bd
		End Sub

		Private Sub FillBandsColumnTreeList()
			UnvisibleList.Clear()
			FillUnvisibleElementsArray()
			For Each item As Object In UnvisibleList
				Dim newNode As TreeListNode = Nothing
				If TypeOf item Is GridBand Then
					newNode = AddBandAsTreeNode(TryCast(item, GridBand))
				End If
				If TypeOf item Is BandedGridColumn Then
					newNode = AddBandedColumnAsTreeNode(TryCast(item, BandedGridColumn))
				End If
			Next item
		End Sub

		Private Function AddBandAsTreeNode(ByVal band As GridBand) As TreeListNode
			If band.ParentBand Is Nothing Then
				Dim currentNode As TreeListNode = BandsColumnTreeList.FindNodeByFieldValue("Content", band)
				If currentNode Is Nothing Then
                    currentNode = BandsColumnTreeList.AppendNode(New Object() {band}, -1)
				End If
				Return currentNode
			Else
				Dim parentNode As TreeListNode = AddBandAsTreeNode(band.ParentBand)
				Return BandsColumnTreeList.AppendNode(New Object() { band }, parentNode)
			End If
		End Function


		Private Function AddBandedColumnAsTreeNode(ByVal bandedColumn As BandedGridColumn) As TreeListNode
			If bandedColumn.OwnerBand Is Nothing Then
                Return BandsColumnTreeList.AppendNode(New Object() {bandedColumn}, -1)
			Else
				Dim parentNode As TreeListNode = BandsColumnTreeList.FindNodeByFieldValue("Content", bandedColumn.OwnerBand)
				If parentNode Is Nothing Then
					parentNode = AddBandAsTreeNode(bandedColumn.OwnerBand)
				End If
				Return BandsColumnTreeList.AppendNode(New Object() { bandedColumn }, parentNode)
			End If
		End Function
	End Class
End Namespace
