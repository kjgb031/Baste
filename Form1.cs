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

namespace Restaurant_Ordering_and_Payment
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string connection = "server = 127.0.0.1; user=root;  database= dbordering&paymentsystem; pass=; ";


 MySqlConnection mysqlconnt = new MySqlConnection(connection);
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            Form item = new itemsFrm();
            item.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit the system", " Ordering System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
            mysqlconnt.Open();
                MessageBox.Show("Connected");          } catch { MessageBox.Show("Not Connected"); }
            finally { mysqlconnt.Close(); }
    
        }
    }
}
