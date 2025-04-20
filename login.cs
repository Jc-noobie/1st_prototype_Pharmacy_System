using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace PROTOTYPE
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false; 
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        private void login_load(object sender, EventArgs e)
        {

        }
        // drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam,int lParam);


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        //VARIABLESS
        // ______________________________________________________________
        private MySqlConnection connection;

        string usernameTemp;
        string userpassword;
        // ______________________________________________________________

        //FUNCTIONSSS
        // ______________________________________________________________




        //CONNECTION FUNCTION
        // _________________________
        private void dbConnection()
        {
            string connectionString = "Server=localhost;Port=3306;Database=pharmacy;User=root;Password=";
            connection = new MySqlConnection(connectionString);
        }
        // _________________________


        private void findAcc()
        {
            usernameTemp = this.usernameInput.Text;
            userpassword = this.userpass.Text;

            dbConnection();

            connection.Open();

            String query = "SELECT * FROM account where acc_username = '" + usernameTemp + "' AND acc_userpass = '" + userpassword + "' ";
            MySqlCommand command = new MySqlCommand(query, connection);

            if (command.ExecuteScalar() != null)
            {
                this.Hide();
                dashboard dashform = new dashboard();
                dashform.ShowDialog();
                dashform = null;
                this.Show();

            }
            else
            {
                string message = "The account does not exist";
                string caption = "Login unsuccessful";

                MessageBox.Show(message, caption);
            }
            connection.Close();
        }
      

        // BUTTON LOGIN 
        // _________________________
       
        private void loginbtn_Click(object sender, EventArgs e)
        {
            findAcc();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Register regForm = new Register();
            regForm.ShowDialog();

            regForm = null;

            this.Show();
        }
        // _________________________



        // ______________________________________________________________

    }
}
