using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.Customization;
using System.ComponentModel;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.Utils;

namespace TreeListCustomization
{
    class MyBandedGridView : BandedGridView
    {
        // constructors
        public MyBandedGridView() : this(null) { }
        public MyBandedGridView(GridControl grid) : base(grid) { }

        protected override string ViewName { get { return "MyBandedGridView"; } }

        protected override CustomizationForm CreateCustomizationForm()
        {
            return new TreeListBandedCustomizationForm(this);
        }

        internal new BaseViewHandler Handler { get { return base.Handler; } }
    }
}
