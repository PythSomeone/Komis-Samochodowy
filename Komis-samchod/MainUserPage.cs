﻿using System;
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
        public User user;
        public MainUserPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainUserPage_Load(object sender, EventArgs e)
        {
            welcomemessage.Text = "Witaj " + user.name + "!";
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

        private void browsecars_Click(object sender, EventArgs e)
        {
            BuyCarFromDealer buy = new BuyCarFromDealer();
            buy.user = user;
            buy.Show();
            this.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginPage lo = new LoginPage();
            lo.Show();
            this.Close();
        }

        private void sendoffer_Click(object sender, EventArgs e)
        {
            SellCarToDealer sell = new SellCarToDealer();
            sell.user = user;
            sell.Show();
            this.Close();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sell_Click(object sender, EventArgs e)
        {

        }

        private void showtrans_Click(object sender, EventArgs e)
        {
            ShowTransactions trans = new ShowTransactions();
            trans.user = user;
            trans.Show();
            this.Close();
        }

        private void changeinfobtn_Click(object sender, EventArgs e)
        {
            AccountDetails acc = new AccountDetails();
            acc.user = user;
            acc.Show();
            this.Close();
        }
    }
}
