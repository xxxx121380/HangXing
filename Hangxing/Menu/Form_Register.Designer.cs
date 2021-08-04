
namespace Hangxing
{
    partial class Form_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Register));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.btnCancel = new Sunny.UI.UISymbolButton();
            this.edtPassword = new Sunny.UI.UITextBox();
            this.edtUser = new Sunny.UI.UITextBox();
            this.uiLine1 = new Sunny.UI.UILine();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(80, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "航星文章视频管理系统";
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.White;
            this.uiPanel1.Controls.Add(this.uiTextBox1);
            this.uiPanel1.Controls.Add(this.uiSymbolButton1);
            this.uiPanel1.Controls.Add(this.btnCancel);
            this.uiPanel1.Controls.Add(this.edtPassword);
            this.uiPanel1.Controls.Add(this.edtUser);
            this.uiPanel1.Controls.Add(this.uiLine1);
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(424, 128);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(207, 235);
            this.uiPanel1.TabIndex = 14;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.EnterAsTab = true;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(12, 141);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.PasswordChar = '*';
            this.uiTextBox1.Size = new System.Drawing.Size(182, 29);
            this.uiTextBox1.Symbol = 61475;
            this.uiTextBox1.SymbolSize = 22;
            this.uiTextBox1.TabIndex = 2;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "请确认密码";
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.ForestGreen;
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.Green;
            this.uiSymbolButton1.FillPressColor = System.Drawing.Color.Green;
            this.uiSymbolButton1.FillSelectedColor = System.Drawing.Color.Green;
            this.uiSymbolButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(13, 186);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolButton1.RectColor = System.Drawing.Color.ForestGreen;
            this.uiSymbolButton1.RectHoverColor = System.Drawing.Color.ForestGreen;
            this.uiSymbolButton1.RectPressColor = System.Drawing.Color.ForestGreen;
            this.uiSymbolButton1.RectSelectedColor = System.Drawing.Color.DarkGreen;
            this.uiSymbolButton1.Size = new System.Drawing.Size(86, 29);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.StyleCustomMode = true;
            this.uiSymbolButton1.Symbol = 62108;
            this.uiSymbolButton1.TabIndex = 4;
            this.uiSymbolButton1.Text = "注册";
            this.uiSymbolButton1.TipsColor = System.Drawing.Color.ForestGreen;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnCancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCancel.Location = new System.Drawing.Point(110, 187);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnCancel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCancel.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.btnCancel.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.btnCancel.Size = new System.Drawing.Size(86, 29);
            this.btnCancel.Style = Sunny.UI.UIStyle.Red;
            this.btnCancel.StyleCustomMode = true;
            this.btnCancel.Symbol = 61453;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // edtPassword
            // 
            this.edtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPassword.EnterAsTab = true;
            this.edtPassword.FillColor = System.Drawing.Color.White;
            this.edtPassword.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.edtPassword.Location = new System.Drawing.Point(12, 104);
            this.edtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtPassword.Maximum = 2147483647D;
            this.edtPassword.Minimum = -2147483648D;
            this.edtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.edtPassword.PasswordChar = '*';
            this.edtPassword.Size = new System.Drawing.Size(182, 29);
            this.edtPassword.Symbol = 61475;
            this.edtPassword.SymbolSize = 22;
            this.edtPassword.TabIndex = 1;
            this.edtPassword.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtPassword.Watermark = "请输入密码";
            // 
            // edtUser
            // 
            this.edtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtUser.EnterAsTab = true;
            this.edtUser.FillColor = System.Drawing.Color.White;
            this.edtUser.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.edtUser.Location = new System.Drawing.Point(12, 66);
            this.edtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtUser.Maximum = 2147483647D;
            this.edtUser.Minimum = -2147483648D;
            this.edtUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.edtUser.Name = "edtUser";
            this.edtUser.Padding = new System.Windows.Forms.Padding(5);
            this.edtUser.Size = new System.Drawing.Size(182, 29);
            this.edtUser.Symbol = 61447;
            this.edtUser.SymbolSize = 22;
            this.edtUser.TabIndex = 3;
            this.edtUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtUser.Watermark = "请输入账号";
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(20, 33);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(164, 16);
            this.uiLine1.TabIndex = 2;
            this.uiLine1.Text = "用户注册";
            // 
            // Form_Register
            // 
            this.AllowShowTitle = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangxing.Properties.Resources.Login4;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Register";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.ShowTitle = false;
            this.Text = "Form_Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public Sunny.UI.UIPanel uiPanel1;
        public Sunny.UI.UITextBox uiTextBox1;
        public Sunny.UI.UISymbolButton uiSymbolButton1;
        public Sunny.UI.UISymbolButton btnCancel;
        public Sunny.UI.UITextBox edtPassword;
        public Sunny.UI.UITextBox edtUser;
        public Sunny.UI.UILine uiLine1;
    }
}