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
    public partial class viewbrandsection : UserControl
    {
      
        public int _idbrand;
        public Brand brand = new Brand();
        public viewbrandsection()
        {
            InitializeComponent();
        }

        private void viewbrandsection_Load(object sender, EventArgs e)
        {

        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            //here
            Form1.home.flowLayoutPanel3.Controls.Clear();
            for(int i = 0; i < brand.itemlist.Count; i++)
            {
                Item_UC it = new Item_UC();
                it.item = brand.itemlist[i];
                it.name.Text ="Name : "+ brand.itemlist[i].name;
                it.price.Text = "Price : " + brand.itemlist[i].price;
                it.color.Text = "Color : " + brand.itemlist[i].color;
                it.image.ImageLocation= @"C:\\Users\\nader\\Desktop\\nader.jpg";
                it.brand.Text = "Brand : " + brand.name;
                it.descripiton.Text = "Description : " + brand.itemlist[i].description;
                Form1.home.flowLayoutPanel3.Controls.Add(it);

            }


        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            //here

            Home hom;
            hom = (Home)this.FindForm();
            hom.filt_panel.Visible = true;
            Form1.home.flowLayoutPanel3.Controls.Clear();
            Form1.home.itemsnow.Clear();
            Form1.home.Colorlist.Items.Clear();
            Form1.home.Brandlist.Items.Clear();
            Form1.home.sectionlist.Items.Clear();
            for (int i = 0; i < brand.itemlist.Count; i++)
            {
                Item_UC it = new Item_UC();
                it.item = brand.itemlist[i];
                it.name.Text = "Name : " + brand.itemlist[i].name;
                it.price.Text = "Price : " + brand.itemlist[i].price;
                it.color.Text = "Color : " + brand.itemlist[i].color;
                //draw hair
                // it.image = brand.itemlist[i].image;
                if (brand.itemlist[i].image != null)
                {
                    MemoryStream stream = new MemoryStream(brand.itemlist[i].image);
                    it.image.Image = System.Drawing.Image.FromStream(stream);
                }
                it.brand.Text = "Brand : " + brand.name;
                it.descripiton.Text = "Description : " + brand.itemlist[i].description;
                Form1.home.itemsnow.AddLast(brand.itemlist[i]);
                Form1.home.flowLayoutPanel3.Controls.Add(it);
                if (!Form1.home.Colorlist.Items.Contains(brand.itemlist[i].color))
                {
                    Form1.home.Colorlist.Items.Add(brand.itemlist[i].color);
                }
                section sec = section.getsectionbyid(Variables.sectionlist,brand.itemlist[i].section_id);
                if (!Form1.home.sectionlist.Items.Contains(sec.name))
                {
                    Form1.home.sectionlist.Items.Add(sec.name);
                }
            }
            Form1.home.Brandlist.Items.Add(brand.name);
        }
    }
}
