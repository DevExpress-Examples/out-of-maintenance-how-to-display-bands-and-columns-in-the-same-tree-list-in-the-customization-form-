using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base.Handler;

namespace TreeListCustomization
{
    class MyBandedGridViewInfoRegistrator : BandedGridInfoRegistrator
    {
        public override string ViewName { get { return "MyBandedGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyBandedGridView(grid); }
    }
}
