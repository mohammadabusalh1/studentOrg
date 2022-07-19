namespace studentOrg
{
    partial class ManeageProgramTable
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
            this.dvPrograme = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvPrograme)).BeginInit();
            this.SuspendLayout();
            // 
            // dvPrograme
            // 
            this.dvPrograme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvPrograme.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvPrograme.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dvPrograme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvPrograme.Location = new System.Drawing.Point(12, 39);
            this.dvPrograme.Name = "dvPrograme";
            this.dvPrograme.Size = new System.Drawing.Size(483, 301);
            this.dvPrograme.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.White;
            this.btAdd.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btAdd.Location = new System.Drawing.Point(539, 92);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(107, 29);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "اضافة";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.White;
            this.btRemove.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btRemove.Location = new System.Drawing.Point(539, 146);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(107, 29);
            this.btRemove.TabIndex = 2;
            this.btRemove.Text = "حذف";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.White;
            this.btEdit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btEdit.Location = new System.Drawing.Point(539, 203);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(107, 29);
            this.btEdit.TabIndex = 3;
            this.btEdit.Text = "تعديل";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.White;
            this.btRefresh.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btRefresh.Location = new System.Drawing.Point(539, 257);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(107, 29);
            this.btRefresh.TabIndex = 4;
            this.btRefresh.Text = "تحديث";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // ManeageProgramTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(668, 380);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dvPrograme);
            this.Name = "ManeageProgramTable";
            this.Text = "ManeageProgramTable";
            this.Load += new System.EventHandler(this.ManeageProgramTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvPrograme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvPrograme;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btRefresh;
    }
}