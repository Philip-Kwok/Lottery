using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Results : Form
    {

        public Results(int transactionID)
        {
            InitializeComponent();
            TicketClass ticket = new TicketClass();
            ticket.DisplayResults(transactionID,dgv_search);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TicketClass ticket = new TicketClass();
            ticket.AddTicket(dgv_ticket);
        }
    }
    }

