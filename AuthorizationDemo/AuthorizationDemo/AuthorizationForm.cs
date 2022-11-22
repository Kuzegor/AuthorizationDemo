using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorizationDemo
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AuthorizationDB"].ConnectionString);
            string query = $"select * from dbo.Users where UserPassword = '{passwordTextBox.Text}'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string username = table.Rows[0].ItemArray[1].ToString();
                if (table.Rows[0].ItemArray[3].ToString() == 1.ToString())
                {
                    CustomerForm customerForm = new CustomerForm(username,this);
                    customerForm.Show();
                    passwordTextBox.Clear();
                    this.Hide();
                }
                else if (table.Rows[0].ItemArray[3].ToString() == 2.ToString())
                {
                    ManagerForm managerForm = new ManagerForm(username,this);
                    managerForm.Show();
                    passwordTextBox.Clear();
                    this.Hide();
                }
                else if (table.Rows[0].ItemArray[3].ToString() == 3.ToString())
                {
                    AdminForm adminForm = new AdminForm(username, this);
                    adminForm.Show();
                    passwordTextBox.Clear();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The password is correct but there are no forms that you can access", "Unknown Role", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("The password is incorrect", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
