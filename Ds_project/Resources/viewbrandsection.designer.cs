namespace Ds_project
{
    partial class viewbrandsection
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
            this.phone = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.DimGray;
            this.phone.Location = new System.Drawing.Point(306, 183);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(103, 33);
            this.phone.TabIndex = 9;
            this.phone.Text = "phone ";
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.ForeColor = System.Drawing.Color.DimGray;
            this.country.Location = new System.Drawing.Point(306, 91);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(128, 33);
            this.country.TabIndex = 8;
            this.country.Text = "Country ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.DimGray;
            this.name.Location = new System.Drawing.Point(306, 45);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(99, 33);
            this.name.TabIndex = 7;
            this.name.Text = "Name ";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.ForeColor = System.Drawing.Color.DimGray;
            this.mail.Location = new System.Drawing.Point(306, 229);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(78, 33);
            this.mail.TabIndex = 9;
            this.mail.Text = "Mail ";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.DimGray;
            this.description.Location = new System.Drawing.Point(306, 137);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(167, 33);
            this.description.TabIndex = 9;
            this.description.Text = "Description";
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewBtn.Location = new System.Drawing.Point(531, 267);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(223, 40);
            this.ViewBtn.TabIndex = 65;
            this.ViewBtn.Text = "View Brand Items";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.Snow;
            this.image.Image = global::Ds_project.Properties.Resources.casio;
            this.image.Location = new System.Drawing.Point(27, 16);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(233, 256);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 6;
            this.image.TabStop = false;
            // 
            // viewbrandsection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.description);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.country);
            this.Controls.Add(this.name);
            this.Controls.Add(this.image);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "viewbrandsection";
            this.Size = new System.Drawing.Size(1031, 348);
            this.Load += new System.EventHandler(this.viewbrandsection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label phone;
        public System.Windows.Forms.Label country;
        public System.Windows.Forms.Label name;
        public System.Windows.Forms.PictureBox image;
        public System.Windows.Forms.Label mail;
        public System.Windows.Forms.Label description;
        private System.Windows.Forms.Button ViewBtn;
    }
}
