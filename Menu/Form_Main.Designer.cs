namespace Hangxing
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MainTabControl = new Sunny.UI.UITabControl();
            this.Aside = new Sunny.UI.UINavMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.525326F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.47468F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 698);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.5748F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.42519F));
            this.tableLayoutPanel2.Controls.Add(this.Aside, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MainTabControl, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1270, 633);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // MainTabControl
            // 
            this.MainTabControl.AutoClosePage = true;
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MainTabControl.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.MainTabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainTabControl.ItemSize = new System.Drawing.Size(150, 40);
            this.MainTabControl.Location = new System.Drawing.Point(150, 3);
            this.MainTabControl.MainPage = "控制台";
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.ShowCloseButton = true;
            this.MainTabControl.ShowToolTips = true;
            this.MainTabControl.Size = new System.Drawing.Size(1117, 627);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabControl.TabIndex = 5;
            // 
            // Aside
            // 
            this.Aside.BackColor = System.Drawing.Color.Black;
            this.Aside.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Aside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Aside.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.Aside.ExpandSelectFirst = true;
            this.Aside.FillColor = System.Drawing.Color.Black;
            this.Aside.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Aside.FullRowSelect = true;
            this.Aside.HoverColor = System.Drawing.Color.Black;
            this.Aside.ItemHeight = 50;
            this.Aside.Location = new System.Drawing.Point(3, 3);
            this.Aside.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Aside.Name = "Aside";
            this.Aside.ShowLines = false;
            this.Aside.Size = new System.Drawing.Size(141, 627);
            this.Aside.Style = Sunny.UI.UIStyle.Custom;
            this.Aside.TabIndex = 6;
            this.Aside.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.Aside_MenuItemClick_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(50, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "航星文章视频管理系统";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.17254F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.82746F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(361, 46);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1280, 728);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.ShowDragStretch = true;
            this.ShowRadius = false;
            this.ShowRect = false;
            this.ShowShadow = true;
            this.Text = "航星文章视频管理系统";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleHeight = 31;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UITabControl MainTabControl;
        private Sunny.UI.UINavMenu Aside;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}