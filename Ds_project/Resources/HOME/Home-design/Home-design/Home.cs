using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_design
{
    public partial class Home : Form
    {
        int pw;
        bool hide, isCollapsed;

        public Home()
        {
            InitializeComponent();

            hide = true;
           pw= sl_panel.Width;
            sl_panel.Width = 25;
            

            


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
                
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_men_Click(object sender, EventArgs e)
        {
           
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Uc_home home = new Uc_home();
            this.Controls.Add(home);
            sl_panel.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
          
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sl_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Uc_home home = new Uc_home();
            this.Controls.Add(home);
            home.BringToFront();
            sl_panel.BringToFront();
            header.BringToFront();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (hide)
            {
                sl_panel.Width = sl_panel.Width + 20;
              if(sl_panel.Width>25)
                    pictureBox3.Visible = false;

                if (sl_panel.Width >=pw)
                {
                    timer1.Stop();
                    hide = false;
                    this.Refresh();
                }
            }
            else
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

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                dragdown.Height += 10;
                if(dragdown.Size==dragdown.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                dragdown.Height -= 10;
                if (dragdown.Size == dragdown.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }
    }
}
