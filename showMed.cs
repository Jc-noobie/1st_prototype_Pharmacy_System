using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient; 


namespace PROTOTYPE
{
    public partial class showMed : Form
    {
        public showMed()
        {
            InitializeComponent();
        }

        private MySqlConnection conn;

        private void dbConnection()
        {
            string connectionString = "Server=localhost;Port=3306;Database=pharmacy;User=root;Pass=";
            conn = new MySqlConnection(connectionString);
        }

        private void DatagridQuery(string cmdText)
        {
            MySqlDataAdapter mda = new MySqlDataAdapter();
            mda.SelectCommand = new MySqlCommand(cmdText, conn);
            DataTable dataTable = new DataTable();
            mda.Fill(dataTable);

            BindingSource bind = new BindingSource();
            bind.DataSource = dataTable;


            Med_datagrid.DataSource = bind;
        }


        private void selectStmt()
        {
            dbConnection();
            conn.Open();

            string genericname = gen_name.Text;
            string brandedname = brand_name.Text;


            if(genericname == "" && brandedname == "")
            {
                string cmdText = "SELECT * FROM medicine;";
                DatagridQuery(cmdText);

            } else if(genericname == "" && brandedname != "")
            {
                string cmdText = "SELECT * FROM medicine where branded_name = '"+brandedname+"' ";
                DatagridQuery(cmdText);
            } else if(genericname != "" && brandedname == "")
            {
                string cmdText = "SELECT * FROM medicine where generic_name = '"+genericname+"' ";
                DatagridQuery(cmdText);
            }



            conn.Close();

        }



        private void searchbtn_Click(object sender, EventArgs e)
        {
            selectStmt();
        }
    }
}
