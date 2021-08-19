
namespace Hangxing
{
    partial class fmMenu
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
            this.txtInfo = new Sunny.UI.UITextBox();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.LineColor = System.Drawing.Color.Black;
            this.Aside.Size = new System.Drawing.Size(250, 655);
            this.Aside.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.Aside_MenuItemClick);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.txtInfo);
            this.Header.Size = new System.Drawing.Size(1300, 110);
            // 
            // txtInfo
            // 
            this.txtInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.FillColor = System.Drawing.Color.White;
            this.txtInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInfo.Location = new System.Drawing.Point(0, 0);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInfo.Maximum = 2147483647D;
            this.txtInfo.Minimum = -2147483648D;
            this.txtInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(1300, 110);
            this.txtInfo.TabIndex = 8;
            this.txtInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // fmMenu
            // 
            this.AutoClosePage = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Name = "fmMenu";
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "航星信息管理系统";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMenu_FormClosing);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox txtInfo;
    }
}