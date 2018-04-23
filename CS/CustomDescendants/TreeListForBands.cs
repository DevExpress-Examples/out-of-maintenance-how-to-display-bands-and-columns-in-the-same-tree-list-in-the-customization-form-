using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraTreeList;
using System.Drawing;
using DevExpress.XtraTreeList.ViewInfo;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid.Handler;
using DevExpress.XtraTreeList.Painter;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Dragging;
using DevExpress.XtraGrid;
using System.Reflection;

namespace TreeListCustomization
{
    class TreeListForBands : TreeList
    {
        Point downPoint = Point.Empty;
        protected TreeListBandedCustomizationForm customizationForm_;
        protected object pressedItem_;

        public BandedGridView View { get { return (TreeListCustomizationForm.View as BandedGridView); } }        
        public TreeListBandedCustomizationForm TreeListCustomizationForm { get { return customizationForm_; } }
        public BaseViewHandler ViewHandler 
        {
            get {
                if (View is MyBandedGridView)
                    return (View as MyBandedGridView).Handler;
                else if (View is MyAdvBandedGridView)
                    return (View as MyAdvBandedGridView).Handler;
                else
                    return null; }        
        }

        public TreeListForBands(TreeListBandedCustomizationForm custForm) : base() 
        { 
            customizationForm_ = custForm; 
        }

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            Point pp = PointToView(p);
            MouseEventArgs me = new MouseEventArgs(e.Button, e.Clicks,
                pp.X, pp.Y, e.Delta);
            if (IsDragging)
            {
                DragController controller = typeof(GridControl).GetProperty("DragController", BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic).GetValue(View.GridControl, null) as DragController;

                if (me.Button != MouseButtons.Left)
                    controller.CancelDrag();
                else
                    controller.DoDragging(me); //DoDragging(me);
                return;
            }
            Size dragSize = System.Windows.Forms.SystemInformation.DragSize;
            if (PressedItem != null)
            {
                if ((e.Button & MouseButtons.Left) != 0)
                {
                    if (Math.Abs(p.X - downPoint.X) > dragSize.Width || Math.Abs(p.Y - downPoint.Y) > dragSize.Height)                    
                    {
                        if (ViewHandler != null)
                        {
                            (ViewHandler as GridHandler).DownPointHitInfo = View.CalcHitInfo(p);
                            (ViewHandler as GridHandler).DoStartDragObject(PressedItem, new Size(ClientSize.Width, 23));
                            if (IsDragging)
                                Capture = true;
                            else
                                PressedItem = null;
                            return;                            
                        }
                    }
                }
            }
            base.OnMouseMove(e);
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);
            downPoint = new Point(e.X, e.Y);
            object item = ItemByPoint(downPoint);
            PressedItem = item;
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Capture = true;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Capture = false;
            PressedItem = null;
            if (IsDragging)
            {
                Point pp = PointToView(new Point(e.X, e.Y));
                MouseEventArgs me = new MouseEventArgs(e.Button, e.Clicks, pp.X, pp.Y, e.Delta);
                DragController controller = typeof(GridControl).GetProperty("DragController", BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic).GetValue(View.GridControl, null) as DragController;
                controller.EndDrag(e);
            }
        }

        internal object PressedItem
        {
            get { return pressedItem_; }
            set { pressedItem_ = value; }
        }

        protected object ItemByPoint(Point pt)
        {
            RowInfo currentRowInfo = ViewInfo.GetRowInfoByPoint(pt);
            if (currentRowInfo != null)
            {
                GridBand band = currentRowInfo.Node[0] as GridBand;
                if (band != null && !band.Visible) return band;

                BandedGridColumn gridColumn = currentRowInfo.Node[0] as BandedGridColumn;
                if (gridColumn != null && (!gridColumn.Visible || gridColumn.OwnerBand == null)) return gridColumn;

                return null;
            }
            else return null;
        }

        private Point PointToView(Point p)
        {
            return TreeListCustomizationForm.ControlOwner.PointToClient(PointToScreen(p));
        }

        bool IsDragging { get { return View != null && (View as GridView).State == GridState.ColumnDragging; } }
    }
}
