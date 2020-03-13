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
    public partial class Additem : UserControl
    {
      
        //string pic;
        Items it = new Items();
        public Additem()
        {
            InitializeComponent();
            for(int i = 0; i < Variables.brandlist.Count; i++)
            {
                for(int j = 0; j < Variables.brandlist.ElementAt(i).itemlist.Count; j++)
                {
                    comboBox3.Items.Add(Variables.brandlist.ElementAt(i).itemlist[j].name);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Items it = new Items();
            Brand brand = new Brand();
            Add addd = new Add();
            //edit here
            for(int i=0;i<Variables.brandlist.Count;i++)
            {
                if (Variables.brandlist.ElementAt(i).name == comboBox1.SelectedItem.ToString())
                    it.brand_id = Variables.brandlist.ElementAt(i).id;
            }
            for (int i = 0; i < Variables.sectionlist.Count; i++)
            {
                if (Variables.sectionlist.ElementAt(i).name == comboBox1.SelectedItem.ToString())
                    it.section_id = Variables.sectionlist.ElementAt(i).id;
            }
            it.name = textBox1.Text;
            it.amount = Convert.ToInt16(textBox2.Text);
            it.color = textBox3.Text;
            it.price = Convert.ToDouble(textBox5.Text);
            it.description = textBox4.Text;
            it.additem(Variables.brandlist,Variables.sectionlist,Variables.itemlist,it);
            MessageBox.Show("saved");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            Brand brand = new Brand();
            Add addd = new Add();
            it.name = textBox1.Text;
            //here pic
            //it.image = pic;
            for (int i = 0; i < Variables.brandlist.Count; i++)
            {
                if (Variables.brandlist.ElementAt(i).name == comboBox1.Text)
                {
                    it.brand_id = Variables.brandlist.ElementAt(i).id;
                    break;
                }
            }
            for (int i = 0; i < Variables.sectionlist.Count; i++)
            {
                if (Variables.sectionlist.ElementAt(i).name == comboBox2.Text)
                {
                    it.section_id = Variables.sectionlist.ElementAt(i).id;
                    break;
                }
            }
            it.amount = Convert.ToInt16(textBox2.Text);
            it.color = textBox3.Text;
            it.price = Convert.ToDouble(textBox5.Text);
            it.description = textBox4.Text;
            if (Home.uc.label1.Text == "Add")
                it.additem(Variables.brandlist, Variables.sectionlist,Variables.itemlist, it);
            else if (Home.uc.label1.Text == "Edit")
                it.edititem(Variables.brandlist,comboBox3.Text ,it);
            else if (Home.uc.label1.Text == "Delete")
                it.deleteitem(Variables.brandlist, comboBox3.Text,it);
            MessageBox.Show("saved");

        }

        private void Additem_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Variables.brandlist.Count; i++)
            {
                comboBox1.Items.Add(Variables.brandlist.ElementAt(i).name);
            }
            for(int i = 0; i < Variables.sectionlist.Count; i++)
            {
                comboBox2.Items.Add(Variables.sectionlist.ElementAt(i).name);
            }
            for (int i = 0; i < Variables.itemlist.Count; i++)
            {
                comboBox3.Items.Add(Variables.itemlist.ElementAt(i).name);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (image.ShowDialog() == DialogResult.OK)
            {
                string pic = image.FileName.ToString();
                pictureBox1.ImageLocation = pic;
                FileStream fstream = new FileStream(pic, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                it.image = br.ReadBytes((int)fstream.Length);


            }
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < Variables.brandlist.Count; i++)
            {
                for(int j = 0; j < Variables.brandlist.ElementAt(i).itemlist.Count;j++)
                {
                    if (Variables.brandlist.ElementAt(i).itemlist[j].name == comboBox3.Text)
                    {
                        textBox1.Text = Variables.brandlist.ElementAt(i).itemlist[j].name;
                        Brand brand = new Brand();
                        brand = Brand.getbrandbyid(Variables.brandlist,Variables.brandlist.ElementAt(i).itemlist[j].brand_id);
                        comboBox1.Text = brand.name;
                        section sec = new section();
                        sec = section.getsectionbyid(Variables.sectionlist, Variables.brandlist.ElementAt(i).itemlist[j].section_id);
                        comboBox2.Text = sec.name;
                        textBox2.Text = Variables.brandlist.ElementAt(i).itemlist[j].amount.ToString();
                        textBox3.Text = Variables.brandlist.ElementAt(i).itemlist[j].color;
                        textBox5.Text = Variables.brandlist.ElementAt(i).itemlist[j].price.ToString();
                        textBox4.Text = Variables.brandlist.ElementAt(i).itemlist[j].description;
                        if (Variables.brandlist.ElementAt(i).itemlist[j].image != null)
                        {
                            MemoryStream stream = new MemoryStream(Variables.brandlist.ElementAt(i).itemlist[j].image);
                            pictureBox1.Image = System.Drawing.Image.FromStream(stream);
                        }
                        break;

                    }
                }
            }
        }
    }
}
