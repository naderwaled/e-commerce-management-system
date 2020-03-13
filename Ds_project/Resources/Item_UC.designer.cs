namespace Ds_project
{
    partial class Item_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.descripiton = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.brand = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // descripiton
            // 
            this.descripiton.AutoSize = true;
            this.descripiton.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripiton.ForeColor = System.Drawing.Color.DimGray;
            this.descripiton.Location = new System.Drawing.Point(32, 322);
            this.descripiton.Name = "descripiton";
            this.descripiton.Size = new System.Drawing.Size(205, 38);
            this.descripiton.TabIndex = 2;
            this.descripiton.Text = "Description :";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color.ForeColor = System.Drawing.Color.DimGray;
            this.color.Location = new System.Drawing.Point(331, 89);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(113, 38);
            this.color.TabIndex = 3;
            this.color.Text = "Color :";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.DimGray;
            this.price.Location = new System.Drawing.Point(331, 147);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(112, 38);
            this.price.TabIndex = 4;
            this.price.Text = "Price :";
            // 
            // brand
            // 
            this.brand.AutoSize = true;
            this.brand.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand.ForeColor = System.Drawing.Color.DimGray;
            this.brand.Location = new System.Drawing.Point(331, 203);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(122, 38);
            this.brand.TabIndex = 5;
            this.brand.Text = "Brand :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(333, 391);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(30, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 38);
            this.label8.TabIndex = 11;
            this.label8.Text = "Amount You Want :";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.DimGray;
            this.name.Location = new System.Drawing.Point(331, 45);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(129, 38);
            this.name.TabIndex = 3;
            this.name.Text = "Name : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ds_project.Properties.Resources.bu;
            this.pictureBox1.Location = new System.Drawing.Point(645, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // image
            // 
            this.image.Image = global::Ds_project.Properties.Resources.casio;
            this.image.Location = new System.Drawing.Point(14, 3);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(296, 286);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // Item_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Controls.Add(this.color);
            this.Controls.Add(this.descripiton);
            this.Controls.Add(this.image);
            this.Name = "Item_UC";
            this.Size = new System.Drawing.Size(992, 508);
            this.Load += new System.EventHandler(this.Item_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox image;
        public System.Windows.Forms.Label descripiton;
        public System.Windows.Forms.Label color;
        public System.Windows.Forms.Label price;
        public System.Windows.Forms.Label brand;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
