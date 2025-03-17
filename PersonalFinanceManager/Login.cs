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

namespace PersonalFinanceManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }


        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EEDNUE7;Initial Catalog=LoginDetails;Integrated Security=True");

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username, password, userType;
            username = txtusername.Text;
            password = txtpassword.Text;

            try
            {
                string querry ="SELECT * FROM Login WHERE username = '"+txtusername.Text+"'AND password = '"+txtpassword.Text+"' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable(); 
                sda.Fill(dt);

                if(dt.Rows.Count > 0 )
                {

                    userType = dt.Rows[0]["type"].ToString();
                    string userName = dt.Rows[0]["name"].ToString();

                    if (userType == "Admin")
                    {
                        //Crudfrm cr = new Crudfrm();
                        //cr.Show();
                    }
                    else if (userType == "User")
                    {
                        //Userfrm userForm = new Userfrm(userName);
                        //userForm.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtusername.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registrationfrm rg = new Registrationfrm();
            rg.Show();
            this.Hide();
        }
    }
}
