using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

public class DockLayout : Panel
{
    // 左、上、右、下
    private int[] dockFlags = new int[8];

    protected override void OnLayout(LayoutEventArgs levent)
    {
        base.OnLayout(levent);
        int w = this.Width;
        int h = this.Height;

        // 考虑容器本身的 Padding
        Padding pad = this.Padding;
        w -= (pad.Left + pad.Right);
        h -= (pad.Top + pad.Bottom);

        DockControl dcTop = new DockControl();
        DockControl dcRight = new DockControl();
        DockControl dcBottom = new DockControl();
        DockControl dcLeft = new DockControl();
        Control center = null; // 中央控件

        // 判断4个边的宽度
        foreach (Control c in this.Controls)
        {
            Padding m = c.Margin; // 须考虑Margin设置
                                  // 左
            if (c.Dock == DockStyle.Left && c.Visible)
            {
                DockControl dc = dcLeft; ;
                dc.c = c;
                dc.size = c.Width;
                dc.size += (m.Left + m.Right);
                dc.flag1 = dockFlags[0];
                dc.flag2 = dockFlags[1];
            }
            if (c.Dock == DockStyle.Top && c.Visible)
            {
                DockControl dc = dcTop; ;
                dc.c = c;
                dc.size = c.Height;
                dc.size += (m.Top + m.Bottom);
                dc.flag1 = dockFlags[2];
                dc.flag2 = dockFlags[3];
            }
            if (c.Dock == DockStyle.Right && c.Visible)
            {
                DockControl dc = dcRight; ;
                dc.c = c;
                dc.size = c.Width;
                dc.size += (m.Left + m.Right);
                dc.flag1 = dockFlags[4];
                dc.flag2 = dockFlags[5];
            }
            if (c.Dock == DockStyle.Bottom && c.Visible)
            {
                DockControl dc = dcBottom; ;
                dc.c = c;
                dc.size = c.Height;
                dc.size += (m.Top + m.Bottom);
                dc.flag1 = dockFlags[6];
                dc.flag2 = dockFlags[7];
            }
            if (c.Dock == DockStyle.Fill && c.Visible)
            {
                center = c;
            }
        }

        // 依次布局
        if (dcLeft.c != null)
        {

            DockControl dc = dcLeft;
            int x1 = 0, y1 = 0;
            int x2 = dc.size, y2 = h;
            if (dc.flag1 == 0)
                y1 += dcTop.size;
            if (dc.flag2 == 0)
                y2 -= dcBottom.size;
            SetSizeLocation(dc.c, x1, y1, x2, y2);
        }
        if (dcTop.c != null)
        {
            DockControl dc = dcTop;
            int x1 = 0, y1 = 0;
            int x2 = w, y2 = dc.size;
            if (dc.flag1 == 0)
                x1 += dcLeft.size;
            if (dc.flag2 == 0)
                x2 -= dcRight.size;
            SetSizeLocation(dc.c, x1, y1, x2, y2);
        }
        if (dcRight.c != null)
        {
            DockControl dc = dcRight;
            int x1 = w - dc.size, y1 = 0;
            int x2 = w, y2 = h;
            if (dc.flag1 == 0)
                y1 += dcTop.size;
            if (dc.flag2 == 0)
                y2 -= dcBottom.size;
            SetSizeLocation(dc.c, x1, y1, x2, y2);
        }
        if (dcBottom.c != null)
        {
            DockControl dc = dcBottom;
            int x1 = 0, y1 = h - dc.size;
            int x2 = w, y2 = h;
            if (dc.flag1 == 0)
                x1 += dcLeft.size;
            if (dc.flag2 == 0)
                x2 -= dcRight.size;
            SetSizeLocation(dc.c, x1, y1, x2, y2);
        }
        if (center != null)
        {
            int x1 = dcLeft.size, y1 = dcTop.size;
            int x2 = w - dcRight.size, y2 = h - dcBottom.size;
            SetSizeLocation(center, x1, y1, x2, y2);
            //Console.WriteLine("center{0},{1},{2},{3}", x1, y1, x2, y2);
        }
    }

    public void SetSizeLocation(Control c, int x1, int y1, int x2, int y2)
    {
        // 控件的布局尺寸 (包含了控件的Margin)
        int width = x2 - x1, height = y2 - y1;

        // 容器本身的 Padding
        Padding pad = this.Padding;
        x1 += pad.Left;
        y1 += pad.Top;

        // 考虑控件本身的 Margin
        Padding margin = c.Margin;
        x1 += margin.Left;
        y1 += margin.Top;
        width -= (margin.Left + margin.Right);
        height -= (margin.Top + margin.Bottom);

        c.Location = new Point(x1, y1);
        c.Size = new Size(width, height);
    }

    public class DockControl
    {
        public Control c;
        public int size;
        public int flag1 = 0; // 1占据 0 退让
        public int flag2 = 0;
    }


    [Browsable(true)]
    [Editor(typeof(DockFlagEditorType), typeof(UITypeEditor))]
    public int[] DockFlags
    {
        get
        {
            return dockFlags;
        }
        set
        {
            this.dockFlags = value;
            PerformLayout();
        }
    }
}

/// <summary>
/// 按照Winform框架的要求，定义一个属性编辑器器
/// </summary>
class DockFlagEditorType : UITypeEditor
{
    public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
    {
        IWindowsFormsEditorService editorService = null;
        if (context != null && context.Instance != null && provider != null)
        {
            editorService = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (editorService != null)
            {
                // 自定义控件
                DockLayout owner = (DockLayout)context.Instance;
                DockFlagEditor editorUi = new DockFlagEditor();
                editorUi.SetValue(owner.DockFlags);
                //editorUi.Size = editorUi.grid.PreferredSize;

                // 显示 （阻塞方式，直到界面关闭)
                editorService.DropDownControl(editorUi);

                // 新的值
                int[] newValue = editorUi.GetValue();
                //owner.Partition = newPartition;
                return newValue;
            }
        }
        return value;
    }

