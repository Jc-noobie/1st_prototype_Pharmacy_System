namespace PROTOTYPE
{
    partial class insertMed
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
            this.med_id = new System.Windows.Forms.TextBox();
            this.gen_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.brand_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.expiry_date = new System.Windows.Forms.DateTimePicker();
            this.insertBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine ID";
            // 
            // med_id
            // 
            this.med_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.med_id.Location = new System.Drawing.Point(178, 74);
            this.med_id.Name = "med_id";
            this.med_id.Size = new System.Drawing.Size(100, 20);
            this.med_id.TabIndex = 1;
            // 
            // gen_name
            // 
            this.gen_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gen_name.Location = new System.Drawing.Point(178, 108);
            this.gen_name.Name = "gen_name";
            this.gen_name.Size = new System.Drawing.Size(100, 20);
            this.gen_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Generic name";
            // 
            // brand_name
            // 
            this.brand_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brand_name.Location = new System.Drawing.Point(178, 142);
            this.brand_name.Name = "brand_name";
            this.brand_name.Size = new System.Drawing.Size(100, 20);
            this.brand_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Branded name";
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price.Location = new System.Drawing.Point(178, 176);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price\t";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Insert Medicine";
            // 
            // quantity
            // 
            this.quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantity.Location = new System.Drawing.Point(178, 210);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Expiration Date";
            // 
            // expiry_date
            // 
            this.expiry_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.expiry_date.CustomFormat = "yyyy-MM-dd";
            this.expiry_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiry_date.Location = new System.Drawing.Point(178, 245);
            this.expiry_date.Name = "expiry_date";
            this.expiry_date.Size = new System.Drawing.Size(83, 20);
            this.expiry_date.TabIndex = 6;
            // 
            // insertBtn
            // 
            this.insertBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertBtn.Location = new System.Drawing.Point(186, 280);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 7;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // insertMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(390, 370);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.expiry_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brand_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gen_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.med_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insertMed";
            this.Text = "insertMed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox med_id;
        private System.Windows.Forms.TextBox gen_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox brand_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker expiry_date;
        private System.Windows.Forms.Button insertBtn;
    }
}