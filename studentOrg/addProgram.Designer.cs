namespace studentOrg
{
    partial class addProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btAddProg = new System.Windows.Forms.Button();
            this.programName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 32F);
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "اضافة الى البرامج";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.LightGray;
            this.btClose.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.btClose.Location = new System.Drawing.Point(177, 214);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "خروج";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 11F);
            this.label2.Location = new System.Drawing.Point(346, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم البرنامج";
            // 
            // btAddProg
            // 
            this.btAddProg.BackColor = System.Drawing.Color.LightGray;
            this.btAddProg.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.btAddProg.Location = new System.Drawing.Point(335, 138);
            this.btAddProg.Name = "btAddProg";
            this.btAddProg.Size = new System.Drawing.Size(75, 23);
            this.btAddProg.TabIndex = 3;
            this.btAddProg.Text = "إضافة";
            this.btAddProg.UseVisualStyleBackColor = false;
            this.btAddProg.Click += new System.EventHandler(this.btAddProg_Click);
            // 
            // programName
            // 
            this.programName.Location = new System.Drawing.Point(258, 112);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(152, 20);
            this.programName.TabIndex = 4;
            // 
            // addProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 249);
            this.Controls.Add(this.programName);
            this.Controls.Add(this.btAddProg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label1);
            this.Name = "addProgram";
            this.Text = "addProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAddProg;
        private System.Windows.Forms.TextBox programName;
    }
}