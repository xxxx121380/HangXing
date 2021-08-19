using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
namespace Hangxing.View
{
    public partial class fmPSData : UIPage
    {
        public fmPSData()
        {
            InitializeComponent();
        }

        private void fmPSData_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextBoxPath.Text = fbd.SelectedPath;
                AppconfigManage.modifyItem("datapath", fbd.SelectedPath);
                uiListBox1.Items.Clear();
                string filters[] = new string[] { "*.jpg", "*.bmp", "*.gif" }

                foreach (string filter in filters)
                {
                    string[] tmp1 = System.IO.Directory.GetFiles(dialog1.SelectedPath, filter);
                    foreach (string s in tmp1)
                    {
                        listBox1.Items.Add(new FileInfo(s).Name);
                    }

                }
            }

        private void uiListBox1_ItemClick(object sender, EventArgs e)
        {

        }
    }
}

