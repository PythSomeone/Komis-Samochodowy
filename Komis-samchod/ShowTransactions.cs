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
    public partial class ShowTransactions : Form
    {
        public User user;
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;";
        public ShowTransactions()
        {
            InitializeComponent();
        }

        private void ShowTransactions_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [transaction] WHERE client_id = @client_id", con);
                cmd.Parameters.AddWithValue("@client_id", user.id);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                adapt.Fill(dtbl);
                transdatagrid.DataSource = dtbl;
                transdatagrid.ReadOnly = true;


            }
        }

        private void showcarsbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DataTable dtbl = new DataTable();
                
                if (transdatagrid.SelectedCells.Count > 0)
                {
                    DataTable append = new DataTable();
                    int selectedrowindex = transdatagrid.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = transdatagrid.Rows[selectedrowindex];
                    int car_id = Convert.ToInt32(selectedRow.Cells["car_id"].Value);
                    SqlCommand cmd = new SqlCommand("SELECT * FROM car WHERE id = @car_id", con);
                    cmd.Parameters.AddWithValue("@car_id", car_id);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    adapt.Fill(append);
                    dtbl.Merge(append);


                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                cardatagrid.DataSource = dtbl;
                cardatagrid.ReadOnly = true;
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
