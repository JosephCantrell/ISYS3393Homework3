using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISYS3393Homework3
{
    public partial class FlowerShop : Form
    {
        public FlowerShop()
        {
            InitializeComponent();
        }

        private void RdoBtn_CheckedChanged(object sender, System.EventArgs e)
        {
            FlowerShopControls.PhotoCheck();
        }

        private void chkBoxPictureEnable_CheckedChanged(object sender, EventArgs e)
        {
            FlowerShopControls.EnablePhoto();
        }

        private void BtnTotal_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            FlowerShopControls.Total();
        }

        private void BtnClear_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            FlowerShopControls.Clear();
        }

        private void BtnExit_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            FlowerShopControls.Exit();
        }

        private void BtnAdd_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            FlowerShopControls.Add();
        }

        private void BtnDelete_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            FlowerShopControls.Delete();
        }
    }
}
