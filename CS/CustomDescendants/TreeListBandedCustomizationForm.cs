using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.BandedGrid.Customization;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using System.Collections;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;

namespace TreeListCustomization
{
    class TreeListBandedCustomizationForm : BandedCustomizationForm
    {
        TreeList bandsColumnTreeList_;
        TreeList BandsColumnTreeList { get { return bandsColumnTreeList_; } }
        ArrayList UnvisibleList = new ArrayList();
        SkinHeaderObjectPainter customCellPainter = new SkinHeaderObjectPainter(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel);

        public TreeListBandedCustomizationForm(BandedGridView gridView) : base(gridView) { }

        protected override void CreateListBox()
        {
            bandsColumnTreeList_ = new TreeListForBands(this);
            TreeListColumn newColumn = bandsColumnTreeList_.Columns.Add();
            newColumn.FieldName = "Content";
            newColumn.VisibleIndex = 0;
            newColumn.OptionsColumn.AllowEdit = false;
            newColumn.OptionsColumn.ReadOnly = true;

            bandsColumnTreeList_.OptionsView.ShowColumns = false;
            bandsColumnTreeList_.OptionsView.ShowIndicator = false;
            FillBandsColumnTreeList();
            bandsColumnTreeList_.Dock = DockStyle.Fill;
            Controls.Add(bandsColumnTreeList_);
            BandsColumnTreeList.CustomDrawNodeCell += new CustomDrawNodeCellEventHandler(BandsColumnTreeList_CustomDrawNodeCell);
        }

        void BandsColumnTreeList_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            GridBand band = e.Node[0] as GridBand;
            if (band != null && !band.Visible) DrawNodeElementAsColumn(e);

            BandedGridColumn gridColumn = e.Node[0] as BandedGridColumn;
            if (gridColumn != null && (!gridColumn.Visible || gridColumn.OwnerBand == null)) DrawNodeElementAsColumn(e);
        }

        void DrawNodeElementAsColumn(CustomDrawNodeCellEventArgs e)
        {
            HeaderObjectInfoArgs infoArgs = new HeaderObjectInfoArgs();
            infoArgs.Bounds = Rectangle.Inflate(e.Bounds, -1, 0);
            infoArgs.Cache = e.Cache;
            infoArgs.Caption = e.CellText;
            infoArgs.CaptionRect = e.Bounds;
            infoArgs.TopLeft = new Point(infoArgs.CaptionRect.X, infoArgs.CaptionRect.Y + 3);
            customCellPainter.DrawObject(infoArgs);
            e.Handled = true;    
        }

        public override void UpdateListBox() {}

        protected override void SetDefaultFormSize() {}

        public override void CheckAndUpdate()
        {
            BandsColumnTreeList.Nodes.Clear();
            FillBandsColumnTreeList();
        }

        void FillUnvisibleElementsArray()
        {
            UnvisibleList.Clear();
            foreach (GridBand band in View.Bands)
            {
                if (!band.Visible && band.OptionsBand.ShowInCustomizationForm)
                {
                    UnvisibleList.Add(band);                    
                }
                AddBandChildren(band);
            }
            foreach (GridColumn column in View.Columns)
            {
                if (column.CanShowInCustomizationForm) 
                {
                    UnvisibleList.Add(column);
                }
            }        
        }

        void AddBandChildren(GridBand band)
        {
            if (!band.HasChildren) return;
            foreach (GridBand bd in band.Children)
            {
                if (!bd.Visible && bd.OptionsBand.ShowInCustomizationForm)
                {
                    UnvisibleList.Add(bd);
                    AddBandChildren(bd);
                }
            }
        }

        void FillBandsColumnTreeList()
        {
            UnvisibleList.Clear();
            FillUnvisibleElementsArray();
            foreach (object item in UnvisibleList)
            {
                TreeListNode newNode = null;
                if (item is GridBand) newNode = AddBandAsTreeNode(item as GridBand);
                if (item is BandedGridColumn) newNode = AddBandedColumnAsTreeNode(item as BandedGridColumn);
            } 
        }

        TreeListNode AddBandAsTreeNode(GridBand band)
        {
            if (band.ParentBand == null)
            {
                TreeListNode currentNode = BandsColumnTreeList.FindNodeByFieldValue("Content", band);
                if (currentNode == null) currentNode = BandsColumnTreeList.AppendNode(new object[] { band }, null);
                return currentNode;
            }
            else
            {
                TreeListNode parentNode = AddBandAsTreeNode(band.ParentBand);
                return BandsColumnTreeList.AppendNode(new object[] { band }, parentNode);
            }
        }


        TreeListNode AddBandedColumnAsTreeNode(BandedGridColumn bandedColumn)
        {
            if (bandedColumn.OwnerBand == null) return BandsColumnTreeList.AppendNode(new object[] { bandedColumn }, null);
            else
            {
                TreeListNode parentNode = BandsColumnTreeList.FindNodeByFieldValue("Content", bandedColumn.OwnerBand);
                if (parentNode == null) parentNode = AddBandAsTreeNode(bandedColumn.OwnerBand);
                return BandsColumnTreeList.AppendNode(new object[] { bandedColumn }, parentNode);
            }
        }
    }
}
