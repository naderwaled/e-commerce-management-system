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
    public partial class Addsection : UserControl
    {
        section sec = new section();
        public Addsection()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            for(int i = 0; i < Variables.sectionlist.Count; i++)
            {
                comboBox1.Items.Add(Variables.sectionlist.ElementAt(i).name);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            
            sec.name = textBox1.Text;
            sec.description = textBox3.Text;
            
            if (Home.uc.label1.Text == "Add")
            {
                sec.addsection(Variables.sectionlist, sec);
            }
           
            else if (Home.uc.label1.Text == "Edit")
            {
             
                
                sec.editsection(Variables.sectionlist, comboBox1.Text,sec);
            }
            MessageBox.Show("saved");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Addsection_Load(object sender, EventArgs e)
        {
            
           
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            sec.image = null;
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (image.ShowDialog() == DialogResult.OK)
            {
                string pic = image.FileName.ToString();
                pictureBox1.ImageLocation = pic;
                FileStream fstream = new FileStream(pic, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                sec.image = br.ReadBytes((int)fstream.Length);


            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < Variables.sectionlist.Count; i++)
            {
                if (Variables.sectionlist.ElementAt(i).name == comboBox1.Text)
                {
                     textBox1.Text=Variables.sectionlist.ElementAt(i).name;
                     textBox3.Text=Variables.sectionlist.ElementAt(i).description;
                    if (Variables.sectionlist.ElementAt(i).image!=null)
                    {
                        
                            MemoryStream stream = new MemoryStream(Variables.sectionlist.ElementAt(i).image);
                            pictureBox1.Image = System.Drawing.Image.FromStream(stream);
                        
                    }
                    break;

                }
            }
        }
    }
}
