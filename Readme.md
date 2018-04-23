# How to display bands and columns in the same tree list in the customization form


<p>This example demonstrates how to display bands and columns in the same tree list in the customization form. <br />
It is a useful feature for BandedGridView and AdvBandedGridView, since it allows you to display columns and bands in a tree-like structure. <br />
For instance, if you hide any column, its parent band is shown in the Customization Form, too. <br />
It is true for bands as well. i.e. if a band has any parent band, this parent band will be shown in the TreeList as a parent node, to reflect a full hierarchy.  </p><br />
<p>In this example we replace the default XtraTabControl that contains two ListBoxes for columns and bands respectively, by a custom TreeList descendant.</p><p>In this descendant we override the OnMouse~ methods to provide the possibility to drag & drop column headers from/to TreeList.</p>

<br/>


