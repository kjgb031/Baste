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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Restaurant_Ordering_and_Payment
{
    public partial class itemsFrm : Form
    {
        const double price_Spag = 45;
        const double price_Burger = 35;
        const double price_BBQ = 86;
        const double price_Tacos = 90;
        const double price_SR = 95;
        const double price_Tempura = 70;
        const double price_Chicken = 30;
        const double price_Rice = 15;
        const double price_Coke = 20;
        const double price_Sprite = 20;
        const double price_Tea = 20;
        const double price_Lemonade = 15;
        const double price_Water = 10;
        public itemsFrm()
        {
            InitializeComponent();
        }
        public static string connection = "server = 127.0.0.1; user=root;  database= dbordering&paymentsystem; pass=; ";


        MySqlConnection mysqlconnt = new MySqlConnection(connection);
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit the system", " Ordering System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void itemsFrm_Load(object sender, EventArgs e)
        {
            cmbpayment.Items.Add(" ");
            cmbpayment.Items.Add("Cash");
            cmbpayment.Items.Add("Cash on Delivery");

            EnableTextBoxes();
        }

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);

            };
            func(Controls);
        }

        private void chkSpag_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpaghetti.Checked == true)
            {
                txtSpag.Enabled = true;
                txtSpag.Text = "";
                txtSpag.Focus();
            }
            else
            {
                txtSpag.Enabled = false;
                txtSpag.Text = "0";
            }
        }

        private void chkBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBurger.Checked == true)
            {
                txtBurger.Enabled = true;
                txtBurger.Text = "";
                txtBurger.Focus();
            }
            else
            {
                txtBurger.Enabled = false;
                txtBurger.Text = "0";
            }
        }

        private void chkBBQ_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBBQ.Checked == true)
            {
                txtBBQ.Enabled = true;
                txtBBQ.Text = "";
                txtBBQ.Focus();
            }
            else
            {
                txtBBQ.Enabled = false;
                txtBBQ.Text = "0";
            }
        }

        private void chkTacos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTacos.Checked == true)
            {
                txtTacos.Enabled = true;
                txtTacos.Text = "";
                txtTacos.Focus();
            }
            else
            {
                txtTacos.Enabled = false;
                txtTacos.Text = "0";
            }
        }

        private void chkSR_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSR.Checked == true)
            {
                txtSR.Enabled = true;
                txtSR.Text = "";
                txtSR.Focus();
            }
            else
            {
                txtSR.Enabled = false;
                txtSR.Text = "0";
            }
        }

        private void chkTempura_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTempura.Checked == true)
            {
                txtTempura.Enabled = true;
                txtTempura.Text = "";
                txtTempura.Focus();
            }
            else
            {
                txtTempura.Enabled = false;
                txtTempura.Text = "0";
            }
        }

        private void chkChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChicken.Checked == true)
            {
                txtChicken.Enabled = true;
                txtChicken.Text = "";
                txtChicken.Focus();
            }
            else
            {
                txtChicken.Enabled = false;
                txtChicken.Text = "0";
            }
        }

        private void chkRice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRice.Checked == true)
            {
                txtRice.Enabled = true;
                txtRice.Text = "";
                txtRice.Focus();
            }
            else
            {
                txtRice.Enabled = false;
                txtRice.Text = "0";
            }
        }

        private void chkCoke_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoke.Checked == true)
            {
                txtCoke.Enabled = true;
                txtCoke.Text = "";
                txtCoke.Focus();
            }
            else
            {
                txtCoke.Enabled = false;
                txtCoke.Text = "0";
            }
        }

        private void chkSprite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSprite.Checked == true)
            {
                txtSprite.Enabled = true;
                txtSprite.Text = "";
                txtSprite.Focus();
            }
            else
            {
                txtSprite.Enabled = false;
                txtSprite.Text = "0";
            }
        }

        private void cchkTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTea.Checked == true)
            {
                txtTea.Enabled = true;
                txtTea.Text = "";
                txtTea.Focus();
            }
            else
            {
                txtTea.Enabled = false;
                txtTea.Text = "0";
            }
        }

        private void chkLemonade_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLemonade.Checked == true)
            {
                txtLemonade.Enabled = true;
                txtLemonade.Text = "";
                txtLemonade.Focus();
            }
            else
            {
                txtLemonade.Enabled = false;
                txtLemonade.Text = "0";
            }
        }

        private void chkWater_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWater.Checked == true)
            {
                txtWater.Enabled = true;
                txtWater.Text = "";
                txtWater.Focus();
            }
            else
            {
                txtWater.Enabled = false;
                txtWater.Text = "0";
            }
        }

        private void cmbpayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbpayment.Text == "Cash")
            {
                txtpayment.Enabled = true;
                txtpayment.Text = "";
                txtpayment.Focus();
            }
            else if (cmbpayment.Text == "Cash on Delivery")
            {
                txtName.Enabled = true;
                txtAddress.Enabled = true;
                txtCnumber.Enabled = true;
                txtName.Text = "";
                txtAddress.Text = "";
                txtCnumber.Text = "";
                txtName.Focus();
                txtAddress.Focus();
                txtCnumber.Focus();
            }
            else
            {
                txtpayment.Enabled = false;
                txtpayment.Text = "0";
            }
        }
        public void btnTotal_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string receipt = "";

            if (!string.IsNullOrEmpty(txtSpag.Text))
            {
                itemcost[0] = double.Parse(txtSpag.Text) * price_Spag;
                receipt += $"Spaghetti: {txtSpag.Text} x {price_Spag} = {itemcost[0]:C}\n";
            }

            if (!string.IsNullOrEmpty(txtBBQ.Text))
            {
                itemcost[1] = double.Parse(txtBBQ.Text) * price_BBQ;
                receipt += $"BBQ: {txtBBQ.Text} x {price_BBQ} = {itemcost[1]:C}\n";
            }

            if (!string.IsNullOrEmpty(txtBurger.Text))
            {
                itemcost[2] = double.Parse(txtBurger.Text) * price_Burger;
                receipt += $"Burger: {txtBurger.Text} x {price_Burger} = {itemcost[2]:C}\n";
            }

            if (!string.IsNullOrEmpty(txtTacos.Text))
            {
                itemcost[3] = double.Parse(txtTacos.Text) * price_Tacos;
                receipt += $"Tacos: {txtTacos.Text} x {price_Tacos} = {itemcost[3]:C}\n";
            }

            if (!string.IsNullOrEmpty(txtSR.Text))
            {
                itemcost[4] = double.Parse(txtSR.Text) * price_SR;
                receipt += $"SR: {txtSR.Text} x {price_SR} = {itemcost[4]:C}\n";
            }

            if (!string.IsNullOrEmpty(txtTempura.Text))
            {
                itemcost[5] = double.Parse(txtTempura.Text) * price_Tempura;
                receipt += $"Tempura: {txtTempura.Text} x {price_Tempura} = {itemcost[5]:C}\n";
            }

            if (!string.IsNullOrEmpty(txtChicken.Text))
            {
                itemcost[6] = double.Parse(txtChicken.Text) * price_Chicken;
                receipt += $"Chicken: {txtChicken.Text} x {price_Chicken} = {itemcost[6]:C}\n";
            }

            if (!string.IsNullOrEmpty(txtRice.Text))
            {
                itemcost[7] = double.Parse(txtRice.Text) * price_Rice;
                receipt += $"Rice: {txtRice.Text} x {price_Rice} = {itemcost[7]:C}\n";
            }

            if (!string.IsNullOrEmpty(txtCoke.Text))
            {
                itemcost[8] = double.Parse(txtCoke.Text) * price_Coke;
                receipt += $"Coke: {txtCoke.Text} x {price_Coke} = {itemcost[8]:C}\n";
            }

            if (!string.IsNullOrEmpty(txtSprite.Text))
            {
                itemcost[9] = double.Parse(txtSprite.Text) * price_Sprite;
                receipt += $"Sprite: {txtSprite.Text} x {price_Sprite} = {itemcost[9]:C}\n";
            }

            if (!string.IsNullOrEmpty(txtTea.Text))
            {
                itemcost[10] = double.Parse(txtTea.Text) * price_Tea;
                receipt += $"Tea: {txtTea.Text} x {price_Tea} = {itemcost[10]:C}\n";
            }

            if (!string.IsNullOrEmpty(txtLemonade.Text))
            {
                itemcost[11] = double.Parse(txtLemonade.Text) * price_Lemonade;
                receipt += $"Lemonade: {txtLemonade.Text} x {price_Lemonade} = {itemcost[11]:C}\n";
            }

            if (!string.IsNullOrEmpty(txtWater.Text))
            {
                itemcost[12] = double.Parse(txtWater.Text) * price_Water;
                receipt += $"Water: {txtWater.Text} x {price_Water} = {itemcost[12]:C}\n";
            }

            double total, payment, cost;
            total = itemcost.Sum();
            receipt += $"\nTotal: {total:C}\n";

            lblresult.Text = total.ToString("C");

            if (cmbpayment.Text == "Cash")
            {
                payment = Convert.ToDouble(txtpayment.Text);
                cost = payment - total;

                if (payment >= total)
                {
                    receipt += $"Payment: {payment:C}\nChange: {cost:C}\n";
                    lblchangeresult.Text = cost.ToString("C");
                }
                else
                {
                    MessageBox.Show("Your payment is not enough.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                receipt += "Payment Method: Non-Cash\n";
            }

            MessageBox.Show(receipt, "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextBox();
        }
        private void ResetTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);

            };
            func(Controls);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for Choosing our Restaurant!" + " " + txtName.Text + " " + "We will deliver your Order at" + " " + txtAddress.Text + " "
                +
                "We will just remind/inform you at" + " " + txtCnumber.Text);

            try
            {
                mysqlconnt.Open();
                MessageBox.Show("Connected");
                string sql = "INSERT INTO data (Name, Address, Contact) VALUES (@Name, @Address, @Contact)";
                using (MySqlCommand command = new MySqlCommand(sql, mysqlconnt))
                {
                    // Using parameterized query to avoid SQL injection
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);
                    command.Parameters.AddWithValue("@Contact", txtCnumber.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Data inserted successfully");
                    //OK na to pre ikaw na kumalikot 


                }


            }
            catch { MessageBox.Show("mali ata hahah "); }
            finally { mysqlconnt.Close(); }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //Bat di malagyan ng txt
            //run mo tas pick mo cash on delivery
            }
    }
}