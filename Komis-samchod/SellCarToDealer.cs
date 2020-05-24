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
    public partial class SellCarToDealer : Form
    {
        public User user;
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;";
        public SellCarToDealer()
        {
            InitializeComponent();
        }

        private void SellCarToDealer_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (txt_brand.Text == "" || txt_model.Text == "" || txt_year.Text == "" || txt_color.Text == "" || txt_price.Text == "")
            {
                MessageBox.Show("Uzupełnij wszystkie dane!");
                return;
            }
            int parsedValue;
            if (!int.TryParse(txt_year.Text, out parsedValue))
            {
                MessageBox.Show("Rok powinnien być liczbą");
                return;
            }
            if (!int.TryParse(txt_price.Text, out parsedValue))
            {
                MessageBox.Show("Cena powinna być liczbą");
                return;
            }
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                DateTime date = DateTime.Today;

                SqlCommand cmd = new SqlCommand("INSERT INTO [car] (brand, model, year, color, available) VALUES (@brand,  @model, @year, @color, 0) SELECT SCOPE_IDENTITY();", con);
                cmd.Parameters.AddWithValue("@brand", txt_brand.Text);
                cmd.Parameters.AddWithValue("@model", txt_model.Text);
                cmd.Parameters.AddWithValue("@year", txt_year.Text);
                cmd.Parameters.AddWithValue("@color", txt_color.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Oferta została wysłana!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oferta nie została wysłana!");
                    MessageBox.Show(ex.Message);
                }
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                adapt.Fill(dtbl);
                int car_id = Convert.ToInt32(dtbl.Rows[0][0]);
                car_id -= 1;
                
                SqlCommand cmds = new SqlCommand("INSERT INTO [transaction] (client_id, car_id, date, value, type) VALUES ( CONVERT(INT, @client_id), CONVERT(INT, @car_id), @date, CONVERT(INT, @value) , 0)", con);
                cmds.Parameters.AddWithValue("@client_id", user.id);
                cmds.Parameters.AddWithValue("@car_id", car_id);
                cmds.Parameters.AddWithValue("@value", txt_price.Text);
                cmds.Parameters.AddWithValue("@date", date.ToString("d"));
                try
                {
                    cmds.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

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
