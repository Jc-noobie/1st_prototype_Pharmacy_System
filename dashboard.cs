using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PROTOTYPE
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);






        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private MySqlConnection conn = new MySqlConnection();


        public void loadForm(object form )
        {
            if(formPanel.Controls.Count > 0)
            {
                this.formPanel.Controls.RemoveAt(0);

            }

            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.formPanel.Controls.Add(frm);
            this.formPanel.Tag = form;
            frm.Show();
        }

       
        private void sellMedbtn_Click(object sender, EventArgs e)
        {
            loadForm(new sellMed());
        }
        private void showMed_Click(object sender, EventArgs e)
        {
            loadForm(new showMed());
        }

        private void stockMed_Click(object sender, EventArgs e)
        {
            loadForm(new insertMed());
        }
        private void profilebtn_Click(object sender, EventArgs e)
        {
            loadForm(new profile());
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            loadForm(new showMed());
        }





        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panellogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
