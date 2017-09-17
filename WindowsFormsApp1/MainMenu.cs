using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.FormClosing += MainMenuClosing;
        }

        private void MainMenuClosing(object sender, FormClosingEventArgs e)
        {
            
                Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            TicketClass ticket = new TicketClass();
            ticket.AddTicket(dgv_ticket);
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int lastIndex = dgv_ticket.Rows.Count-1;
            dgv_ticket.Rows.Add();
            //generating random choices for lottery
            for (int i = 0; i < 5; i++)
            {
                int num = rand.Next(0, 50);
                dgv_ticket.CurrentCell = dgv_ticket.Rows[lastIndex].Cells[i];
                dgv_ticket.CurrentCell.Value = num;
            }

            dgv_ticket.FirstDisplayedScrollingRowIndex = lastIndex;
            dgv_ticket.Refresh();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int transactionID = int.Parse(txt_Search.Text);
            Results results = new Results(transactionID);
            results.Show();
            
        }
        
     }
}
    