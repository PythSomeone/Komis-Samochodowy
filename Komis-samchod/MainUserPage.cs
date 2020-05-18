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
    public partial class MainUserPage : Form
    {
        public String username;
        public MainUserPage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainUserPage_Load(object sender, EventArgs e)
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
    }
}
