using System;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraTabbedMdi;

namespace DevExpress.Samples.DocumentSelector {
    public partial class MainForm : XtraForm {
        public MainForm() {
            InitializeComponent();
            /*** Floating options ***/
            xtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.True;
            xtraTabbedMdiManager1.FloatPageDragMode = FloatPageDragMode.Preview;
            #region #1
            /*** To show child forms' icons in page headers ***/
            xtraTabbedMdiManager1.UseFormIconAsPageImage = DefaultBoolean.True;
            /*** Enable the Document Selector feature (use CTRL+TAB) ***/
            xtraTabbedMdiManager1.UseDocumentSelector = DefaultBoolean.True;
            #endregion #1
            xtraTabbedMdiManager1.CustomDocumentSelectorSettings += xtraTabbedMdiManager1_CustomDocumentSelectorSettings;
            xtraTabbedMdiManager1.CustomDocumentSelectorItem += xtraTabbedMdiManager1_CustomDocumentSelectorItem;
        }
        #region #2
        void Form1_Load(object sender, EventArgs e) {
            AddChild("Recent", "Shows the recently viewed photos");
            AddChild("Favorites", "My favorite photos");
            AddChild("Published", "These photos are published in my blog");
            AddChild("Unsorted", "Not reviewed photos");
        }
        void AddChild(string category, string tag) {
            ChildForm categoryForm = new ChildForm();
            categoryForm.Text = category;
            categoryForm.MdiParent = this;
            categoryForm.Tag = tag;
            categoryForm.Show();
        }
        void xtraTabbedMdiManager1_CustomDocumentSelectorSettings(object sender, CustomDocumentSelectorSettingsEventArgs e) {
            // Define max visible row count (12 by default )
            e.Selector.GalleryMaxRows = 4;
            // Define width of item column (by default this value is calculated automatically)
            e.Selector.GalleryColumnWidth = 140;

            e.Selector.ShowHeader = true; 
            e.Selector.ShowFooter = true;

            e.Selector.HeaderHeight = 50;
            e.Selector.FooterHeight = 50;
        }
        void xtraTabbedMdiManager1_CustomDocumentSelectorItem(object sender, CustomDocumentSelectorItemEventArgs e) {
            e.Item.FooterText = (string)e.Item.Page.MdiChild.Tag;
            e.Item.HeaderText = string.Format("Photo Category: {0}", e.Item.Caption);
        }
        #endregion #2
    }
}