using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Dragging;

namespace TreeListCustomization
{
    class MyGridControl : GridControl
    {
        protected override BaseView CreateDefaultView() { return CreateView("MyBandedGridView"); }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyBandedGridViewInfoRegistrator());
            collection.Add(new MyAdvBandedGridViewInfoRegistrator());
        }

        internal new DragController DragController { get { return base.DragController; } }
    }

}
