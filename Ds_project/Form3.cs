using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ds_project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Edit_UC edit_UC = new Edit_UC();
            //edit_UC.Location = new Point(180, 20);
            //this.Controls.Add(edit_UC);

            //Item_UC item_UC = new Item_UC();
            //item_UC.Location = new Point(180, 100);
            //this.Controls.Add(item_UC);

            Rate_UC rate_UC = new Rate_UC();
            rate_UC.Location = new Point(180, 100);
            this.Controls.Add(rate_UC);
        }
    }
}
