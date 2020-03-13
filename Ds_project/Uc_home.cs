using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ds_project
{
    public partial class Uc_home : UserControl
    {
        public Uc_home()
        {
            InitializeComponent();
        }
        int imageno = 1;
        private void Nextimage()
        {
            if (imageno == 12)
            {
                imageno = 1;
            }
            slidepic.ImageLocation = string.Format(@"images\{0}.JPG", imageno);
            imageno++;

        }
        private void Uc_home_Load(object sender, EventArgs e)
        {

        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
           
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Nextimage();
        }

        private void slidepic_Click(object sender, EventArgs e)
        {

        }
    }
}
