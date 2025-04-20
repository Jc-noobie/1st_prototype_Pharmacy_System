using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace PROTOTYPE
{
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);




        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private MySqlConnection connection;

        private void DbConnection()
        {
            string connectionString = "Server=localhost;Port=3306;Database=pharmacy;User=root;Password=";
            
            connection = new MySqlConnection(connectionString);
        }

        private void registerAcc()
        {
            DbConnection();

            connection.Open();
            string text = "INSERT INTO account(acc_username,acc_useremail,acc_userpass) values (@username, @useremail,@userpass) ;";

            MySqlCommand cmd = new MySqlCommand(text, connection);

            cmd.Parameters.AddWithValue("@username", this.username.Text);
            cmd.Parameters.AddWithValue("@useremail", this.useremail.Text);
            cmd.Parameters.AddWithValue("@userpass", this.userpass.Text);

            cmd.Prepare();
            cmd.ExecuteNonQuery();


            connection.Close();

            MessageBox.Show("REGISTERED");
        }
       
        
        
        private void submitBtn_Click(object sender, EventArgs e)
        {
           registerAcc();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

}
