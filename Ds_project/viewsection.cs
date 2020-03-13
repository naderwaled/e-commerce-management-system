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
    public partial class viewsection : UserControl
    {
       
        public section Section = new section();
        public viewsection()
        {
            InitializeComponent();
        }

        private void viewsection_Load(object sender, EventArgs e)
        {

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            //here
            Home hom;
            hom = (Home)this.FindForm();
            hom.filt_panel.Visible = true;
            Form1.home.flowLayoutPanel3.Controls.Clear();
            Form1.home.Brandlist.Items.Clear();
            Form1.home.sectionlist.Items.Clear();
            Form1.home.Colorlist.Items.Clear();
            Form1.home.itemsnow.Clear();
            for (int i = 0; i < Variables.brandlist.Count; i++)
            {
                for (int j = 0; j < Variables.brandlist.ElementAt(i).itemlist.Count; j++)
                {
                    if (Variables.brandlist.ElementAt(i).itemlist[j].section_id == Section.id)
                    {
                        Item_UC it = new Item_UC();
                        it.item = Variables.brandlist.ElementAt(i).itemlist[j];
                        it.name.Text = "Name : " + Variables.brandlist.ElementAt(i).itemlist[j].name;
                        it.price.Text = "Price : " + Variables.brandlist.ElementAt(i).itemlist[j].price;
                        it.color.Text = "Color : " + Variables.brandlist.ElementAt(i).itemlist[j].color;
                        // draw hair
                        // it.image.ImageLocation = Section.itemlist[i].image;
                        if (Variables.brandlist.ElementAt(i).itemlist[j].image != null)
                        {
                            MemoryStream stream = new MemoryStream(Variables.brandlist.ElementAt(i).itemlist[j].image);
                            it.image.Image = System.Drawing.Image.FromStream(stream);
                        }
                        //here
                        it.brand.Text = "Brand : " + Variables.brandlist.ElementAt(i).name;
                        it.descripiton.Text = "Description : " + Variables.brandlist.ElementAt(i).itemlist[j].description;
                        Form1.home.itemsnow.AddLast(Variables.brandlist.ElementAt(i).itemlist[j]);
                        Form1.home.flowLayoutPanel3.Controls.Add(it);
                        if (!Form1.home.Colorlist.Items.Contains(Variables.brandlist.ElementAt(i).itemlist[j].color))
                        {
                            Form1.home.Colorlist.Items.Add(Variables.brandlist.ElementAt(i).itemlist[j].color);
                        }
                        if (!Form1.home.Brandlist.Items.Contains(Variables.brandlist.ElementAt(i).name))
                        {
                            Form1.home.Brandlist.Items.Add(Variables.brandlist.ElementAt(i).name);
                        }


                    }
                }

            }
            Form1.home.sectionlist.Items.Add(Section.name);
        }
    }
}
