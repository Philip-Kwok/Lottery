using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class TicketClass
    {
        //method to search ticket by name and display results in a display table
        public void DisplayResults(int transactionID, DataGridView dgv_search)
        {
            int search = transactionID;
            //creating connection
            string connString = null;
            SqlConnection sqlConn;
            connString = "Data Source=DESKTOP-30191JE\\SQLEXPRESS01;Initial Catalog=Test1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string searchString = "Select num1,num2,num3,num4,num5 from TicketTable WHERE TransactionID = @TransactionID";
            sqlConn = new SqlConnection(connString);


            try
            {
                sqlConn.Open();
                SqlCommand searchCMD = new SqlCommand(searchString, sqlConn);
                searchCMD.Parameters.AddWithValue("@TransactionID", search);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(searchCMD);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgv_search.DataSource = null;
                dgv_search.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            sqlConn.Close();
        }

        //method to add ticket records into a DB
        public void AddTicket(DataGridView dgv_ticket)
        {
            float price = (dgv_ticket.Rows.Count) * 2;
            string connString = null;
            //SQL strings
            string selectTicketIDString = "SELECT MAX(TransactionID) FROM ticketTable";
            string MainTableInsertString = "INSERT INTO MainTable (TransactionID,ClerkID,PurchaseDate,Price) Values (@TransactionID,@ClerkID,@PurchaseDate,@Price)";
            string TicketTableInsertString = "INSERT INTO TicketTable (TransactionID,TicketID,num1,num2,num3,num4,num5) Values (@TransactionID,@TicketID,@num1,@num2,@num3,@num4,@num5)";
            //creating connection
            SqlConnection sqlConn;
            connString = "Data Source=DESKTOP-30191JE\\SQLEXPRESS01;Initial Catalog=Test1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlConn = new SqlConnection(connString);

            try
            {

                int TransactionID = 0;
                //SQL commands
                SqlCommand selectTicketIDCMD = new SqlCommand(selectTicketIDString, sqlConn);
                SqlCommand mainTableInsertCMD = new SqlCommand(MainTableInsertString, sqlConn);
                SqlCommand ticketTableInsertCMD = new SqlCommand(TicketTableInsertString, sqlConn);
                sqlConn.Open();
                object obj = selectTicketIDCMD.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    TransactionID = 1000;
                }
                TransactionID = (int)selectTicketIDCMD.ExecuteScalar() + 1;
                sqlConn.Close();
                if (TransactionID < 999)
                {
                    TransactionID = 1000;
                }
                //adding parameters into SQL command for Ticket Table insert
                ticketTableInsertCMD.Parameters.AddWithValue("@TransactionID", TransactionID);
                ticketTableInsertCMD.Parameters.Add("@TicketID", SqlDbType.Int);
                ticketTableInsertCMD.Parameters.Add("@num1", SqlDbType.Int);
                ticketTableInsertCMD.Parameters.Add("@num2", SqlDbType.Int);
                ticketTableInsertCMD.Parameters.Add("@num3", SqlDbType.Int);
                ticketTableInsertCMD.Parameters.Add("@num4", SqlDbType.Int);
                ticketTableInsertCMD.Parameters.Add("@num5", SqlDbType.Int);


                //insertion and looping for multiple tickets
                for (int i = 0; i < dgv_ticket.Rows.Count - 1; i++)
                {
                    ticketTableInsertCMD.Parameters["@TicketID"].Value = i;
                    ticketTableInsertCMD.Parameters["@num1"].Value = int.Parse(dgv_ticket.Rows[i].Cells[0].Value.ToString());
                    ticketTableInsertCMD.Parameters["@num2"].Value = int.Parse(dgv_ticket.Rows[i].Cells[1].Value.ToString());
                    ticketTableInsertCMD.Parameters["@num3"].Value = int.Parse(dgv_ticket.Rows[i].Cells[2].Value.ToString());
                    ticketTableInsertCMD.Parameters["@num4"].Value = int.Parse(dgv_ticket.Rows[i].Cells[3].Value.ToString());
                    ticketTableInsertCMD.Parameters["@num5"].Value = int.Parse(dgv_ticket.Rows[i].Cells[4].Value.ToString());
                    sqlConn.Open();
                    ticketTableInsertCMD.ExecuteNonQuery();
                    sqlConn.Close();

                }

                //inserting transaction information into Database
                mainTableInsertCMD.Parameters.AddWithValue("@TransactionID", TransactionID);
                mainTableInsertCMD.Parameters.AddWithValue("@ClerkID", LoginScreen.getClerkID());
                mainTableInsertCMD.Parameters.AddWithValue("@PurchaseDate", System.DateTime.Now);
                mainTableInsertCMD.Parameters.AddWithValue("@Price", price);

                sqlConn.Open();
                mainTableInsertCMD.ExecuteNonQuery();
                sqlConn.Close();
                MessageBox.Show("Ticket successfully made.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to server!\n" + ex.ToString());
            }
        }
    }
}
