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
    public partial class Add : UserControl
    {
        public static Additem addit = new Additem();
        public static addbrand_uc addbrand = new addbrand_uc();
        public static Addsection addsec = new Addsection();
        public Add()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
            //Form1.home.flowLayoutPanel3.Controls.Remove(addit);
            //Form1.home.flowLayoutPanel3.Controls.Remove(addsec);
            Form1.home.flowLayoutPanel3.Controls.Clear();
            addbrand = new addbrand_uc();
            addbrand.label5.Visible = addbrand.comboBox1.Visible = true;
            Form1.home.flowLayoutPanel3.Controls.Add(addbrand);   
            if(label1.Text=="Delete")
            {
                addbrand.label1.Visible = addbrand.label2.Visible = addbrand.label3.Visible = addbrand. label4.Visible = addbrand.label6.Visible = false;
                addbrand.textBox1.Visible = addbrand.textBox2.Visible = addbrand.textBox3.Visible = addbrand.textBox4.Visible = addbrand.textBox5.Visible = false;
                addbrand.label5.Location = new Point(235,239);
                addbrand.comboBox1.Location = new Point(369,239);
                

            } 
            else if (label1.Text == "Add")
            {
                addbrand.label5.Visible = false;
                addbrand.comboBox1.Visible = false;

            }        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Addsection addsec = new Addsection();
            //Form1.home.flowLayoutPanel3.Controls.Remove(addbrand);
            //Form1.home.flowLayoutPanel3.Controls.Remove(addit);
           Form1.home.flowLayoutPanel3.Controls.Clear();

            if (label1.Text == "Edit" || label1.Text == "Delete")
            {
                addsec.label1.Visible = addsec.comboBox1.Visible = true;
            }
            else
                addsec.label1.Visible = addsec.comboBox1.Visible = false;
            //addsec = new Addsection();
            Form1.home.flowLayoutPanel3.Controls.Add(addsec);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        
           // Form1.home.flowLayoutPanel3.Controls.Remove(addbrand);
            Form1.home.flowLayoutPanel3.Controls.Clear();
           // Form1.home.flowLayoutPanel3.Controls.Remove(addsec);
            addit = new Additem();
            Form1.home.flowLayoutPanel3.Controls.Add(addit);
            if(label1.Text=="Edit")
            {
                addit.label8.Visible = addit.comboBox3.Visible = true; 
            }
            else if( label1.Text == "Delete")
            {
                addit.label8.Visible = addit.comboBox3.Visible = true;
                addit.label1.Visible = addit.label2.Visible = addit.label3.Visible = addit.label4.Visible = addit.label5.Visible = addit.label6.Visible = addit.label7.Visible = false;
                addit.textBox1.Visible = addit.textBox2.Visible = addit.textBox3.Visible = addit.textBox4.Visible = addit.textBox5.Visible = addit.comboBox1.Visible = addit.comboBox2.Visible = false;
            }

        }
    }
}
