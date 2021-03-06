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

namespace Komis_samchod
{
    public partial class LoginPage : Form
    {
        public User user;
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;";
        public LoginPage()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Wpisz nazwę użytkownia i hasło");
                return;
            }
            try
            {
                
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from login where UserName=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txt_UserName.Text);
                cmd.Parameters.AddWithValue("@password", txt_Password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Logowanie się powiodło!");
                    int id = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
                    Boolean mod = Convert.ToBoolean(ds.Tables[0].Rows[0]["modpermission"]);
                    String name = Convert.ToString(ds.Tables[0].Rows[0]["username"]);
                    User user = new User(name, mod, id);
                    this.Hide();
                    if(!Convert.ToBoolean(ds.Tables[0].Rows[0]["modpermission"]))
                    {
                        MainUserPage fm = new MainUserPage();
                        fm.user = user;
                        fm.Show();
                    }
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["modpermission"]))
                    {
                        ManagerPage fm = new ManagerPage();
                        fm.user= user;
                        fm.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Logowanie nieudane!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Wpisz nazwę użytkownia i hasło");
                return;
            }
            try
            {

                /*
                Database1Entities1 db = new Database1Entities1();
                login dp = new login();
                dp.username = txt_UserName.Text;
                dp.password = txt_Password.Text;
                db.login.Add(dp);
                db.SaveChanges();
                MessageBox.Show("Rejestracja się powiodła!");
                this.Hide();
                MainUserPage fm = new MainUserPage();
                fm.username = txt_UserName.Text;
                fm.Show();


                */



                
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from login where UserName=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txt_UserName.Text);
                cmd.Parameters.AddWithValue("@password", txt_Password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count == 0)
                {
                    SqlCommand cmds = new SqlCommand("INSERT INTO login (username, password) VALUES ('"+txt_UserName.Text+"', '"+txt_Password.Text+"')", con);
                    try
                    {
                        cmds.ExecuteNonQuery();
                        MessageBox.Show("Rejestracja się powiodła!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    int id = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);
                    Boolean mod = Convert.ToBoolean(ds.Tables[0].Rows[0]["modpermission"]);
                    String name = Convert.ToString(ds.Tables[0].Rows[0]["username"]);
                    User user = new User(name, mod, id);
                    this.Hide();
                    MainUserPage fm = new MainUserPage();
                    fm.user.name = this.user.name;
                    fm.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("Rejestracja się nie powiodła!");
                }
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
