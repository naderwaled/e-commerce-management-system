using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ds_project
{
    public partial class Home : Form
    {
        int pw;
        bool hide, isCollapsedd;
        bool home = false, user = false, cat = false, bran = false, bask = false, add = false, edit = false, del = false;
        public LinkedList<Items> itemsnow = new LinkedList<Items>();
        public LinkedList<Brand> brandsnow = new LinkedList<Brand>();
        public LinkedList<section> sectionsnow = new LinkedList<section>();


        public static Add uc = new Add();

        public Home()
        {
            InitializeComponent();
            hide = true;
            pw = sl_panel.Width;
            sl_panel.Width = 25;
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            filt_panel.Visible = false;
            cat = true;
            timer1.Start();
            flowLayoutPanel3.Controls.Clear();
            sectionsnow = Variables.sectionlist;
            for (int i = 0; i < Variables.sectionlist.Count; i++)
            {
                viewsection newsection = new viewsection();
                newsection.Section = Variables.sectionlist.ElementAt(i);
                newsection.name.Text = "Name : " + Variables.sectionlist.ElementAt(i).name;
                newsection.description.Text = "Description : " + Variables.sectionlist.ElementAt(i).description;
                if (Variables.sectionlist.ElementAt(i).image != null)
                {
                    MemoryStream stream = new MemoryStream(Variables.sectionlist.ElementAt(i).image);
                    newsection.image.Image = System.Drawing.Image.FromStream(stream);
                }
                flowLayoutPanel3.Controls.Add(newsection);

            }
        }





        private void Home_Load(object sender, EventArgs e)
        {
            
            Uc_home home = new Uc_home();
            flowLayoutPanel3.Controls.Add(home);
            sl_panel.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            filt_panel.Visible = false;
            flowLayoutPanel3.Controls.Clear();
            Uc_home hm = new Uc_home();
            flowLayoutPanel3.Controls.Add(hm);
            home = true;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hide)
            {
                sl_panel.Width = sl_panel.Width + 20;
                if (sl_panel.Width > 25)
                    pictureBox3.Visible = false;

                if (sl_panel.Width >= pw)
                {
                    timer1.Stop();
                    hide = false;
                    this.Refresh();
                }
            }
            else if (!hide || home == true || user == true || cat == true || bran == true || bask == true || add == true || edit==true || del==true)
            {
                sl_panel.Width = sl_panel.Width - 20;

                if (sl_panel.Width <= 25)
                {
                    pictureBox3.Visible = true;
                    timer1.Stop();
                    hide = true;
                    this.Refresh();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            filt_panel.Visible = false;
            bran = true;
            timer1.Start();
            flowLayoutPanel3.Controls.Clear();
            brandsnow = Variables.brandlist;
            for (int i = 0; i < brandsnow.Count; i++)
            {
                viewbrandsection newbrand = new viewbrandsection();
                newbrand.brand = brandsnow.ElementAt(i);
                if (brandsnow.ElementAt(i).image != null)
                {
                    MemoryStream stream = new MemoryStream(brandsnow.ElementAt(i).image);
                    newbrand.image.Image = System.Drawing.Image.FromStream(stream);
                }
                newbrand.name.Text = "Name : " + brandsnow.ElementAt(i).name;
                newbrand.phone.Text = "Phone : " + brandsnow.ElementAt(i).phone;
                newbrand.mail.Text = "Email : " + brandsnow.ElementAt(i).mail;
                newbrand.description.Text = "Description : " + brandsnow.ElementAt(i).category;
                newbrand.country.Text = "Country : " + brandsnow.ElementAt(i).country;
                //newbrand.image.ImageLocation =@"C:\\Users\\nader\\Desktop\\nader.jpg";
                flowLayoutPanel3.Controls.Add(newbrand);
                

            }


        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            Add add = new Add();
            this.Controls.Remove(add);
            filt_panel.Visible = false;
            bask = true;
            timer1.Start();
            Form1.home.flowLayoutPanel3.Controls.Clear();
            if (Variables.usernow.status == false)
            {
                LinkedList<request> reqList = new LinkedList<request>();
                reqList = Variables.usernow.retrnrequest(ref Variables.requestlist, Variables.usernow);

                for (int i = 0; i < reqList.Count; i++)

                {

                    ItemOfBasket_UC it = new ItemOfBasket_UC();
                    Items item = new Items();
                    it.req = reqList.ElementAt(i);
                    item = Items.getiteminfo(Variables.brandlist, reqList.ElementAt(i).item_id);
                    if (item.id != -1)
                    {
                        it.name.Text = "Name :" + item.name;
                        it.color.Text = "Color :" + item.color;
                        it.amount.Text = "Amount :" + reqList.ElementAt(i).amount;
                        it.status.Text = "Status :" + reqList.ElementAt(i).status;
                        if (reqList.ElementAt(i).status == "done")
                        {
                            it.done_btn.Visible = false;
                        }

                        if (item.image != null)
                        {


                            MemoryStream stream = new MemoryStream(item.image);
                            it.itempic.Image = System.Drawing.Image.FromStream(stream);

                        }
                    }
                    else
                    {
                        it.name.Text = "This Item was deleted by admin";
                        it.color.Visible = false;
                        it.amount.Visible = false;
                        it.status.Visible = false;
                        it.itempic.Visible = false;
                        it.done_btn.Visible = false;

                    }
                    Form1.home.flowLayoutPanel3.Controls.Add(it);


                }
            }
            else
            {
                //LinkedList<request> reqList = new LinkedList<request>();
                // reqList = Variables.usernow.retrnrequest(ref Variables.requestlist, Variables.usernow);

                for (int i = 0; i < Variables.requestlist.Count; i++)

                {

                    ItemOfBasket_UC it = new ItemOfBasket_UC();
                    Items item = new Items();
                    it.req = Variables.requestlist.ElementAt(i);
                    item = Items.getiteminfo(Variables.brandlist, Variables.requestlist.ElementAt(i).item_id);
                    user useinfo = new user();
                    useinfo = useinfo.getuserinfo(Variables.userarr, Variables.requestlist.ElementAt(i).user_id);
                    if (item.id != -1)
                    {
                        it.name.Text = "Name :" + item.name;
                        it.color.Text = "Color :" + item.color;
                        it.amount.Text = "Amount :" + Variables.requestlist.ElementAt(i).amount;
                        it.status.Text = "Status :" + Variables.requestlist.ElementAt(i).status;
                       
                            it.done_btn.Visible = false;
                        

                        if (item.image != null)
                        {


                            MemoryStream stream = new MemoryStream(item.image);
                            it.itempic.Image = System.Drawing.Image.FromStream(stream);

                        }
                    }
                  

                    else
                    {
                        it.name.Text = "This Item was deleted by admin";
                        it.color.Visible = false;
                        it.amount.Visible = false;
                        it.status.Visible = false;
                        it.itempic.Visible = false;
                        it.done_btn.Visible = false;

                    }
                    it.Customer.Text += useinfo.name;
                    it.Customer.Visible = true;
                    it.Adress.Text += useinfo.adress;
                    it.Adress.Visible = true;
                    it.Email.Text += useinfo.mail;
                    it.Email.Visible = true;
                    it.Phone.Text +=useinfo.phone;
                    it.Phone.Visible = true;

                    Form1.home.flowLayoutPanel3.Controls.Add(it);
                }
            }
        }













        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }











        private void pictureBox4_Click_1(object sender, EventArgs e)

        {
            Variables.loaddata.returnuserdata(ref Variables.userarr);
            Variables.loaddata.returnbrand(ref Variables.brandlist);
            Variables.loaddata.returnitemdata(ref Variables.brandlist);
            Variables.loaddata.returnsectiondata(ref Variables.sectionlist);
            Variables.loaddata.returnrequstdata(ref Variables.requestlist);
            Application.Exit();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            filt_panel.Visible = false;
            add = true;
            timer1.Start();
            Form1.home.flowLayoutPanel3.Controls.Clear();
            uc = new Add();
            uc.label1.Text = "Add";
            Form1.home.flowLayoutPanel1.Controls.Clear();
            Form1.home.flowLayoutPanel1.Controls.Add(uc);                       
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            edit= true;
            timer1.Start();
            Form1.home.flowLayoutPanel3.Controls.Clear();
            uc = new Add();
            uc.label1.Text = "Edit";
            Form1.home.flowLayoutPanel1.Controls.Clear();
            Form1.home.flowLayoutPanel1.Controls.Add(uc);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
                bunifuFlatButton2.Click += new EventHandler(bunifuFlatButton2_Click);
            else
            {
                flowLayoutPanel3.Controls.Clear();
                Brandlist.Items.Clear();
                sectionlist.Items.Clear();
                Colorlist.Items.Clear();
                itemsnow.Clear();
                sortlist.Text = "";
                if (comboBox1.Text == "Item")
                {
                    filt_panel.Visible = true;
                    flowLayoutPanel3.Controls.Clear();

                    itemsnow = Items.itemsearch(Variables.brandlist, searchBox.Text);
                    for (int i = 0; i < itemsnow.Count; i++)
                    {
                        Item_UC itemui = new Item_UC();

                        itemui.item = itemsnow.ElementAt(i);
                        itemui.name.Text = "Name : " + itemsnow.ElementAt(i).name;
                        itemui.price.Text = "Price : " + itemsnow.ElementAt(i).price;
                        itemui.color.Text = "Color : " + itemsnow.ElementAt(i).color;
                        // draw hair
                        // it.image.ImageLocation = Section.itemlist[i].image;
                        if (itemsnow.ElementAt(i).image != null)
                        {
                            MemoryStream stream = new MemoryStream(itemsnow.ElementAt(i).image);
                            itemui.image.Image = System.Drawing.Image.FromStream(stream);
                        }
                        Brand brand = new Brand();
                        brand = Brand.getbrandbyid(Variables.brandlist, itemsnow.ElementAt(i).brand_id);
                        itemui.brand.Text = "Brand : " + brand.name;
                        if (!Brandlist.Items.Contains(brand.name))
                        {
                            Brandlist.Items.Add(brand.name);
                        }
                        section sec = new section();
                        sec = section.getsectionbyid(Variables.sectionlist, itemsnow.ElementAt(i).section_id);
                        if (!sectionlist.Items.Contains(sec.name))
                        {
                            sectionlist.Items.Add(sec.name);
                        }
                        if (!Colorlist.Items.Contains(itemsnow.ElementAt(i).color))
                        {
                            Colorlist.Items.Add(itemsnow.ElementAt(i).color);
                        }

                        itemui.descripiton.Text = "Description : " + itemsnow.ElementAt(i).description;
                        flowLayoutPanel3.Controls.Add(itemui);

                    }
                }
                else if (comboBox1.Text == "Brand")
                {
                    filt_panel.Visible = true;
                    flowLayoutPanel3.Controls.Clear();

                    brandsnow = Brand.brandsearch(Variables.brandlist, searchBox.Text);
                    for (int i = 0; i < brandsnow.Count; i++)
                    {
                        viewbrandsection newbrand = new viewbrandsection();
                        newbrand.brand = brandsnow.ElementAt(i);
                        if (brandsnow.ElementAt(i).image != null)
                        {
                            MemoryStream stream = new MemoryStream(brandsnow.ElementAt(i).image);
                            newbrand.image.Image = System.Drawing.Image.FromStream(stream);
                        }
                        newbrand.name.Text = "Name : " + brandsnow.ElementAt(i).name;
                        newbrand.phone.Text = "Phone : " + brandsnow.ElementAt(i).phone;
                        newbrand.mail.Text = "Email : " + brandsnow.ElementAt(i).mail;
                        newbrand.description.Text = "Description : " + brandsnow.ElementAt(i).category;
                        newbrand.country.Text = "Country : " + brandsnow.ElementAt(i).country;
                        //newbrand.image.ImageLocation =@"C:\\Users\\nader\\Desktop\\nader.jpg";
                        flowLayoutPanel3.Controls.Add(newbrand);
                    }

                }
                else if (comboBox1.Text == "Section")
                {
                    filt_panel.Visible = true;
                    flowLayoutPanel3.Controls.Clear();
                    sectionsnow = section.searchsection(Variables.sectionlist, searchBox.Text);
                    for (int i = 0; i < sectionsnow.Count; i++)
                    {
                        viewsection newsection = new viewsection();
                        newsection.Section = sectionsnow.ElementAt(i);
                        newsection.name.Text = "Name : " + sectionsnow.ElementAt(i).name;
                        newsection.description.Text = "Description : " + sectionsnow.ElementAt(i).description;
                        if (Variables.sectionlist.ElementAt(i).image != null)
                        {
                            MemoryStream stream = new MemoryStream(sectionsnow.ElementAt(i).image);
                            newsection.image.Image = System.Drawing.Image.FromStream(stream);
                        }
                        flowLayoutPanel3.Controls.Add(newsection);

                    }
                }
            }

        }

       

        private void section_box_CheckedChanged(object sender, EventArgs e)
        {
            if (section_box.Checked == true)
            {
                sectionlist.Visible = true;
            }
            else
            {
                sectionlist.Visible = false;
                sectionlist.Text = "";
            }
        }

        private void Brand_box_CheckedChanged(object sender, EventArgs e)
        {
            if (Brand_box.Checked == true)
            {
                Brandlist.Visible = true;
            }
            else
            {
                Brandlist.Visible = false;
                Brandlist.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                Colorlist.Visible = true;
            }
            else
            {
                Colorlist.Visible = false;
                Colorlist.Text = "";
            }
        }

        private void price_box_CheckedChanged(object sender, EventArgs e)
        {
            if (price_box.Checked == true)
            {
                min_txt.Visible = true;
                max_txt.Visible = true;
            }
            else
            {
                min_txt.Visible = false;
                max_txt.Visible = false;
            }
        }

        private void Sort_CheckedChanged(object sender, EventArgs e)
        {
            if (Sort.Checked == true)
            {
                sortlist.Visible = true;
            }
            else
            {
                sortlist.Visible = false;
                sortlist.Text = "";
            }
        }

        private void sectionlist_SelectedValueChanged(object sender, EventArgs e)
        {
            itemsnow = Items.itemsearch(Variables.brandlist,searchBox.Text);
            itemsnow = Items.filtersection(itemsnow,sectionlist.Text);
            flowLayoutPanel3.Controls.Clear();
            
            for (int i = 0; i < itemsnow.Count; i++)
            {
                Item_UC itemui = new Item_UC();

                itemui.item = itemsnow.ElementAt(i);
                itemui.name.Text = "Name : " + itemsnow.ElementAt(i).name;
                itemui.price.Text = "Price : " + itemsnow.ElementAt(i).price;
                itemui.color.Text = "Color : " + itemsnow.ElementAt(i).color;
                // draw hair
                // it.image.ImageLocation = Section.itemlist[i].image;
                if (itemsnow.ElementAt(i).image != null)
                {
                    MemoryStream stream = new MemoryStream(itemsnow.ElementAt(i).image);
                    itemui.image.Image = System.Drawing.Image.FromStream(stream);
                }
                Brand brand = new Brand();
                brand = Brand.getbrandbyid(Variables.brandlist, itemsnow.ElementAt(i).brand_id);
                itemui.brand.Text = "Brand : " + brand.name;
                if (!Brandlist.Items.Contains(brand.name))
                {
                    Brandlist.Items.Add(Variables.brandlist.ElementAt(i).name);
                }
                section sec = new section();
                sec = section.getsectionbyid(Variables.sectionlist, itemsnow.ElementAt(i).section_id);
                if (!sectionlist.Items.Contains(sec.name))
                {
                    sectionlist.Items.Add(sec.name);
                }
                if (!Colorlist.Items.Contains(itemsnow.ElementAt(i).color))
                {
                    Colorlist.Items.Add(itemsnow.ElementAt(i).color);
                }

                itemui.descripiton.Text = "Description : " + itemsnow.ElementAt(i).description;
                flowLayoutPanel3.Controls.Add(itemui);
            }
        }

        private void Brandlist_SelectedValueChanged(object sender, EventArgs e)
        {
            itemsnow = Items.itemsearch(Variables.brandlist, searchBox.Text);
            itemsnow = Items.filterbrand(itemsnow, Brandlist.Text);
            flowLayoutPanel3.Controls.Clear();
           
            
            for (int i = 0; i < itemsnow.Count; i++)
            {
                Item_UC itemui = new Item_UC();

                itemui.item = itemsnow.ElementAt(i);
                itemui.name.Text = "Name : " + itemsnow.ElementAt(i).name;
                itemui.price.Text = "Price : " + itemsnow.ElementAt(i).price;
                itemui.color.Text = "Color : " + itemsnow.ElementAt(i).color;
                // draw hair
                // it.image.ImageLocation = Section.itemlist[i].image;
                if (itemsnow.ElementAt(i).image != null)
                {
                    MemoryStream stream = new MemoryStream(itemsnow.ElementAt(i).image);
                    itemui.image.Image = System.Drawing.Image.FromStream(stream);
                }
                Brand brand = new Brand();
                brand = Brand.getbrandbyid(Variables.brandlist, itemsnow.ElementAt(i).brand_id);
                itemui.brand.Text = "Brand : " + brand.name;
                if (!Brandlist.Items.Contains(brand.name))
                {
                    Brandlist.Items.Add(Variables.brandlist.ElementAt(i).name);
                }
                section sec = new section();
                sec = section.getsectionbyid(Variables.sectionlist, itemsnow.ElementAt(i).section_id);
                if (!sectionlist.Items.Contains(sec.name))
                {
                    sectionlist.Items.Add(sec.name);
                }
                if (!Colorlist.Items.Contains(itemsnow.ElementAt(i).color))
                {
                    Colorlist.Items.Add(itemsnow.ElementAt(i).color);
                }

                itemui.descripiton.Text = "Description : " + itemsnow.ElementAt(i).description;
                flowLayoutPanel3.Controls.Add(itemui);
            }
        }

        private void sl_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Colorlist_SelectedValueChanged(object sender, EventArgs e)
        {
            itemsnow = Items.itemsearch(Variables.brandlist, searchBox.Text);
            itemsnow = Items.filtercolor(itemsnow, Colorlist.Text);
            flowLayoutPanel3.Controls.Clear();
          
            
            for (int i = 0; i < itemsnow.Count; i++)
            {
                Item_UC itemui = new Item_UC();

                itemui.item = itemsnow.ElementAt(i);
                itemui.name.Text = "Name : " + itemsnow.ElementAt(i).name;
                itemui.price.Text = "Price : " + itemsnow.ElementAt(i).price;
                itemui.color.Text = "Color : " + itemsnow.ElementAt(i).color;
                // draw hair
                // it.image.ImageLocation = Section.itemlist[i].image;
                if (itemsnow.ElementAt(i).image != null)
                {
                    MemoryStream stream = new MemoryStream(itemsnow.ElementAt(i).image);
                    itemui.image.Image = System.Drawing.Image.FromStream(stream);
                }
                Brand brand = new Brand();
                brand = Brand.getbrandbyid(Variables.brandlist, itemsnow.ElementAt(i).brand_id);
                itemui.brand.Text = "Brand : " + brand.name;
                if (!Brandlist.Items.Contains(brand.name))
                {
                    Brandlist.Items.Add(Variables.brandlist.ElementAt(i).name);
                }
                section sec = new section();
                sec = section.getsectionbyid(Variables.sectionlist, itemsnow.ElementAt(i).section_id);
                if (!sectionlist.Items.Contains(sec.name))
                {
                    sectionlist.Items.Add(sec.name);
                }
                if (!Colorlist.Items.Contains(itemsnow.ElementAt(i).color))
                {
                    Colorlist.Items.Add(itemsnow.ElementAt(i).color);
                }

                itemui.descripiton.Text = "Description : " + itemsnow.ElementAt(i).description;
                flowLayoutPanel3.Controls.Add(itemui);
            }
        }

        private void min_txt_TextChanged(object sender, EventArgs e)
        {
            //here edit!!!!!
            int max=0, min=0;
           
            
            if (min_txt.Text=="")
            {
                min = 0;
            }
            else
                min = Convert.ToInt32(min_txt.Text);

            if (max_txt.Text=="")
            {
                max = min;
            }
            else
                max = Convert.ToInt32(max_txt.Text);
            itemsnow = Items.itemsearch(Variables.brandlist, searchBox.Text);
            itemsnow = Items.filterprice(itemsnow,min,max);
            flowLayoutPanel3.Controls.Clear();


            for (int i = 0; i < itemsnow.Count; i++)
            {
                Item_UC itemui = new Item_UC();

                itemui.item = itemsnow.ElementAt(i);
                itemui.name.Text = "Name : " + itemsnow.ElementAt(i).name;
                itemui.price.Text = "Price : " + itemsnow.ElementAt(i).price;
                itemui.color.Text = "Color : " + itemsnow.ElementAt(i).color;
                // draw hair
                // it.image.ImageLocation = Section.itemlist[i].image;
                if (itemsnow.ElementAt(i).image != null)
                {
                    MemoryStream stream = new MemoryStream(itemsnow.ElementAt(i).image);
                    itemui.image.Image = System.Drawing.Image.FromStream(stream);
                }
                Brand brand = new Brand();
                brand = Brand.getbrandbyid(Variables.brandlist, itemsnow.ElementAt(i).brand_id);
                itemui.brand.Text = "Brand : " + brand.name;
                if (!Brandlist.Items.Contains(brand.name))
                {
                    Brandlist.Items.Add(Variables.brandlist.ElementAt(i).name);
                }
                section sec = new section();
                sec = section.getsectionbyid(Variables.sectionlist, itemsnow.ElementAt(i).section_id);
                if (!sectionlist.Items.Contains(sec.name))
                {
                    sectionlist.Items.Add(sec.name);
                }
                if (!Colorlist.Items.Contains(itemsnow.ElementAt(i).color))
                {
                    Colorlist.Items.Add(itemsnow.ElementAt(i).color);
                }

                itemui.descripiton.Text = "Description : " + itemsnow.ElementAt(i).description;
                flowLayoutPanel3.Controls.Add(itemui);
            }

        }

        private void timer_home_Tick(object sender, EventArgs e)
        {
           
        }

        private void sortlist_SelectedValueChanged(object sender, EventArgs e)
        {
             //   itemsnow = Items.itemsearch(Variables.brandlist, searchBox.Text);
            if (sortlist.Text == "Name")
            {
                List<Items> tmp = new List<Items>(itemsnow);
                Items it = new Items();
                it.sortbyname(tmp);
                itemsnow = new LinkedList<Items>(tmp);

            }
            else if (sortlist.Text == "Price")
            {
                List<Items> tmp = new List<Items>(itemsnow);
                Items it = new Items();
                it.sortbyprice(tmp);
                itemsnow = new LinkedList<Items>(tmp);

            }

            flowLayoutPanel3.Controls.Clear();


            for (int i = 0; i < itemsnow.Count; i++)
            {
                Item_UC itemui = new Item_UC();

                itemui.item = itemsnow.ElementAt(i);
                itemui.name.Text = "Name : " + itemsnow.ElementAt(i).name;
                itemui.price.Text = "Price : " + itemsnow.ElementAt(i).price;
                itemui.color.Text = "Color : " + itemsnow.ElementAt(i).color;
                // draw hair
                // it.image.ImageLocation = Section.itemlist[i].image;
                if (itemsnow.ElementAt(i).image != null)
                {
                    MemoryStream stream = new MemoryStream(itemsnow.ElementAt(i).image);
                    itemui.image.Image = System.Drawing.Image.FromStream(stream);
                }
                Brand brand = new Brand();
                brand = Brand.getbrandbyid(Variables.brandlist, itemsnow.ElementAt(i).brand_id);
                itemui.brand.Text = "Brand : " + brand.name;
                if (!Brandlist.Items.Contains(brand.name))
                {
                    Brandlist.Items.Add(Variables.brandlist.ElementAt(i).name);
                }
                section sec = new section();
                sec = section.getsectionbyid(Variables.sectionlist, itemsnow.ElementAt(i).section_id);
                if (!sectionlist.Items.Contains(sec.name))
                {
                    sectionlist.Items.Add(sec.name);
                }
                if (!Colorlist.Items.Contains(itemsnow.ElementAt(i).color))
                {
                    Colorlist.Items.Add(itemsnow.ElementAt(i).color);
                }

                itemui.descripiton.Text = "Description : " + itemsnow.ElementAt(i).description;
                 flowLayoutPanel3.Controls.Add(itemui);
            }
        }

        private void bunifuFlatButton13_Click_1(object sender, EventArgs e)
        {
            del = true;
            timer1.Start();
            Form1.home.flowLayoutPanel3.Controls.Clear();
            uc = new Add();
            uc.label1.Text = "Delete";
            uc.radioButton2.Visible = false;
            Form1.home.flowLayoutPanel1.Controls.Clear();
            Form1.home.flowLayoutPanel1.Controls.Add(uc);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            filt_panel.Visible = false;
            user = true;
            timer1.Start();
            Form2 edit= new Form2();
            edit.textBox1.Text=Variables.usernow.name;
            edit.textBox2.Text=Variables.usernow.mail;
              edit.textBox3.Text=Variables.usernow.password;
            edit.textBox4.Text = Variables.usernow.phone;
            edit.textBox5.Text=Variables.usernow.adress;
            if (Variables.usernow.gender == "male")
                edit.radioButton1.Checked = true;
            else
                edit.radioButton2.Checked = true;
            edit.edit_button.Visible = true;
            edit.Show();
        }

        private void flowLayoutPanel3_Click(object sender, EventArgs e)
        {
            //  timer1.Start();
            pictureBox2.Click += new EventHandler(pictureBox2_Click);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsedd )
            {
                adminpanel.Height += 10;
                if (adminpanel.Size == adminpanel.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsedd = false;
                }
            }
            else 
            {
                adminpanel.Height -= 10;
                if (adminpanel.Size == adminpanel.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsedd = true;
                }
            }
        }



    }
}
