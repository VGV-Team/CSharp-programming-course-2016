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

        private DateTime lastDate;
        public Form1()
        {
            InitializeComponent();
            lastDate = new DateTime(2010,10,10);
            timer1.Start();
        }


        private void insertTable()
        {
            SqlConnection myConnection = new SqlConnection("Server=tcp:c-sharp-course.database.windows.net,1433;Initial Catalog=C_Sharp_Course_Sample_Database;Persist Security Info=False;User ID=nsk;Password=QWEqwe123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            myConnection.Open();
            var commandStr = "CREATE TABLE Messages(Id int PRIMARY KEY identity(1,1),MessageDate datetime NOT NULL,MessageContent varchar(200) NOT NULL,MessageSender varchar(50) NOT NULL)";
            using (SqlCommand command = new SqlCommand(commandStr, myConnection))
                command.ExecuteNonQuery();
            myConnection.Close();
        }

        private void sendData()
        {
            SqlConnection myConnection = new SqlConnection("Server=tcp:c-sharp-course.database.windows.net,1433;Initial Catalog=C_Sharp_Course_Sample_Database;Persist Security Info=False;User ID=nsk;Password=QWEqwe123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            //SqlCommand qc = new SqlCommand("INSERT INTO Messages(MessageDate, MessageContent, MessageSender) VALUES (GETDATE(),'Burek aka kebab', 'VGV Team')", myConnection);
            SqlCommand qc = new SqlCommand("INSERT INTO Messages(MessageDate, MessageContent, MessageSender) VALUES ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','"+tbMessage.Text+"', '"+tbName.Text+"')", myConnection);
            myConnection.Open();
            qc.ExecuteNonQuery();
            myConnection.Close();
        }

        private void getData()
        {
            SqlConnection myConnection = new SqlConnection("Server=tcp:c-sharp-course.database.windows.net,1433;Initial Catalog=C_Sharp_Course_Sample_Database;Persist Security Info=False;User ID=nsk;Password=QWEqwe123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            myConnection.Open();
            
            //SqlCommand qc = new SqlCommand("SELECT * FROM Messages", myConnection);
            SqlCommand qc = new SqlCommand("SELECT MessageDate as md, MessageContent as mc, MessageSender as ms FROM Messages WHERE MessageDate > '" + lastDate.ToString("yyyy-MM-dd HH:mm:ss") + "' ORDER BY MessageDate ASC", myConnection);
            SqlDataReader reader = qc.ExecuteReader();

            if (reader.HasRows)
            {
                //tbChatText.Text = "";
                while (reader.Read())
                {
                    //MessageBox.Show(reader.GetInt32(0) + " " + reader.GetDateTime(1).ToString() + " " + reader.GetString(2) + " " + reader.GetString(3));
                    //MessageBox.Show(reader["md"] + " " + reader["mc"] + " " + reader["ms"]);
                    tbChatText.AppendText("[" + reader["md"] + "] (" + reader["ms"] + ") :" + reader["mc"] + "\r\n");
                    lastDate = Convert.ToDateTime(reader["md"]);
                }
            }
            else
            {
                //MessageBox.Show("No rows found.");
            }

            myConnection.Close();
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            sendData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getData();
        }
    }
}
