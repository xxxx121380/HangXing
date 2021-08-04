using System;
using Sunny.UI;

namespace Hangxing
{
    public partial class Form_Register : UIForm
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form_Login fl  = new Form_Login();
            fl.Show();
            this.Visible = false;
        }
    }
}