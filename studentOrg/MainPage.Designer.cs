namespace studentOrg
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btEdetProgrameTable = new System.Windows.Forms.Button();
            this.btChangePass = new System.Windows.Forms.Button();
            this.btEditVolenterTable = new System.Windows.Forms.Button();
            this.btChangeEmail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Akhbar MT", 32F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(237, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "مؤسسة ملتقى الطلبة";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\MOHAMMAD\\Pictures\\blooger\\539064_505083706234705_871788233_n.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(12, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btEdetProgrameTable
            // 
            this.btEdetProgrameTable.BackColor = System.Drawing.Color.Olive;
            this.btEdetProgrameTable.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btEdetProgrameTable.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btEdetProgrameTable.Location = new System.Drawing.Point(379, 198);
            this.btEdetProgrameTable.Name = "btEdetProgrameTable";
            this.btEdetProgrameTable.Size = new System.Drawing.Size(184, 39);
            this.btEdetProgrameTable.TabIndex = 7;
            this.btEdetProgrameTable.Text = "تعديل على جدول البرامج";
            this.btEdetProgrameTable.UseVisualStyleBackColor = false;
            this.btEdetProgrameTable.Click += new System.EventHandler(this.btEdetProgrameTable_Click);
            // 
            // btChangePass
            // 
            this.btChangePass.BackColor = System.Drawing.Color.Olive;
            this.btChangePass.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btChangePass.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btChangePass.Location = new System.Drawing.Point(179, 198);
            this.btChangePass.Name = "btChangePass";
            this.btChangePass.Size = new System.Drawing.Size(184, 39);
            this.btChangePass.TabIndex = 2;
            this.btChangePass.Text = "تغير كلمة السر";
            this.btChangePass.UseVisualStyleBackColor = false;
            // 
            // btEditVolenterTable
            // 
            this.btEditVolenterTable.BackColor = System.Drawing.Color.Olive;
            this.btEditVolenterTable.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btEditVolenterTable.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btEditVolenterTable.Location = new System.Drawing.Point(379, 247);
            this.btEditVolenterTable.Name = "btEditVolenterTable";
            this.btEditVolenterTable.Size = new System.Drawing.Size(184, 39);
            this.btEditVolenterTable.TabIndex = 4;
            this.btEditVolenterTable.Text = "التعديل على جدول المتطوعين";
            this.btEditVolenterTable.UseVisualStyleBackColor = false;
            // 
            // btChangeEmail
            // 
            this.btChangeEmail.BackColor = System.Drawing.Color.Olive;
            this.btChangeEmail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btChangeEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btChangeEmail.Location = new System.Drawing.Point(179, 247);
            this.btChangeEmail.Name = "btChangeEmail";
            this.btChangeEmail.Size = new System.Drawing.Size(184, 39);
            this.btChangeEmail.TabIndex = 8;
            this.btChangeEmail.Text = "تغير ايميل الحساب";
            this.btChangeEmail.UseVisualStyleBackColor = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.btChangeEmail);
            this.Controls.Add(this.btEdetProgrameTable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btEditVolenterTable);
            this.Controls.Add(this.btChangePass);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "مؤسسة ملتقى الطلبة";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btEdetProgrameTable;
        private System.Windows.Forms.Button btChangePass;
        private System.Windows.Forms.Button btEditVolenterTable;
        private System.Windows.Forms.Button btChangeEmail;
    }
}