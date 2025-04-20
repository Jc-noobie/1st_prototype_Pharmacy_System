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
    public partial class insertMed : Form
    {
        public insertMed()
        {
            InitializeComponent();
        }

        private MySqlConnection conn;
        private void dbConnection()
        {
            string connectionString = "Server=localhost;Port=3306;Database=pharmacy;User=root;Pass=";
            conn = new MySqlConnection(connectionString);
        }

        private void insertMedicine()
        {
            dbConnection();
            conn.Open();

            string query = "INSERT INTO medicine(med_id,generic_name,branded_name,price,quantity,expiry_date) values (@med_id,@gen_name,@brand_name ,@price,@quantity,@expiry_date)";
            MySqlCommand cmd = new MySqlCommand(query,conn);

            cmd.Parameters.AddWithValue("@med_id", this.med_id.Text);
            cmd.Parameters.AddWithValue("@gen_name", this.gen_name.Text);
            cmd.Parameters.AddWithValue("@brand_name", this.brand_name.Text);
            cmd.Parameters.AddWithValue("@price", this.price.Text);
            cmd.Parameters.AddWithValue("@quantity", this.quantity.Text);
            cmd.Parameters.AddWithValue("@expiry_date", this.expiry_date.Text);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            conn.Close();

            string caption = "Successfuly Inserted";
            MessageBox.Show("Medicine inserted", caption);
        }


        private void insertBtn_Click(object sender, EventArgs e)
        {
            insertMedicine();

        }
    }
}
