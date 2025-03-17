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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonalFinanceManager
{
    public partial class Registrationfrm : Form
    {
        public Registrationfrm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login ll = new Login();
            ll.Show();
            this.Hide();
            txtusername.Focus();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) ||
                string.IsNullOrWhiteSpace(txtusername.Text) ||
                string.IsNullOrWhiteSpace(cmbtype.Text) ||
                string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-EEDNUE7;Initial Catalog=LoginDetails;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Login VALUES(@name, @username, @password, @type)", con);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@username", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                cmd.Parameters.AddWithValue("@type", cmbtype.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Account Successfully Created");

                Login ll1 = new Login();
                ll1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
