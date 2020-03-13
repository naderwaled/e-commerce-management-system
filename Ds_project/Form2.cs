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
    public partial class Form2 : Form
    {
        public static Home home = new Home();
        public Form2()
        {
            InitializeComponent();
        }
        string gender = "";
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            user.BackgroundImage = Properties.Resources.user2;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);

            email.BackgroundImage = Properties.Resources.email;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            pass.BackgroundImage = Properties.Resources.pas;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

            phone.BackgroundImage = Properties.Resources.phone;
            panel4.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

            address.BackgroundImage = Properties.Resources.agenda;
            panel5.BackColor = Color.WhiteSmoke;
            textBox5.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            email.BackgroundImage = Properties.Resources.email2;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            textBox2.ForeColor = Color.FromArgb(78, 184, 206);

            user.BackgroundImage = Properties.Resources.user;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            pass.BackgroundImage = Properties.Resources.pas;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

            phone.BackgroundImage = Properties.Resources.phone;
            panel4.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

            address.BackgroundImage = Properties.Resources.agenda;
            panel5.BackColor = Color.WhiteSmoke;
            textBox5.ForeColor = Color.WhiteSmoke;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox3.PasswordChar = '*';
            pass.BackgroundImage = Properties.Resources.pas2;
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            textBox3.ForeColor = Color.FromArgb(78, 184, 206);

            email.BackgroundImage = Properties.Resources.email;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            user.BackgroundImage = Properties.Resources.user;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            phone.BackgroundImage = Properties.Resources.phone;
            panel4.BackColor = Color.WhiteSmoke;
            textBox4.ForeColor = Color.WhiteSmoke;

            address.BackgroundImage = Properties.Resources.agenda;
            panel5.BackColor = Color.WhiteSmoke;
            textBox5.ForeColor = Color.WhiteSmoke;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            phone.BackgroundImage = Properties.Resources.phone2;
            panel4.BackColor = Color.FromArgb(78, 184, 206);
            textBox4.ForeColor = Color.FromArgb(78, 184, 206);

            user.BackgroundImage = Properties.Resources.user;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            pass.BackgroundImage = Properties.Resources.pas;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

            email.BackgroundImage = Properties.Resources.email;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            address.BackgroundImage = Properties.Resources.agenda;
            panel5.BackColor = Color.WhiteSmoke;
            textBox5.ForeColor = Color.WhiteSmoke;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {

            textBox5.Clear();
            address.BackgroundImage = Properties.Resources.agenda2;
            panel5.BackColor = Color.FromArgb(78, 184, 206);
            textBox5.ForeColor = Color.FromArgb(78, 184, 206);

            user.BackgroundImage = Properties.Resources.user;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            pass.BackgroundImage = Properties.Resources.pas;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

            email.BackgroundImage = Properties.Resources.email;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            phone.BackgroundImage = Properties.Resources.phone;
            panel4.BackColor = Color.WhiteSmoke;
            textBox4.ForeColor = Color.WhiteSmoke;
        }

        private void add_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isfill= true;
            if(textBox1.Text!="")
            Variables.usernow.name =textBox1.Text ;
            if (textBox2.Text != "")
                Variables.usernow.mail = textBox2.Text;
            if (textBox3.Text != "")
                Variables.usernow.password = textBox3.Text;
            if (textBox4.Text != "")
                Variables.usernow.phone = textBox4.Text;
            if (textBox5.Text != "")
                Variables.usernow.adress = textBox5.Text;
            if (gender != "")
                Variables.usernow.gender = gender;
            else
            {
                MessageBox.Show("Please enter all data.");
                isfill = false;
            }
            if (isfill == true)
            {
                bool isregister = Variables.usernow.register(Variables.userarr,Variables.usernow);
                if (isregister == true)
                {
                    MessageBox.Show("vaild");
                    this.Hide();

                    if (!Variables.usernow.status)
                    {
                        Form1.home.bunifuFlatButton4.Visible = true;
                        Form1.home.adminpanel.Visible = Form1.home.bunifuFlatButton1.Visible = false;
                        Form1.home.bunifuFlatButton4.Location = new Point(42, 173);
                        // home.adminpanel.Location = home.bunifuFlatButton1.Location = new Point(42, 454);
                        Form1.home.bunifuFlatButton3.Visible = true;
                    }
                    Form1.home.Show();

                }
               
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            user usernow = new user();
            usernow.id = Variables.usernow.id;
            usernow.name = textBox1.Text;
            usernow.mail = textBox2.Text;
            usernow.password = textBox3.Text;
            usernow.phone = textBox4.Text;
            usernow.adress = textBox5.Text;
            usernow.gender = gender;
            usernow.status = false;
            bool isedit = Variables.usernow.edituserdata(Variables.userarr,usernow);
            if (isedit == true)
            {
                MessageBox.Show("Edited");
                Variables.usernow.name = textBox1.Text;
                Variables.usernow.mail = textBox2.Text;
                Variables.usernow.password = textBox3.Text;
                Variables.usernow.phone = textBox4.Text;
                Variables.usernow.adress = textBox5.Text;
                Variables.usernow.gender = gender;
              
            }
            else
            {
                MessageBox.Show("Enter another name or phone");
            }
        }
    }
}
