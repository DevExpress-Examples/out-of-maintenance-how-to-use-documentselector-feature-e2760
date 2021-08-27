<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128617798/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2760)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [ChildForm.cs](./CS/DocumentSelectorApp/ChildForm.cs) (VB: [ChildForm.vb](./VB/DocumentSelectorApp/ChildForm.vb))
* [MainForm.cs](./CS/DocumentSelectorApp/MainForm.cs) (VB: [MainForm.vb](./VB/DocumentSelectorApp/MainForm.vb))
<!-- default file list end -->
# How to use DocumentSelector feature


<p>This example demonstrates how to enable the Document Selector feature and customize the Document Selector's display settings.</p><p>The Document Selector feature allows you to enable the MS Visual Studio window selection style in your applications. To show the Document Selector, an end-user needs to press and hold CTRL+TAB or CTRL+SHIFT+TAB. Then, while still holding the CTRL or CTRL+SHIFT key, you can navigate to another page by pressing TAB or Arrow keys. Or you can select the required page within the Document Selector by clicking it with the mouse. </p><p>An in MS Visual Studio, if you quickly press and then release the CTRL+TAB, the previously active child window is activated. To activate the following child window, press and hold CTRL+TAB and then press TAB.</p><p>The  Document Selector feature is enabled via the XtraTabbedMdiManager.UseDocumentSelector property. The CustomDocumentSelectorSettings event is handled to customize the Document Selector's display settings. For instance, in this example the Footer and Header areas are made visible and their heights are changed. The CustomDocumentSelectorItem event is handled to display custom information within the Footer and Header areas when individual items are selected.</p><p>Take note of the UseFormIconAsPageImage property that allows icons associated with child windows to be displayed in tab page headers.</p><br />


<br/>


