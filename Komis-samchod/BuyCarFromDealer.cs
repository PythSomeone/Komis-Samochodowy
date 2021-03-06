﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Komis_samchod
{
    public partial class BuyCarFromDealer : Form
    {
        public User user;
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;";
        public BuyCarFromDealer()
        {
            InitializeComponent();
        }

        private void BuyCarFromDealer_Load(object sender, EventArgs e)
        {

        }

        private void showcarsbtn_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txt_costmin.Text, out parsedValue) && !(txt_costmin.Text == ""))
            {
                MessageBox.Show("Cena powinna być liczbą");
                return;
            }
            if (!int.TryParse(txt_costmax.Text, out parsedValue) && !(txt_costmax.Text == ""))
            {
                MessageBox.Show("Cena powinna być liczbą");
                return;
            }
            if (!int.TryParse(txt_year.Text, out parsedValue) && !(txt_year.Text == ""))
            {
                MessageBox.Show("Rok powinien być liczbą");
                return;
            }
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand
                ("SELECT * FROM car WHERE(brand LIKE @brand AND available = 1 AND model LIKE @model AND color LIKE @color AND year LIKE CONVERT(varchar(50), @year) AND price >= ISNULL(CONVERT(int, @pricemin), price) AND price <= ISNULL(CONVERT(int, @pricemax), price))", con);

                if (!String.IsNullOrEmpty(txt_brand.Text))
                    cmd.Parameters.AddWithValue("@brand", txt_brand.Text);
                else
                    cmd.Parameters.AddWithValue("@brand", "%");

                if (!String.IsNullOrEmpty(txt_model.Text))
                    cmd.Parameters.AddWithValue("@model", txt_model.Text);
                else
                    cmd.Parameters.AddWithValue("@model", "%");

                if (!String.IsNullOrEmpty(txt_color.Text))
                    cmd.Parameters.AddWithValue("@color", txt_color.Text);
                else
                    cmd.Parameters.AddWithValue("@color", "%");

                if (!String.IsNullOrEmpty(txt_year.Text))
                    cmd.Parameters.AddWithValue("@year", txt_year.Text);
                else
                    cmd.Parameters.AddWithValue("@year", "%");

                if (!String.IsNullOrEmpty(txt_costmin.Text))
                    cmd.Parameters.AddWithValue("@pricemin", txt_costmin.Text);
                else
                    cmd.Parameters.AddWithValue("@pricemin", "");

                if (!String.IsNullOrEmpty(txt_costmax.Text))
                    cmd.Parameters.AddWithValue("@pricemax", txt_costmax.Text);
                else
                    cmd.Parameters.AddWithValue("@pricemax", 99999999);

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                adapt.Fill(dtbl);
                datagrid.DataSource = dtbl;
                datagrid.ReadOnly = true;
            }
        }

        private void buycarbtn_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txt_id.Text, out parsedValue))
            {
                MessageBox.Show("Id pojazdu powinno być liczbą");
                return;
            }
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand
                ("SELECT * FROM car WHERE id = @id AND available = 1", con);


                if (!String.IsNullOrEmpty(txt_id.Text))
                {
                    cmd.Parameters.AddWithValue("@id", txt_id.Text);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dtbl = new DataTable();
                    adapt.Fill(dtbl);
                    int index = dtbl.Rows.Count;
                    if (index == 1)
                    {
                        ConfirmPurchase buycar = new ConfirmPurchase();
                        buycar.user = user;
                        buycar.cartobuygrid.DataSource = dtbl;
                        buycar.cartobuygrid.ReadOnly = true;
                        buycar.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Pojazd z podanym id nie istnieje");
                    }
                }
                else
                    MessageBox.Show("Wprowadź id pojazdu, który chcesz kupić");


            }
        }

        private void backtbn_Click(object sender, EventArgs e)
        {
            if (user.mod == true)
            {
                ManagerPage menu = new ManagerPage();
                menu.user = user;
                menu.Show();
                this.Close();
            }
            if (user.mod == false)
            {
                MainUserPage menu = new MainUserPage();
                menu.user = user;
                menu.Show();
                this.Close();
            }
        }
    }
}
