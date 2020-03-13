using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Ds_project
{
    public partial class addbrand_uc : UserControl
    {
        Brand brand = new Brand();
        public addbrand_uc()
        {
            InitializeComponent();

            for(int i = 0; i < Variables.brandlist.Count; i++)
            {
                comboBox1.Items.Add(Variables.brandlist.ElementAt(i).name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


           // Brand brand = new Brand();
            brand.name = textBox1.Text;
            brand.country = textBox2.Text;
            brand.category = textBox3.Text;
            brand.mail = textBox4.Text;
            brand.phone = textBox5.Text;
            if (Home.uc.label1.Text == "Add")
            {
                brand.addbrand(Variables.brandlist, brand);
            }
            else if (Home.uc.label1.Text == "Edit")
            {
                if (brand.editbrand(Variables.brandlist, comboBox1.Text, brand))
                    Add.addbrand.label5.Visible = Add.addbrand.comboBox1.Visible = false;
            }
            else if (Home.uc.label1.Text == "Delete")
            {

                brand.deletebrand(Variables.brandlist, comboBox1.Text);

            }
        }
         
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addbrand_uc_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //
            brand.image=null;
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (image.ShowDialog() == DialogResult.OK)
            {
                string pic = image.FileName.ToString();
                pictureBox1.ImageLocation = pic;
                FileStream fstream = new FileStream(pic, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                brand.image = br.ReadBytes((int)fstream.Length);


            }
        }

        private void comboBox1_FormatStringChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < Variables.brandlist.Count; i++ )
            {
                if (Variables.brandlist.ElementAt(i).name == comboBox1.Text)
                {
                    textBox1.Text=Variables.brandlist.ElementAt(i).name;
                    textBox2.Text=Variables.brandlist.ElementAt(i).country;
                    textBox3.Text=Variables.brandlist.ElementAt(i).category;
                    textBox4.Text=Variables.brandlist.ElementAt(i).mail;
                    textBox5.Text=Variables.brandlist.ElementAt(i).phone;
                    if (Variables.brandlist.ElementAt(i).image != null)
                    {
                       
                            MemoryStream stream = new MemoryStream(Variables.brandlist.ElementAt(i).image);
                            pictureBox1.Image = System.Drawing.Image.FromStream(stream);
                        
                    }
                    break;
                }
            }
        }
    }
}
