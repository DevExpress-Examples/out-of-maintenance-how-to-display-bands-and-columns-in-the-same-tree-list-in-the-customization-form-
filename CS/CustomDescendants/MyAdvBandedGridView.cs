using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.Customization;
using DevExpress.XtraGrid.Views.Base.Handler;

namespace TreeListCustomization
{
    class MyAdvBandedGridView : AdvBandedGridView
    {
        // constructors
        public MyAdvBandedGridView() : this(null) { }
        public MyAdvBandedGridView(GridControl grid) : base(grid) { }

        protected override string ViewName { get { return "MyAdvBandedGridView"; } }

        protected override CustomizationForm CreateCustomizationForm()
        {
            return new TreeListBandedCustomizationForm(this);
        }

        internal new BaseViewHandler Handler { get { return base.Handler; } }
    }
}
