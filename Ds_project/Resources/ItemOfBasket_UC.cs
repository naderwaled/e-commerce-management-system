using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ds_project
{
    public partial class ItemOfBasket_UC : UserControl
    {
        public Label status;
        public Label amount;
        public Label color;
        public PictureBox itempic;
        public Label name;
        public Button done_btn;
        public Label Customer;
        public Label Adress;
        public Label Phone;
        public Label Email;
        public request req = new request();
        public ItemOfBasket_UC()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.status = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.itempic = new System.Windows.Forms.PictureBox();
            this.done_btn = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itempic)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.status.Location = new System.Drawing.Point(299, 171);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(97, 32);
            this.status.TabIndex = 10;
            this.status.Text = "Status";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.amount.Location = new System.Drawing.Point(299, 130);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(120, 32);
            this.amount.TabIndex = 9;
            this.amount.Text = "Amount";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.BackColor = System.Drawing.Color.Transparent;
            this.color.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.color.Location = new System.Drawing.Point(300, 89);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(84, 32);
            this.color.TabIndex = 8;
            this.color.Text = "Color";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.name.Location = new System.Drawing.Point(300, 48);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(90, 32);
            this.name.TabIndex = 7;
            this.name.Text = "Name";
            // 
            // itempic
            // 
            this.itempic.BackColor = System.Drawing.Color.Transparent;
            this.itempic.Location = new System.Drawing.Point(11, 14);
            this.itempic.Name = "itempic";
            this.itempic.Size = new System.Drawing.Size(233, 256);
            this.itempic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itempic.TabIndex = 12;
            this.itempic.TabStop = false;
            // 
            // done_btn
            // 
            this.done_btn.Location = new System.Drawing.Point(816, 345);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(94, 41);
            this.done_btn.TabIndex = 13;
            this.done_btn.Text = "Done!";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Customer.Location = new System.Drawing.Point(542, 48);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(141, 32);
            this.Customer.TabIndex = 14;
            this.Customer.Text = "Customer";
            this.Customer.Visible = false;
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Adress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Adress.Location = new System.Drawing.Point(542, 89);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(106, 32);
            this.Adress.TabIndex = 15;
            this.Adress.Text = "Adress";
            this.Adress.Visible = false;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Phone.Location = new System.Drawing.Point(542, 130);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(96, 32);
            this.Phone.TabIndex = 16;
            this.Phone.Text = "Phone";
            this.Phone.Visible = false;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Email.Location = new System.Drawing.Point(542, 171);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(87, 32);
            this.Email.TabIndex = 16;
            this.Email.Text = "Email";
            this.Email.Visible = false;
            // 
            // ItemOfBasket_UC
            // 
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.itempic);
            this.Controls.Add(this.status);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.color);
            this.Controls.Add(this.name);
            this.Name = "ItemOfBasket_UC";
            this.Size = new System.Drawing.Size(913, 389);
            ((System.ComponentModel.ISupportInitialize)(this.itempic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            request.done_request(ref Variables.requestlist,req,"done");
            MessageBox.Show("Done");
        }
    }
}
