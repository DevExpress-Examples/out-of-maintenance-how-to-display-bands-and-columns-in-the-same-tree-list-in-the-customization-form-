namespace TreeListCustomization
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsDBDataSet = new TreeListCustomization.CarsDBDataSet();
            this.carsTableAdapter = new TreeListCustomization.CarsDBDataSetTableAdapters.CarsTableAdapter();
            this.myGridControlMain = new TreeListCustomization.MyGridControl();
            this.myGridView = new TreeListCustomization.MyAdvBandedGridView();
            this.gridBandGeneralInformation = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBandDescription = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colModel = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMPG_City = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTrademark = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDescription = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCategory = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBandTechnicalSpecification = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colLiter = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCyl = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTransmissSpeedCount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTransmissAutomatic = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBandMilesPerGalon = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colMPG_Highway = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBandPriceCategory = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.carsDBDataSet;
            // 
            // carsDBDataSet
            // 
            this.carsDBDataSet.DataSetName = "CarsDBDataSet";
            this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // myGridControlMain
            // 
            this.myGridControlMain.DataSource = this.carsBindingSource;
            this.myGridControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControlMain.Location = new System.Drawing.Point(0, 0);
            this.myGridControlMain.MainView = this.myGridView;
            this.myGridControlMain.Name = "myGridControlMain";
            this.myGridControlMain.Size = new System.Drawing.Size(638, 439);
            this.myGridControlMain.TabIndex = 0;
            this.myGridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView});
            // 
            // myGridView
            // 
            this.myGridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBandGeneralInformation,
            this.gridBandPriceCategory,
            this.gridBand1});
            this.myGridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colID,
            this.colTrademark,
            this.colModel,
            this.colHP,
            this.colLiter,
            this.colCyl,
            this.colTransmissSpeedCount,
            this.colTransmissAutomatic,
            this.colMPG_City,
            this.colMPG_Highway,
            this.colCategory,
            this.colPrice,
            this.colDescription});
            this.myGridView.GridControl = this.myGridControlMain;
            this.myGridView.Name = "myGridView";
            this.myGridView.OptionsCustomization.AllowChangeBandParent = true;
            this.myGridView.OptionsCustomization.AllowChangeColumnParent = true;
            // 
            // gridBandGeneralInformation
            // 
            this.gridBandGeneralInformation.Caption = "General Information";
            this.gridBandGeneralInformation.Children.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBandDescription,
            this.gridBandTechnicalSpecification,
            this.gridBandMilesPerGalon});
            this.gridBandGeneralInformation.MinWidth = 20;
            this.gridBandGeneralInformation.Name = "gridBandGeneralInformation";
            this.gridBandGeneralInformation.Width = 675;
            // 
            // gridBandDescription
            // 
            this.gridBandDescription.Caption = "Description";
            this.gridBandDescription.Columns.Add(this.colID);
            this.gridBandDescription.Columns.Add(this.colModel);
            this.gridBandDescription.Columns.Add(this.colMPG_City);
            this.gridBandDescription.Columns.Add(this.colTrademark);
            this.gridBandDescription.Columns.Add(this.colDescription);
            this.gridBandDescription.Columns.Add(this.colCategory);
            this.gridBandDescription.Name = "gridBandDescription";
            this.gridBandDescription.Width = 300;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            // 
            // colMPG_City
            // 
            this.colMPG_City.FieldName = "MPG_City";
            this.colMPG_City.Name = "colMPG_City";
            // 
            // colTrademark
            // 
            this.colTrademark.FieldName = "Trademark";
            this.colTrademark.Name = "colTrademark";
            this.colTrademark.Visible = true;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            // 
            // gridBandTechnicalSpecification
            // 
            this.gridBandTechnicalSpecification.Caption = "Technical specification";
            this.gridBandTechnicalSpecification.Columns.Add(this.colLiter);
            this.gridBandTechnicalSpecification.Columns.Add(this.colHP);
            this.gridBandTechnicalSpecification.Columns.Add(this.colCyl);
            this.gridBandTechnicalSpecification.Columns.Add(this.colTransmissSpeedCount);
            this.gridBandTechnicalSpecification.Columns.Add(this.colTransmissAutomatic);
            this.gridBandTechnicalSpecification.Name = "gridBandTechnicalSpecification";
            this.gridBandTechnicalSpecification.Width = 375;
            // 
            // colLiter
            // 
            this.colLiter.FieldName = "Liter";
            this.colLiter.Name = "colLiter";
            this.colLiter.Visible = true;
            // 
            // colHP
            // 
            this.colHP.FieldName = "HP";
            this.colHP.Name = "colHP";
            this.colHP.Visible = true;
            // 
            // colCyl
            // 
            this.colCyl.FieldName = "Cyl";
            this.colCyl.Name = "colCyl";
            this.colCyl.Visible = true;
            // 
            // colTransmissSpeedCount
            // 
            this.colTransmissSpeedCount.FieldName = "TransmissSpeedCount";
            this.colTransmissSpeedCount.Name = "colTransmissSpeedCount";
            this.colTransmissSpeedCount.Visible = true;
            // 
            // colTransmissAutomatic
            // 
            this.colTransmissAutomatic.FieldName = "TransmissAutomatic";
            this.colTransmissAutomatic.Name = "colTransmissAutomatic";
            this.colTransmissAutomatic.Visible = true;
            // 
            // gridBandMilesPerGalon
            // 
            this.gridBandMilesPerGalon.Caption = "Miles per galon";
            this.gridBandMilesPerGalon.Columns.Add(this.colMPG_Highway);
            this.gridBandMilesPerGalon.Name = "gridBandMilesPerGalon";
            this.gridBandMilesPerGalon.Visible = false;
            this.gridBandMilesPerGalon.Width = 75;
            // 
            // colMPG_Highway
            // 
            this.colMPG_Highway.FieldName = "MPG_Highway";
            this.colMPG_Highway.Name = "colMPG_Highway";
            // 
            // gridBandPriceCategory
            // 
            this.gridBandPriceCategory.Caption = "Price & Categtory";
            this.gridBandPriceCategory.Columns.Add(this.colPrice);
            this.gridBandPriceCategory.MinWidth = 20;
            this.gridBandPriceCategory.Name = "gridBandPriceCategory";
            this.gridBandPriceCategory.Width = 75;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blue";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 439);
            this.Controls.Add(this.myGridControlMain);
            this.Name = "MainForm";
            this.Text = "Application main form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CarsDBDataSet carsDBDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private TreeListCustomization.CarsDBDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private MyGridControl myGridControlMain;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private MyAdvBandedGridView myGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colModel;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTrademark;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLiter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCyl;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTransmissSpeedCount;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTransmissAutomatic;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMPG_City;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMPG_Highway;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCategory;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandGeneralInformation;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandTechnicalSpecification;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandMilesPerGalon;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandPriceCategory;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
    }
}

