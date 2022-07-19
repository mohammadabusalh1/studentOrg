namespace studentOrg
{
    partial class Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newPass = new System.Windows.Forms.Label();
            this.tlMassege = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\MOHAMMAD\\Pictures\\blooger\\background-with-colorful-hands-green-circle\\p1" +
    ".jpg";
            this.pictureBox1.Location = new System.Drawing.Point(-326, -42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "C:\\Users\\MOHAMMAD\\Pictures\\blooger\\background-with-colorful-hands-green-circle\\p1" +
    ".jpg";
            this.pictureBox2.Location = new System.Drawing.Point(302, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(422, 375);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.tlMassege);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(35, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 294);
            this.panel1.TabIndex = 2;
            // 
            // newPass
            // 
            this.newPass.AutoSize = true;
            this.newPass.Font = new System.Drawing.Font("Arial", 10F);
            this.newPass.Location = new System.Drawing.Point(22, 29);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(112, 16);
            this.newPass.TabIndex = 6;
            this.newPass.Text = "هل نسيت كلمة المرور؟";
            this.newPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.newPass.Click += new System.EventHandler(this.newPass_Click);
            // 
            // tlMassege
            // 
            this.tlMassege.AutoSize = true;
            this.tlMassege.Font = new System.Drawing.Font("Arial", 9F);
            this.tlMassege.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tlMassege.Location = new System.Drawing.Point(30, 235);
            this.tlMassege.Name = "tlMassege";
            this.tlMassege.Size = new System.Drawing.Size(167, 15);
            this.tlMassege.TabIndex = 5;
            this.tlMassege.Text = "إسم المستخدم أو كلمة المرور غير صحيحية";
            this.tlMassege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tlMassege.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Arial", 10F);
            this.button1.ForeColor = System.Drawing.Color.Olive;
            this.button1.Location = new System.Drawing.Point(93, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "تسجيل الدخول";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.SystemColors.Info;
            this.tbPass.Location = new System.Drawing.Point(54, 159);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(143, 20);
            this.tbPass.TabIndex = 3;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(124, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة المرور";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.Info;
            this.tbName.Location = new System.Drawing.Point(54, 95);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(143, 20);
            this.tbName.TabIndex = 1;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(116, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "إسم المستخدم";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 446);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Olive;
            this.panel3.Controls.Add(this.newPass);
            this.panel3.Location = new System.Drawing.Point(87, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 73);
            this.panel3.TabIndex = 7;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "مؤسسة ملتقى الطلبة";
            this.TransparencyKey = System.Drawing.Color.Olive;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tlMassege;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label newPass;
        private System.Windows.Forms.Panel panel3;
    }
}