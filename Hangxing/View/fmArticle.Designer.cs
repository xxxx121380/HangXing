
namespace Hangxing.View
{
    partial class fmArticle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dockLayout1 = new DockLayout();
            this.ubtSave = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.uiDatePicker2 = new Sunny.UI.UIDatePicker();
            this.btnImport = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.dockLayout2 = new DockLayout();
            this.uiDataGridViewFooter1 = new Sunny.UI.UIDataGridViewFooter();
            this.dgvArticle = new Sunny.UI.UIDataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.cmsArticle = new Sunny.UI.UIContextMenuStrip();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfwordhtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.dockLayout1.SuspendLayout();
            this.dockLayout2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).BeginInit();
            this.cmsArticle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dockLayout1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dockLayout2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 633);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dockLayout1
            // 
            this.dockLayout1.Controls.Add(this.ubtSave);
            this.dockLayout1.Controls.Add(this.uiSymbolButton1);
            this.dockLayout1.Controls.Add(this.uiComboBox1);
            this.dockLayout1.Controls.Add(this.uiCheckBox1);
            this.dockLayout1.Controls.Add(this.uiDatePicker1);
            this.dockLayout1.Controls.Add(this.uiDatePicker2);
            this.dockLayout1.Controls.Add(this.btnImport);
            this.dockLayout1.Controls.Add(this.uiButton2);
            this.dockLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockLayout1.DockFlags = new int[] {
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0};
            this.dockLayout1.Location = new System.Drawing.Point(3, 3);
            this.dockLayout1.Name = "dockLayout1";
            this.dockLayout1.Size = new System.Drawing.Size(980, 39);
            this.dockLayout1.TabIndex = 4;
            // 
            // ubtSave
            // 
            this.ubtSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubtSave.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ubtSave.Location = new System.Drawing.Point(593, 5);
            this.ubtSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.ubtSave.Name = "ubtSave";
            this.ubtSave.Size = new System.Drawing.Size(75, 35);
            this.ubtSave.Symbol = 61528;
            this.ubtSave.TabIndex = 10;
            this.ubtSave.Text = "保存";
            this.ubtSave.Click += new System.EventHandler(this.ubtSave_Click);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(511, 5);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(75, 35);
            this.uiSymbolButton1.Symbol = 162446;
            this.uiSymbolButton1.TabIndex = 9;
            this.uiSymbolButton1.Text = "查询";
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboBox1.Items.AddRange(new object[] {
            "作者",
            "标题",
            "内容"});
            this.uiComboBox1.Location = new System.Drawing.Point(10, 5);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 33);
            this.uiComboBox1.TabIndex = 4;
            this.uiComboBox1.Text = "查询类别";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox1.Location = new System.Drawing.Point(167, 3);
            this.uiCheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox1.Size = new System.Drawing.Size(80, 37);
            this.uiCheckBox1.TabIndex = 7;
            this.uiCheckBox1.Text = "按时间";
            // 
            // uiDatePicker1
            // 
            this.uiDatePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatePicker1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDatePicker1.Location = new System.Drawing.Point(254, 5);
            this.uiDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker1.MaxLength = 10;
            this.uiDatePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker1.Name = "uiDatePicker1";
            this.uiDatePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker1.Size = new System.Drawing.Size(120, 34);
            this.uiDatePicker1.SymbolDropDown = 61555;
            this.uiDatePicker1.SymbolNormal = 61555;
            this.uiDatePicker1.TabIndex = 5;
            this.uiDatePicker1.Text = "2021-08-12";
            this.uiDatePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker1.Value = new System.DateTime(2021, 8, 12, 15, 12, 58, 97);
            // 
            // uiDatePicker2
            // 
            this.uiDatePicker2.FillColor = System.Drawing.Color.White;
            this.uiDatePicker2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDatePicker2.Location = new System.Drawing.Point(382, 5);
            this.uiDatePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker2.MaxLength = 10;
            this.uiDatePicker2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker2.Name = "uiDatePicker2";
            this.uiDatePicker2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker2.Size = new System.Drawing.Size(120, 34);
            this.uiDatePicker2.SymbolDropDown = 61555;
            this.uiDatePicker2.SymbolNormal = 61555;
            this.uiDatePicker2.TabIndex = 6;
            this.uiDatePicker2.Text = "2021-08-12";
            this.uiDatePicker2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker2.Value = new System.DateTime(2021, 8, 12, 15, 13, 0, 152);
            // 
            // btnImport
            // 
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnImport.Location = new System.Drawing.Point(762, 3);
            this.btnImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 37);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "导入文件";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(871, 3);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 37);
            this.uiButton2.TabIndex = 8;
            this.uiButton2.Text = "导入文件夹";
            // 
            // dockLayout2
            // 
            this.dockLayout2.Controls.Add(this.uiDataGridViewFooter1);
            this.dockLayout2.Controls.Add(this.dgvArticle);
            this.dockLayout2.Controls.Add(this.uiTextBox1);
            this.dockLayout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockLayout2.DockFlags = new int[] {
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0};
            this.dockLayout2.Location = new System.Drawing.Point(3, 48);
            this.dockLayout2.Name = "dockLayout2";
            this.dockLayout2.Size = new System.Drawing.Size(980, 582);
            this.dockLayout2.TabIndex = 5;
            // 
            // uiDataGridViewFooter1
            // 
            this.uiDataGridViewFooter1.DataGridView = null;
            this.uiDataGridViewFooter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiDataGridViewFooter1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDataGridViewFooter1.Location = new System.Drawing.Point(3, 550);
            this.uiDataGridViewFooter1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiDataGridViewFooter1.Name = "uiDataGridViewFooter1";
            this.uiDataGridViewFooter1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiDataGridViewFooter1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiDataGridViewFooter1.Size = new System.Drawing.Size(974, 29);
            this.uiDataGridViewFooter1.TabIndex = 7;
            this.uiDataGridViewFooter1.Text = "uiDataGridViewFooter1";
            // 
            // dgvArticle
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvArticle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticle.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticle.ColumnHeadersHeight = 32;
            this.dgvArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Author,
            this.Title,
            this.Text});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticle.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticle.EnableHeadersVisualStyles = false;
            this.dgvArticle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgvArticle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvArticle.Location = new System.Drawing.Point(3, 42);
            this.dgvArticle.Name = "dgvArticle";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticle.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvArticle.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvArticle.RowTemplate.Height = 23;
            this.dgvArticle.SelectedIndex = -1;
            this.dgvArticle.ShowGridLine = true;
            this.dgvArticle.Size = new System.Drawing.Size(974, 502);
            this.dgvArticle.TabIndex = 6;
            this.dgvArticle.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArticle_CellMouseDown);
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "日期";
            this.Date.Name = "Date";
            this.Date.Width = 66;
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "作者";
            this.Author.Name = "Author";
            this.Author.Width = 66;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "标题";
            this.Title.Name = "Title";
            this.Title.Width = 66;
            // 
            // Text
            // 
            this.Text.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Text.DataPropertyName = "Text";
            this.Text.HeaderText = "内容";
            this.Text.Name = "Text";
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(4, 5);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Size = new System.Drawing.Size(972, 29);
            this.uiTextBox1.TabIndex = 5;
            this.uiTextBox1.Text = "在此输入查询内容……";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPagination1
            // 
            this.uiPagination1.ActivePage = 20;
            this.uiPagination1.CausesValidation = false;
            this.uiPagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPagination1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPagination1.Location = new System.Drawing.Point(0, 598);
            this.uiPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPagination1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPagination1.Name = "uiPagination1";
            this.uiPagination1.PagerCount = 11;
            this.uiPagination1.PageSize = 50;
            this.uiPagination1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPagination1.Size = new System.Drawing.Size(986, 35);
            this.uiPagination1.TabIndex = 5;
            this.uiPagination1.Text = "uiDataGridPage1";
            this.uiPagination1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPagination1.TotalCount = 40000;
            // 
            // cmsArticle
            // 
            this.cmsArticle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmsArticle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpen,
            this.tsmDelete,
            this.tsmOutput,
            this.tsmEdit});
            this.cmsArticle.Name = "cmsArticle";
            this.cmsArticle.Size = new System.Drawing.Size(113, 108);
            // 
            // tsmOpen
            // 
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(112, 26);
            this.tsmOpen.Text = "打开";
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(112, 26);
            this.tsmDelete.Text = "删除";
            // 
            // tsmOutput
            // 
            this.tsmOutput.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pdfToolStripMenuItem,
            this.wordToolStripMenuItem,
            this.htmlToolStripMenuItem,
            this.pdfwordhtmlToolStripMenuItem});
            this.tsmOutput.Name = "tsmOutput";
            this.tsmOutput.Size = new System.Drawing.Size(112, 26);
            this.tsmOutput.Text = "导出";
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.pdfToolStripMenuItem.Text = "pdf";
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.wordToolStripMenuItem.Text = "word";
            // 
            // htmlToolStripMenuItem
            // 
            this.htmlToolStripMenuItem.Name = "htmlToolStripMenuItem";
            this.htmlToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.htmlToolStripMenuItem.Text = "html";
            // 
            // pdfwordhtmlToolStripMenuItem
            // 
            this.pdfwordhtmlToolStripMenuItem.Name = "pdfwordhtmlToolStripMenuItem";
            this.pdfwordhtmlToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.pdfwordhtmlToolStripMenuItem.Text = "pdf+word+html";
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(112, 26);
            this.tsmEdit.Text = "编辑";
            // 
            // fmArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 633);
            this.Controls.Add(this.uiPagination1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fmArticle";
            this.Load += new System.EventHandler(this.fmArticle_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.dockLayout1.ResumeLayout(false);
            this.dockLayout2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticle)).EndInit();
            this.cmsArticle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UIDatePicker uiDatePicker2;
        private Sunny.UI.UICheckBox uiCheckBox1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private DockLayout dockLayout1;
        private Sunny.UI.UIButton btnImport;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private DockLayout dockLayout2;
        private Sunny.UI.UIDataGridViewFooter uiDataGridViewFooter1;
        private Sunny.UI.UIDataGridView dgvArticle;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIPagination uiPagination1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
        private Sunny.UI.UISymbolButton ubtSave;
        private Sunny.UI.UIContextMenuStrip cmsArticle;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmOutput;
        private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfwordhtmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
    }
}