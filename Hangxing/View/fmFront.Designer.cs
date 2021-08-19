
namespace Hangxing.View
{
    partial class fmFront
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
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.utbDownload = new Sunny.UI.UITextBox();
            this.ubtSelectLocate = new Sunny.UI.UIButton();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.ub = new Sunny.UI.UISymbolButton();
            this.uslUser = new Sunny.UI.UISymbolLabel();
            this.utbUser = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.utbDownload);
            this.uiGroupBox1.Controls.Add(this.ubtSelectLocate);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(18, 3);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(950, 200);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "下载设置";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // utbDownload
            // 
            this.utbDownload.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.utbDownload.FillColor = System.Drawing.Color.White;
            this.utbDownload.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.utbDownload.Location = new System.Drawing.Point(131, 39);
            this.utbDownload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.utbDownload.Maximum = 2147483647D;
            this.utbDownload.Minimum = -2147483648D;
            this.utbDownload.MinimumSize = new System.Drawing.Size(1, 1);
            this.utbDownload.Name = "utbDownload";
            this.utbDownload.Size = new System.Drawing.Size(335, 29);
            this.utbDownload.TabIndex = 1;
            this.utbDownload.Text = "下载路径";
            this.utbDownload.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ubtSelectLocate
            // 
            this.ubtSelectLocate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubtSelectLocate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ubtSelectLocate.Location = new System.Drawing.Point(10, 37);
            this.ubtSelectLocate.MinimumSize = new System.Drawing.Size(1, 1);
            this.ubtSelectLocate.Name = "ubtSelectLocate";
            this.ubtSelectLocate.Size = new System.Drawing.Size(114, 31);
            this.ubtSelectLocate.TabIndex = 0;
            this.ubtSelectLocate.Text = "选择下载路径";
            this.ubtSelectLocate.Click += new System.EventHandler(this.ubtSelectLocate_Click);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.uiSymbolLabel2);
            this.uiGroupBox2.Controls.Add(this.uiSymbolLabel1);
            this.uiGroupBox2.Controls.Add(this.utbUser);
            this.uiGroupBox2.Controls.Add(this.uslUser);
            this.uiGroupBox2.Controls.Add(this.ub);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(18, 205);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(950, 200);
            this.uiGroupBox2.TabIndex = 2;
            this.uiGroupBox2.Text = "用户信息";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ub
            // 
            this.ub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ub.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ub.Location = new System.Drawing.Point(22, 155);
            this.ub.MinimumSize = new System.Drawing.Size(1, 1);
            this.ub.Name = "ub";
            this.ub.Size = new System.Drawing.Size(50, 35);
            this.ub.TabIndex = 0;
            this.ub.Text = "uiSymbolButton1";
            // 
            // uslUser
            // 
            this.uslUser.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uslUser.Location = new System.Drawing.Point(10, 33);
            this.uslUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.uslUser.Name = "uslUser";
            this.uslUser.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uslUser.Size = new System.Drawing.Size(84, 35);
            this.uslUser.Symbol = 61447;
            this.uslUser.TabIndex = 1;
            this.uslUser.Text = "用户名";
            // 
            // utbUser
            // 
            this.utbUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.utbUser.FillColor = System.Drawing.Color.White;
            this.utbUser.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.utbUser.Location = new System.Drawing.Point(101, 36);
            this.utbUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.utbUser.Maximum = 2147483647D;
            this.utbUser.Minimum = -2147483648D;
            this.utbUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.utbUser.Name = "utbUser";
            this.utbUser.Size = new System.Drawing.Size(133, 29);
            this.utbUser.TabIndex = 2;
            this.utbUser.Text = "用户名";
            this.utbUser.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(10, 73);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(84, 35);
            this.uiSymbolLabel1.Symbol = 61447;
            this.uiSymbolLabel1.TabIndex = 3;
            this.uiSymbolLabel1.Text = "用户名";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(10, 114);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(84, 35);
            this.uiSymbolLabel2.Symbol = 61447;
            this.uiSymbolLabel2.TabIndex = 4;
            this.uiSymbolLabel2.Text = "用户名";
            // 
            // fmFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 633);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "fmFront";
            this.Text = "fmFront";
            this.Load += new System.EventHandler(this.fmFront_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton ubtSelectLocate;
        private Sunny.UI.UITextBox utbDownload;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox utbUser;
        private Sunny.UI.UISymbolLabel uslUser;
        private Sunny.UI.UISymbolButton ub;
    }
}