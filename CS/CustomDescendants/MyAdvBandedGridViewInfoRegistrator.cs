using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;

namespace TreeListCustomization
{
    class MyAdvBandedGridViewInfoRegistrator : AdvBandedGridInfoRegistrator
    {
        public override string ViewName { get { return "MyAdvBandedGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyAdvBandedGridView(grid); }
    }
}
