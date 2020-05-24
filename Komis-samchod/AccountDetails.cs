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
    public partial class AccountDetails : Form
    {
        public User user;
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;";
        

        public AccountDetails()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand
             ("UPDATE [client] SET firstname = @firstname, lastname = @lastname, city = @city", con);
                cmd.Parameters.AddWithValue("@firstname", clientgrid.Rows[0].Cells["firstname"].Value.ToString());
                cmd.Parameters.AddWithValue("@lastname", clientgrid.Rows[0].Cells["lastname"].Value.ToString());
                cmd.Parameters.AddWithValue("@city", clientgrid.Rows[0].Cells["city"].Value.ToString());
                cmd.Parameters.AddWithValue("@email", clientgrid.Rows[0].Cells["email"].Value.ToString());
                DataTable dtbl = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dtbl);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            clientgrid.CancelEdit();
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

        private void AccountDetails_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand
                ("SELECT [firstname], [lastname], [city], [email] FROM client WHERE login_id = (SELECT id FROM login WHERE id = @login_id)", con);
                cmd.Parameters.AddWithValue("@login_id", user.id);

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                adapt.Fill(dtbl);
                clientgrid.DataSource = dtbl;
                for(int i = 0; i < clientgrid.Columns.Count; i++)
                {
                    clientgrid.Columns[i].Width = 180;
                }
            }
        }
    }
}
