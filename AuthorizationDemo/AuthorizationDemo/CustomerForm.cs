using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorizationDemo
{
    public partial class CustomerForm : Form
    {
        public CustomerForm(string username)
        {
            InitializeComponent();
            label1.Text = username;
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
