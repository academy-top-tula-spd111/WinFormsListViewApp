namespace WinFormsListViewApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Автомобили",
            "Легковые",
            "Грузовые",
            "Автобусы"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Самолеты", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Поезда", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Корабли", 3);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnLarge = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.listViewDirs = new System.Windows.Forms.ListView();
            this.imgListIconsLarge = new System.Windows.Forms.ImageList(this.components);
            this.imgListIconsSmall = new System.Windows.Forms.ImageList(this.components);
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 2;
            listViewItem4.Checked = true;
            listViewItem4.StateImageIndex = 3;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.LargeImageList = this.imageListLarge;
            this.listView1.Location = new System.Drawing.Point(12, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(216, 330);
            this.listView1.SmallImageList = this.imageListSmall;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Транспорт";
            this.columnHeader1.Width = 100;
            // 
            // imageListLarge
            // 
            this.imageListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "cars.png");
            this.imageListLarge.Images.SetKeyName(1, "plains.png");
            this.imageListLarge.Images.SetKeyName(2, "train.png");
            this.imageListLarge.Images.SetKeyName(3, "ships.png");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "cars.png");
            this.imageListSmall.Images.SetKeyName(1, "plains.png");
            this.imageListSmall.Images.SetKeyName(2, "train.png");
            this.imageListSmall.Images.SetKeyName(3, "ships.png");
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(284, 380);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(75, 23);
            this.btnSmall.TabIndex = 1;
            this.btnSmall.Text = "Small Icon";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnLarge
            // 
            this.btnLarge.Location = new System.Drawing.Point(408, 380);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(75, 23);
            this.btnLarge.TabIndex = 1;
            this.btnLarge.Text = "Large Icon";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(667, 380);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 1;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(541, 380);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // listViewDirs
            // 
            this.listViewDirs.LargeImageList = this.imgListIconsLarge;
            this.listViewDirs.Location = new System.Drawing.Point(284, 67);
            this.listViewDirs.Name = "listViewDirs";
            this.listViewDirs.Size = new System.Drawing.Size(458, 288);
            this.listViewDirs.SmallImageList = this.imgListIconsSmall;
            this.listViewDirs.TabIndex = 2;
            this.listViewDirs.UseCompatibleStateImageBehavior = false;
            // 
            // imgListIconsLarge
            // 
            this.imgListIconsLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListIconsLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListIconsLarge.ImageStream")));
            this.imgListIconsLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListIconsLarge.Images.SetKeyName(0, "folder.png");
            this.imgListIconsLarge.Images.SetKeyName(1, "file.png");
            this.imgListIconsLarge.Images.SetKeyName(2, "txt.png");
            this.imgListIconsLarge.Images.SetKeyName(3, "pdf.png");
            this.imgListIconsLarge.Images.SetKeyName(4, "docx.png");
            this.imgListIconsLarge.Images.SetKeyName(5, "jpg.png");
            this.imgListIconsLarge.Images.SetKeyName(6, "png.png");
            // 
            // imgListIconsSmall
            // 
            this.imgListIconsSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListIconsSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListIconsSmall.ImageStream")));
            this.imgListIconsSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListIconsSmall.Images.SetKeyName(0, "folder.png");
            this.imgListIconsSmall.Images.SetKeyName(1, "file.png");
            this.imgListIconsSmall.Images.SetKeyName(2, "txt.png");
            this.imgListIconsSmall.Images.SetKeyName(3, "pdf.png");
            this.imgListIconsSmall.Images.SetKeyName(4, "docx.png");
            this.imgListIconsSmall.Images.SetKeyName(5, "jpg.png");
            this.imgListIconsSmall.Images.SetKeyName(6, "png.png");
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(284, 25);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(343, 23);
            this.txtPath.TabIndex = 3;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(644, 24);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(98, 23);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View path";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.listViewDirs);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnLarge);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ImageList imageListSmall;
        private ImageList imageListLarge;
        private Button btnSmall;
        private Button btnLarge;
        private Button btnDetail;
        private Button btnList;
        private ColumnHeader columnHeader2;
        private ListView listViewDirs;
        private ImageList imgListIconsLarge;
        private ImageList imgListIconsSmall;
        private TextBox txtPath;
        private Button btnView;
    }
}