using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komis_samchod
{
    public partial class ManagerPage : Form
    {
        public String username;
        public ManagerPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManagerPage_Load(object sender, EventArgs e)
        {
            welcomemessage.Text = "Witaj " + username + "!";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void welcomemessage_Click(object sender, EventArgs e)
        {
            
        }

        private void ManagerPage_Load_1(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginPage lo = new LoginPage();
            lo.Show();
            this.Close();
        }
    }
}
