using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        //Connection String
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;";
        //btn_Submit Click event
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
                    this.Hide();
                    if(!Convert.ToBoolean(ds.Tables[0].Rows[0]["modpermission"]))
                    {
                        MainUserPage fm = new MainUserPage();
                        fm.username = txt_UserName.Text;
                        fm.Show();
                    }
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["modpermission"]))
                    {
                        ManagerPage fm = new ManagerPage();
                        fm.username = txt_UserName.Text;
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
                if (count == 0)
                {
                    con.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd",con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@username", txt_UserName.Text);
                    sqlCmd.Parameters.AddWithValue("@password", txt_Password.Text);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Rejestracja się powiodła!");
                    this.Hide();
                    MainUserPage fm = new MainUserPage();
                    fm.username = txt_UserName.Text;
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
    }
}
