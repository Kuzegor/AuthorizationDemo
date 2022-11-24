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
    public partial class AdminForm : Form
    {
        AuthorizationForm AuthorizationForm;

        public AdminForm(string username, AuthorizationForm authorizationForm)
        {
            InitializeComponent();
            label1.Text = username;
            AuthorizationForm = authorizationForm;
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
