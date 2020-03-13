namespace Ds_project
{
    partial class viewsection
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
            this.ViewBtn = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewBtn.Location = new System.Drawing.Point(543, 234);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(223, 40);
            this.ViewBtn.TabIndex = 72;
            this.ViewBtn.Text = "View Section Items";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.description.Location = new System.Drawing.Point(283, 139);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(167, 33);
            this.description.TabIndex = 69;
            this.description.Text = "Description";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.name.Location = new System.Drawing.Point(283, 93);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(99, 33);
            this.name.TabIndex = 67;
            this.name.Text = "Name ";
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.Snow;
            this.image.Location = new System.Drawing.Point(23, 20);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(233, 256);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 66;
            this.image.TabStop = false;
            // 
            // viewsection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.description);
            this.Controls.Add(this.name);
            this.Controls.Add(this.image);
            this.Name = "viewsection";
            this.Size = new System.Drawing.Size(1077, 300);
            this.Load += new System.EventHandler(this.viewsection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewBtn;
        public System.Windows.Forms.Label description;
        public System.Windows.Forms.Label name;
        public System.Windows.Forms.PictureBox image;
    }
}
