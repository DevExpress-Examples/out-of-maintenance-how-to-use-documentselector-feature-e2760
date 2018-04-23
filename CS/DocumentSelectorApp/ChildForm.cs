using System;
using System.Collections.Generic;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.Samples.DocumentSelector {
    public partial class ChildForm : XtraForm {
        public ChildForm() {
            InitializeComponent();
        }
        static int groupIndex = 0;
        void Form2_Load(object sender, EventArgs e) {
            gridView1.FocusedRowChanged += Form2_FocusedRowChanged;
            IList<Photo> photos = new List<Photo>();
            int[] group = photoGroups[(groupIndex++) % photoGroups.Length];
            for(int i = 0; i < group.Length; i++) {
                photos.Add(
                    new Photo(
                        string.Format("Photo{0}", group[i]),
                        string.Format(@"Images\0{0}.jpg", group[i])
                    ));
            }
            gridControl1.DataSource = photos;
            gridView1.BestFitColumns();
        }
        void Form2_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            if(e.FocusedRowHandle == GridControl.InvalidRowHandle) return;
            pictureBox1.Image = LoadImage((string)gridView1.GetRowCellValue(e.FocusedRowHandle, "Path"));
        }
        static System.Drawing.Image LoadImage(string path) {
            System.Reflection.Assembly currentAssembly = System.Reflection.Assembly.GetAssembly(typeof(ChildForm));
            return ResourceImageHelper.CreateImageFromResources(
                "DevExpress.Samples.DocumentSelector." + path.Replace(@"\", "."), currentAssembly);
        }
        static int[][] photoGroups = new int[][]{
            new int[] { 5, 3, 7 },
            new int[] { 3, 4 },
            new int[] { 2, 3, 4, 5 },
            new int[] { 0, 1, 6, 8 }
        };
    }
    class Photo {
        public Photo(string name, string path) {
            nameCore = name;
            pathCore = path;
        }
        string nameCore;
        string pathCore;
        public string Name {
            get { return nameCore; }
        }
        public string Path {
            get { return pathCore; }
        }
    }
}