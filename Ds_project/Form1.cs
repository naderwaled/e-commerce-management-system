using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ds_project;

namespace Ds_project
{
    public partial class Form1 : Form
    {

        public static Home home = new Home();


        public Form1()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            pictureBox2.BackgroundImage = Properties.Resources.user2;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox3.BackgroundImage = Properties.Resources.pas;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            pictureBox3.BackgroundImage = Properties.Resources.pas2;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            textBox2.ForeColor = Color.FromArgb(78, 184, 206);

            pictureBox2.BackgroundImage = Properties.Resources.user;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            form2.Left += 10;

            if (form2.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                form2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            form2.Left -= 10;
            if (form2.Left <= 525)
            {
                timer2.Stop();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Variables.loaddata.returnuserdata(ref Variables.userarr);
            form2.Hide();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isuser = Variables.usernow.login(textBox1.Text,textBox2.Text,Variables.userarr,ref Variables.usernow);
            if (isuser == true)
            {                              
                form2.Hide();
                this.Hide();
                if(!Variables.usernow.status)
                {
                    home.bunifuFlatButton4.Visible = true;
                    home.adminpanel.Visible = home.bunifuFlatButton1.Visible = false;
                    home.bunifuFlatButton4.Location = new Point(42, 173);
                    // home.adminpanel.Location = home.bunifuFlatButton1.Location = new Point(42, 454);
                    home.bunifuFlatButton3.Visible = true;
                }
                home.Show();

            }
            else
                MessageBox.Show("not found");
        }
    }
}
