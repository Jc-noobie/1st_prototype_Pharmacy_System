namespace PROTOTYPE
{
    partial class dashboard
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.stockMed = new System.Windows.Forms.Button();
            this.showMed = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.formPanel = new System.Windows.Forms.Panel();
            this.logolabel = new System.Windows.Forms.Label();
            this.sellMedbtn = new System.Windows.Forms.Button();
            this.profilebtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.menuPanel.Controls.Add(this.profilebtn);
            this.menuPanel.Controls.Add(this.sellMedbtn);
            this.menuPanel.Controls.Add(this.stockMed);
            this.menuPanel.Controls.Add(this.showMed);
            this.menuPanel.Controls.Add(this.home);
            this.menuPanel.Controls.Add(this.panellogo);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(170, 450);
            this.menuPanel.TabIndex = 0;
            // 
            // stockMed
            // 
            this.stockMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.stockMed.FlatAppearance.BorderSize = 0;
            this.stockMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockMed.ForeColor = System.Drawing.SystemColors.Control;
            this.stockMed.Location = new System.Drawing.Point(0, 180);
            this.stockMed.Name = "stockMed";
            this.stockMed.Size = new System.Drawing.Size(170, 40);
            this.stockMed.TabIndex = 3;
            this.stockMed.Text = "Resctock Medicine";
            this.stockMed.UseVisualStyleBackColor = true;
            this.stockMed.Click += new System.EventHandler(this.stockMed_Click);
            // 
            // showMed
            // 
            this.showMed.Dock = System.Windows.Forms.DockStyle.Top;
            this.showMed.FlatAppearance.BorderSize = 0;
            this.showMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showMed.ForeColor = System.Drawing.SystemColors.Control;
            this.showMed.Location = new System.Drawing.Point(0, 140);
            this.showMed.Name = "showMed";
            this.showMed.Size = new System.Drawing.Size(170, 40);
            this.showMed.TabIndex = 2;
            this.showMed.Text = "Show Medicine";
            this.showMed.UseVisualStyleBackColor = true;
            this.showMed.Click += new System.EventHandler(this.showMed_Click);
            // 
            // home
            // 
            this.home.Dock = System.Windows.Forms.DockStyle.Top;
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.ForeColor = System.Drawing.SystemColors.Control;
            this.home.Location = new System.Drawing.Point(0, 100);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(170, 40);
            this.home.TabIndex = 1;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.logolabel);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(170, 100);
            this.panellogo.TabIndex = 1;
            this.panellogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panellogo_MouseDown);
            // 
            // tabPanel
            // 
            this.tabPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.tabPanel.Controls.Add(this.button3);
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPanel.Location = new System.Drawing.Point(170, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(630, 38);
            this.tabPanel.TabIndex = 1;
            this.tabPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabPanel_MouseDown);
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.DimGray;
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(170, 38);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(630, 412);
            this.formPanel.TabIndex = 2;
            this.formPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logolabel
            // 
            this.logolabel.AutoSize = true;
            this.logolabel.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logolabel.ForeColor = System.Drawing.Color.White;
            this.logolabel.Location = new System.Drawing.Point(45, 38);
            this.logolabel.Name = "logolabel";
            this.logolabel.Size = new System.Drawing.Size(84, 27);
            this.logolabel.TabIndex = 0;
            this.logolabel.Text = "LOGO";
            // 
            // sellMedbtn
            // 
            this.sellMedbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sellMedbtn.FlatAppearance.BorderSize = 0;
            this.sellMedbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellMedbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.sellMedbtn.Location = new System.Drawing.Point(0, 220);
            this.sellMedbtn.Name = "sellMedbtn";
            this.sellMedbtn.Size = new System.Drawing.Size(170, 40);
            this.sellMedbtn.TabIndex = 4;
            this.sellMedbtn.Text = "Sell medicine";
            this.sellMedbtn.UseVisualStyleBackColor = true;
            this.sellMedbtn.Click += new System.EventHandler(this.sellMedbtn_Click);
            // 
            // profilebtn
            // 
            this.profilebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.profilebtn.FlatAppearance.BorderSize = 0;
            this.profilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.profilebtn.Location = new System.Drawing.Point(0, 260);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(170, 40);
            this.profilebtn.TabIndex = 5;
            this.profilebtn.Text = "Profile";
            this.profilebtn.UseVisualStyleBackColor = true;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(601, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 29);
            this.button3.TabIndex = 0;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "dashboard";
            this.ShowIcon = false;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.menuPanel.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.tabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button stockMed;
        private System.Windows.Forms.Button showMed;
        private System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label logolabel;
        private System.Windows.Forms.Button sellMedbtn;
        private System.Windows.Forms.Button profilebtn;
        private System.Windows.Forms.Button button3;
    }
}