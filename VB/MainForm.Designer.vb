Imports Microsoft.VisualBasic
Imports System
Namespace TreeListCustomization
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
            Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.carsDBDataSet = New TreeListCustomization.CarsDBDataSet()
            Me.carsTableAdapter = New TreeListCustomization.CarsDBDataSetTableAdapters.CarsTableAdapter()
            Me.myGridControlMain = New TreeListCustomization.MyGridControl()
            Me.myGridView = New TreeListCustomization.MyAdvBandedGridView()
            Me.gridBandGeneralInformation = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.gridBandDescription = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colModel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colMPG_City = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colTrademark = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colCategory = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBandTechnicalSpecification = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colLiter = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colHP = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colCyl = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colTransmissSpeedCount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colTransmissAutomatic = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBandMilesPerGalon = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colMPG_Highway = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBandPriceCategory = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.myGridControlMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.myGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'carsBindingSource
            '
            Me.carsBindingSource.DataMember = "Cars"
            Me.carsBindingSource.DataSource = Me.carsDBDataSet
            '
            'carsDBDataSet
            '
            Me.carsDBDataSet.DataSetName = "CarsDBDataSet"
            Me.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'carsTableAdapter
            '
            Me.carsTableAdapter.ClearBeforeFill = True
            '
            'myGridControlMain
            '
            Me.myGridControlMain.DataSource = Me.carsBindingSource
            Me.myGridControlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.myGridControlMain.Location = New System.Drawing.Point(0, 0)
            Me.myGridControlMain.MainView = Me.myGridView
            Me.myGridControlMain.Name = "myGridControlMain"
            Me.myGridControlMain.Size = New System.Drawing.Size(638, 439)
            Me.myGridControlMain.TabIndex = 0
            Me.myGridControlMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.myGridView})
            '
            'myGridView
            '
            Me.myGridView.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBandGeneralInformation, Me.gridBandPriceCategory, Me.gridBand1})
            Me.myGridView.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colID, Me.colTrademark, Me.colModel, Me.colHP, Me.colLiter, Me.colCyl, Me.colTransmissSpeedCount, Me.colTransmissAutomatic, Me.colMPG_City, Me.colMPG_Highway, Me.colCategory, Me.colPrice, Me.colDescription})
            Me.myGridView.GridControl = Me.myGridControlMain
            Me.myGridView.Name = "myGridView"
            Me.myGridView.OptionsCustomization.AllowChangeBandParent = True
            Me.myGridView.OptionsCustomization.AllowChangeColumnParent = True
            '
            'gridBandGeneralInformation
            '
            Me.gridBandGeneralInformation.Caption = "General Information"
            Me.gridBandGeneralInformation.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBandDescription, Me.gridBandTechnicalSpecification, Me.gridBandMilesPerGalon})
            Me.gridBandGeneralInformation.MinWidth = 20
            Me.gridBandGeneralInformation.Name = "gridBandGeneralInformation"
            Me.gridBandGeneralInformation.Width = 675
            '
            'gridBandDescription
            '
            Me.gridBandDescription.Caption = "Description"
            Me.gridBandDescription.Columns.Add(Me.colID)
            Me.gridBandDescription.Columns.Add(Me.colModel)
            Me.gridBandDescription.Columns.Add(Me.colMPG_City)
            Me.gridBandDescription.Columns.Add(Me.colTrademark)
            Me.gridBandDescription.Columns.Add(Me.colDescription)
            Me.gridBandDescription.Columns.Add(Me.colCategory)
            Me.gridBandDescription.Name = "gridBandDescription"
            Me.gridBandDescription.Width = 300
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            '
            'colModel
            '
            Me.colModel.FieldName = "Model"
            Me.colModel.Name = "colModel"
            Me.colModel.Visible = True
            '
            'colMPG_City
            '
            Me.colMPG_City.FieldName = "MPG_City"
            Me.colMPG_City.Name = "colMPG_City"
            '
            'colTrademark
            '
            Me.colTrademark.FieldName = "Trademark"
            Me.colTrademark.Name = "colTrademark"
            Me.colTrademark.Visible = True
            '
            'colDescription
            '
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            '
            'colCategory
            '
            Me.colCategory.FieldName = "Category"
            Me.colCategory.Name = "colCategory"
            Me.colCategory.Visible = True
            '
            'gridBandTechnicalSpecification
            '
            Me.gridBandTechnicalSpecification.Caption = "Technical specification"
            Me.gridBandTechnicalSpecification.Columns.Add(Me.colLiter)
            Me.gridBandTechnicalSpecification.Columns.Add(Me.colHP)
            Me.gridBandTechnicalSpecification.Columns.Add(Me.colCyl)
            Me.gridBandTechnicalSpecification.Columns.Add(Me.colTransmissSpeedCount)
            Me.gridBandTechnicalSpecification.Columns.Add(Me.colTransmissAutomatic)
            Me.gridBandTechnicalSpecification.Name = "gridBandTechnicalSpecification"
            Me.gridBandTechnicalSpecification.Width = 375
            '
            'colLiter
            '
            Me.colLiter.FieldName = "Liter"
            Me.colLiter.Name = "colLiter"
            Me.colLiter.Visible = True
            '
            'colHP
            '
            Me.colHP.FieldName = "HP"
            Me.colHP.Name = "colHP"
            Me.colHP.Visible = True
            '
            'colCyl
            '
            Me.colCyl.FieldName = "Cyl"
            Me.colCyl.Name = "colCyl"
            Me.colCyl.Visible = True
            '
            'colTransmissSpeedCount
            '
            Me.colTransmissSpeedCount.FieldName = "TransmissSpeedCount"
            Me.colTransmissSpeedCount.Name = "colTransmissSpeedCount"
            Me.colTransmissSpeedCount.Visible = True
            '
            'colTransmissAutomatic
            '
            Me.colTransmissAutomatic.FieldName = "TransmissAutomatic"
            Me.colTransmissAutomatic.Name = "colTransmissAutomatic"
            Me.colTransmissAutomatic.Visible = True
            '
            'gridBandMilesPerGalon
            '
            Me.gridBandMilesPerGalon.Caption = "Miles per galon"
            Me.gridBandMilesPerGalon.Columns.Add(Me.colMPG_Highway)
            Me.gridBandMilesPerGalon.Name = "gridBandMilesPerGalon"
            Me.gridBandMilesPerGalon.Visible = False
            Me.gridBandMilesPerGalon.Width = 75
            '
            'colMPG_Highway
            '
            Me.colMPG_Highway.FieldName = "MPG_Highway"
            Me.colMPG_Highway.Name = "colMPG_Highway"
            '
            'gridBandPriceCategory
            '
            Me.gridBandPriceCategory.Caption = "Price & Categtory"
            Me.gridBandPriceCategory.Columns.Add(Me.colPrice)
            Me.gridBandPriceCategory.MinWidth = 20
            Me.gridBandPriceCategory.Name = "gridBandPriceCategory"
            Me.gridBandPriceCategory.Width = 75
            '
            'colPrice
            '
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            Me.colPrice.Visible = True
            '
            'gridBand1
            '
            Me.gridBand1.Caption = "gridBand1"
            Me.gridBand1.MinWidth = 20
            Me.gridBand1.Name = "gridBand1"
            '
            'defaultLookAndFeel1
            '
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue"
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(638, 439)
            Me.Controls.Add(Me.myGridControlMain)
            Me.Name = "MainForm"
            Me.Text = "Application main form"
            CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.myGridControlMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.myGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private carsDBDataSet As CarsDBDataSet
		Private carsBindingSource As System.Windows.Forms.BindingSource
		Private carsTableAdapter As TreeListCustomization.CarsDBDataSetTableAdapters.CarsTableAdapter
		Private myGridControlMain As MyGridControl
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private myGridView As MyAdvBandedGridView
		Private colID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colModel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colTrademark As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colDescription As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colLiter As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colHP As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCyl As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colTransmissSpeedCount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colTransmissAutomatic As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colMPG_City As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colMPG_Highway As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCategory As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBandGeneralInformation As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBandDescription As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBandTechnicalSpecification As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBandMilesPerGalon As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBandPriceCategory As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    End Class
End Namespace

