<!-- default file list -->
*Files to look at*:

* [MyAdvBandedGridView.cs](./CS/CustomDescendants/MyAdvBandedGridView.cs) (VB: [MyAdvBandedGridView.vb](./VB/CustomDescendants/MyAdvBandedGridView.vb))
* [MyAdvBandedGridViewInfoRegistrator.cs](./CS/CustomDescendants/MyAdvBandedGridViewInfoRegistrator.cs) (VB: [MyAdvBandedGridViewInfoRegistrator.vb](./VB/CustomDescendants/MyAdvBandedGridViewInfoRegistrator.vb))
* [MyBandedGridView.cs](./CS/CustomDescendants/MyBandedGridView.cs) (VB: [MyBandedGridView.vb](./VB/CustomDescendants/MyBandedGridView.vb))
* [MyBandedGridViewInfoRegistrator.cs](./CS/CustomDescendants/MyBandedGridViewInfoRegistrator.cs) (VB: [MyBandedGridViewInfoRegistrator.vb](./VB/CustomDescendants/MyBandedGridViewInfoRegistrator.vb))
* [MyGridControl.cs](./CS/CustomDescendants/MyGridControl.cs) (VB: [MyGridControl.vb](./VB/CustomDescendants/MyGridControl.vb))
* [TreeListBandedCustomizationForm.cs](./CS/CustomDescendants/TreeListBandedCustomizationForm.cs) (VB: [TreeListBandedCustomizationForm.vb](./VB/CustomDescendants/TreeListBandedCustomizationForm.vb))
* [TreeListForBands.cs](./CS/CustomDescendants/TreeListForBands.cs) (VB: [TreeListForBands.vb](./VB/CustomDescendants/TreeListForBands.vb))
* [MainForm.cs](./CS/MainForm.cs) (VB: [MainForm.vb](./VB/MainForm.vb))
<!-- default file list end -->
# How to display bands and columns in the same tree list in the customization form


<p>This example demonstrates how to display bands and columns in the same tree list in the customization form. <br />
It is a useful feature for BandedGridView and AdvBandedGridView, since it allows you to display columns and bands in a tree-like structure. <br />
For instance, if you hide any column, its parent band is shown in the Customization Form, too. <br />
It is true for bands as well. i.e. if a band has any parent band, this parent band will be shown in the TreeList as a parent node, to reflect a full hierarchy.  </p><br />
<p>In this example we replace the default XtraTabControl that contains two ListBoxes for columns and bands respectively, by a custom TreeList descendant.</p><p>In this descendant we override the OnMouse~ methods to provide the possibility to drag & drop column headers from/to TreeList.</p>

<br/>