    public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
    {
        return UITypeEditorEditStyle.DropDown;
    }
}

/// <summary>
/// 定义一个编辑器，将出现在属性面板里
/// </summary>
[ToolboxItem(false)]
class DockFlagEditor : UserControl
{
    private DataGridViewTextBoxColumn Column1;
    private DataGridViewTextBoxColumn Column2;
    private DataGridViewTextBoxColumn Column3;
    public DataGridView grid;

    private static string T = "✔";
    private static string F = "☐";

    public DockFlagEditor()
    {
        InitializeComponent();

        grid.Rows.Add(new object[] { "左 Left", F, F });
        grid.Rows.Add(new object[] { "上 Top", F, F });
        grid.Rows.Add(new object[] { "右 Right", F, F });
        grid.Rows.Add(new object[] { "下 Bottom", F, F });
    }

    private void InitializeComponent()
    {
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
        this.grid = new System.Windows.Forms.DataGridView();
        this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
        this.SuspendLayout();
        // 
        // grid
        // 
        this.grid.AllowUserToAddRows = false;
        this.grid.AllowUserToDeleteRows = false;
        this.grid.AllowUserToResizeColumns = false;
        this.grid.AllowUserToResizeRows = false;
        this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
        this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
        this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
        this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
        this.grid.Location = new System.Drawing.Point(3, 3);
        this.grid.Name = "grid";
        this.grid.ReadOnly = true;
        this.grid.RowHeadersVisible = false;
        this.grid.RowTemplate.Height = 23;
        this.grid.Size = new System.Drawing.Size(225, 120);
        this.grid.TabIndex = 0;
        this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
        // 
        // Column1
        // 
        dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
        this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
        this.Column1.HeaderText = "方位";
        this.Column1.Name = "Column1";
        this.Column1.ReadOnly = true;
        this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        this.Column1.Width = 80;
        // 
        // Column2
        // 
        this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        this.Column2.DefaultCellStyle = dataGridViewCellStyle5;
        this.Column2.FillWeight = 50F;
        this.Column2.HeaderText = "Flag1";
        this.Column2.Name = "Column2";
        this.Column2.ReadOnly = true;
        this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
        this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        // 
        // Column3
        // 
        this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        this.Column3.DefaultCellStyle = dataGridViewCellStyle6;
        this.Column3.FillWeight = 50F;
        this.Column3.HeaderText = "Flag2";
        this.Column3.Name = "Column3";
        this.Column3.ReadOnly = true;
        this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
        this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        // 
        // AfDockFlagEditor
        // 
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
        this.Controls.Add(this.grid);
        this.Name = "AfDockFlagEditor";
        this.Padding = new System.Windows.Forms.Padding(3);
        this.Size = new System.Drawing.Size(231, 126);
        ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
        this.ResumeLayout(false);

    }

    private bool IsTrue(string value)
    {
        return value.Equals(T);
    }
    private bool Cell(int col, int row)
    {
        return IsTrue((string)grid[col, row].Value);
    }
    public void Cell(int col, int row, bool value)
    {
        grid[col, row].Value = value ? T : F;
    }

    public void SetValue(int[] flags)
    {
        Cell(1, 0, flags[0] > 0);
        Cell(2, 0, flags[1] > 0);

        Cell(1, 1, flags[2] > 0);
        Cell(2, 1, flags[3] > 0);

        Cell(1, 2, flags[4] > 0);
        Cell(2, 2, flags[5] > 0);

        Cell(1, 3, flags[6] > 0);
        Cell(2, 3, flags[7] > 0);
    }

    public int[] GetValue()
    {
        int[] flags = new int[8];
        flags[0] = Cell(1, 0) ? 1 : 0;
        flags[1] = Cell(2, 0) ? 1 : 0;
        flags[2] = Cell(1, 1) ? 1 : 0;
        flags[3] = Cell(2, 1) ? 1 : 0;
        flags[4] = Cell(1, 2) ? 1 : 0;
        flags[5] = Cell(2, 2) ? 1 : 0;
        flags[6] = Cell(1, 3) ? 1 : 0;
        flags[7] = Cell(2, 3) ? 1 : 0;
        return flags;
    }

    private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        int row = e.RowIndex, col = e.ColumnIndex;
        if (col == 0) return;

        bool value = Cell(col, row);
        Console.WriteLine("click at: {0},{1} value={2}", row, col, value);

        grid[col, row].Value = value ? F : T;

        if (!value)
        {
            CheckOnEdit(row, col, value);
        }
    }

    // 左上 grid[1,0]  左下 grid[2,0]
    // 上左 grid[1,1]  上右 grid[2,1]
    // 右上 grid[1,2]  右下 grid[2,2]
    // 下左 grid[1,3]  下右 grid[2,3]
    private void CheckOnEdit(int row, int col, bool value)
    {
        if (row == 0) // 左
        {
            if (col == 1) Cell(1, 1, false);
            if (col == 2) Cell(1, 3, false);
        }
        if (row == 1) // 上
        {
            if (col == 1) Cell(1, 0, false);
            if (col == 2) Cell(1, 2, false);
        }
        if (row == 2) // 右
        {
            if (col == 1) Cell(2, 1, false);
            if (col == 2) Cell(2, 3, false);
        }
        if (row == 3) // 下
        {
            if (col == 1) Cell(2, 0, false);
            if (col == 2) Cell(2, 2, false);
        }
    }

}

