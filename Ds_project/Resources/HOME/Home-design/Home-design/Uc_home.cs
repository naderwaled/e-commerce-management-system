using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_design
{
    public partial class Uc_home : UserControl
    {
        Electronics elec = new Electronics();
        market market = new market();
        Fashion fashion = new Fashion();
        beauty beauty = new beauty();
        Mobiles mob = new Mobiles();
        hAppl app = new hAppl();
        public Uc_home()
        {
            InitializeComponent();
        }
         int imageno=1;
        private void  Nextimage()
        {
            if(imageno == 12)
            {
                imageno = 1;
            }
            slidepic.ImageLocation = string.Format(@"images\{0}.JPG", imageno);
            imageno++;

        }
            
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Uc_home_Load(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void search_lbl_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = " What are you looking for?";
            }
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "What are you looking for?")
            { 
                searchBox.Text = "";
            }
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(elec);
            market.Location = new Point(0, 138);
            this.Controls.Add(market);
            market.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Nextimage();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            
            elec.Location = new Point(0, 138);
            this.Controls.Add(elec);
            elec.BringToFront();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(elec);
            this.Controls.Remove(market);
            fashion.Location = new Point(0, 138);
            this.Controls.Add(fashion);
            fashion.BringToFront();
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(elec);
            this.Controls.Remove(market);
            this.Controls.Remove(fashion);
            beauty.Location = new Point(0, 138);
            this.Controls.Add(beauty);
            beauty.BringToFront();
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(elec);
            this.Controls.Remove(market);
            this.Controls.Remove(fashion);
            this.Controls.Remove(beauty);
            mob.Location = new Point(0, 138);
            this.Controls.Add(mob);
            mob.BringToFront();
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(elec);
            this.Controls.Remove(market);
            this.Controls.Remove(fashion);
            this.Controls.Remove(beauty);
            this.Controls.Remove(mob);
            app.Location = new Point(0, 138);
            this.Controls.Add(app);
            app.BringToFront();
        }
    }
}
