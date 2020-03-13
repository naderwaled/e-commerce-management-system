using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ds_project;
namespace Ds_project
{
    public partial class Item_UC : UserControl
    {
     public  Items item = new Items();
        
        public Item_UC()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
     
        

             

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            request req = new request();
            req.id = Variables.requestlist.Count + 1;
            req.user_id = Variables.usernow.id;
            req.item_id = item.id;
            req.status = "Loading..";
            req.date = DateTime.Now;
            req.amount = Convert.ToInt16(textBox1.Text);
            string s = Variables.usernow.requestfunction(ref Variables.requestlist, Variables.usernow, item, ref Variables.brandlist, req);
            MessageBox.Show(s);
        }

        private void Item_UC_Load(object sender, EventArgs e)
        {
            if(Variables.usernow.status)
            {
                pictureBox1.Visible = textBox1.Visible = label8.Visible = false;
            }
        }
    }
}
