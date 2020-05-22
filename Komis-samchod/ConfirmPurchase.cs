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
    
    public partial class ConfirmPurchase : Form
    {
        public User user;
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;";
        public ConfirmPurchase()
        {
            InitializeComponent();
        }

        private void ConfirmPurchase_Load(object sender, EventArgs e)
        {

        }

        private void cartobuygrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                int car_id = Convert.ToInt32(cartobuygrid.Rows[0].Cells["id"].Value);
                int value = Convert.ToInt32(cartobuygrid.Rows[0].Cells["price"].Value);
                DateTime date = DateTime.Today;

                SqlCommand cmd = new SqlCommand("INSERT INTO transaction (client_id, car_id, date, value, accepted) VALUES (@client_id, @car_id, @date, @value, 1)", con);
                cmd.Parameters.AddWithValue("@client_id", user.id);
                cmd.Parameters.AddWithValue("@car_id", car_id);
                cmd.Parameters.AddWithValue("@value", value);
                cmd.Parameters.AddWithValue("@date", date.ToString("d"));

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Zakup przebiegł pomyślnie!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Zakup się nie powiódł!");
                    MessageBox.Show(ex.Message);
                }
                SqlCommand cmds = new SqlCommand("DELETE FROM car WHERE id = @car_id", con);
                cmds.Parameters.AddWithValue("@car_id", car_id);
                try
                {
                    cmds.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (user.mod == true)
                {
                    ManagerPage menu = new ManagerPage();
                    menu.user = user;
                }
                if (user.mod == false)
                {
                    MainUserPage menu = new MainUserPage();
                    menu.user = user;
                }
            }
        }
    }
}
