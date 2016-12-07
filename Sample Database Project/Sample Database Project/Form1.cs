using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Database_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Server=tcp:c-sharp-course.database.windows.net,1433;Initial Catalog=C_Sharp_Course_Sample_Database;Persist Security Info=False;User ID=nsk;Password=QWEqwe123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            SqlCommand qc = new SqlCommand("INSERT INTO SampleTable VALUES ('1QWE1',1)", myConnection);

            myConnection.Open();

            qc.ExecuteNonQuery();

            myConnection.Close();
        }

        private void bRead_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Server=tcp:c-sharp-course.database.windows.net,1433;Initial Catalog=C_Sharp_Course_Sample_Database;Persist Security Info=False;User ID=nsk;Password=QWEqwe123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            myConnection.Open();

            SqlCommand qc = new SqlCommand("SELECT * FROM SampleTable", myConnection);
            SqlDataReader reader = qc.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    MessageBox.Show(reader.GetInt32(0) + " " + reader.GetString(1) + " " + reader.GetInt32(2));
                }
            }
            else
            {
                MessageBox.Show("No rows found.");
            }

            myConnection.Close();
        }

        private void bWrite_Click(object sender, EventArgs e)
        {

        }
    }
}
