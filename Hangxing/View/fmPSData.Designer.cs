
namespace Hangxing.View
{
    partial class fmPSData
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
            this.TextBoxPath = new Sunny.UI.UITextBox();
            this.ButtonSelectPath = new Sunny.UI.UIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiListBox1 = new Sunny.UI.UIListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxPath
            // 
            this.TextBoxPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPath.FillColor = System.Drawing.Color.White;
            this.TextBoxPath.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TextBoxPath.Location = new System.Drawing.Point(48, 28);
            this.TextBoxPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxPath.Maximum = 2147483647D;
            this.TextBoxPath.Minimum = -2147483648D;
            this.TextBoxPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBoxPath.Name = "TextBoxPath";
            this.TextBoxPath.Size = new System.Drawing.Size(347, 51);
            this.TextBoxPath.TabIndex = 0;
            this.TextBoxPath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonSelectPath
            // 
            this.ButtonSelectPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSelectPath.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ButtonSelectPath.Location = new System.Drawing.Point(422, 36);
            this.ButtonSelectPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.ButtonSelectPath.Name = "ButtonSelectPath";
            this.ButtonSelectPath.Size = new System.Drawing.Size(100, 35);
            this.ButtonSelectPath.TabIndex = 1;
            this.ButtonSelectPath.Text = "选择路径";
            this.ButtonSelectPath.Click += new System.EventHandler(this.ButtonSelectPath_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(422, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 289);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // uiListBox1
            // 
            this.uiListBox1.FillColor = System.Drawing.Color.White;
            this.uiListBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiListBox1.FormatString = "";
            this.uiListBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiListBox1.Location = new System.Drawing.Point(48, 118);
            this.uiListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiListBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiListBox1.Name = "uiListBox1";
            this.uiListBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiListBox1.Size = new System.Drawing.Size(347, 289);
            this.uiListBox1.TabIndex = 4;
            this.uiListBox1.Text = "uiListBox1";
            this.uiListBox1.ItemClick += new System.EventHandler(this.uiListBox1_ItemClick);
            // 
            // fmPSData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiListBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonSelectPath);
            this.Controls.Add(this.TextBoxPath);
            this.Name = "fmPSData";
            this.Text = "fmPSData";
            this.Load += new System.EventHandler(this.fmPSData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox TextBoxPath;
        private Sunny.UI.UIButton ButtonSelectPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIListBox uiListBox1;
    }
}