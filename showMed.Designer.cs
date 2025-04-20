namespace PROTOTYPE
{
    partial class showMed
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
            this.gen_name = new System.Windows.Forms.TextBox();
            this.brand_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Med_datagrid = new System.Windows.Forms.DataGridView();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Med_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generic Name ";
            // 
            // gen_name
            // 
            this.gen_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gen_name.Location = new System.Drawing.Point(106, 64);
            this.gen_name.Name = "gen_name";
            this.gen_name.Size = new System.Drawing.Size(100, 20);
            this.gen_name.TabIndex = 1;
            // 
            // brand_name
            // 
            this.brand_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brand_name.Location = new System.Drawing.Point(106, 103);
            this.brand_name.Name = "brand_name";
            this.brand_name.Size = new System.Drawing.Size(100, 20);
            this.brand_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Branded Name";
            // 
            // Med_datagrid
            // 
            this.Med_datagrid.AllowUserToAddRows = false;
            this.Med_datagrid.AllowUserToDeleteRows = false;
            this.Med_datagrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Med_datagrid.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.Med_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Med_datagrid.Location = new System.Drawing.Point(12, 140);
            this.Med_datagrid.MaximumSize = new System.Drawing.Size(588, 194);
            this.Med_datagrid.Name = "Med_datagrid";
            this.Med_datagrid.ReadOnly = true;
            this.Med_datagrid.Size = new System.Drawing.Size(588, 194);
            this.Med_datagrid.TabIndex = 4;
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchbtn.Location = new System.Drawing.Point(227, 101);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 5;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Show Medicines";
            // 
            // showMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(612, 346);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.Med_datagrid);
            this.Controls.Add(this.brand_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gen_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "showMed";
            this.Text = "showMed";
            ((System.ComponentModel.ISupportInitialize)(this.Med_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gen_name;
        private System.Windows.Forms.TextBox brand_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Med_datagrid;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label label3;
    }
}