using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicine.dashboard
{
    public partial class Form2 : Form
    {
        String Connectingstring = "Server=DEESHA\\SQLEXPRESS;Database=workspace;Trusted_Connection=true";

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Connectingstring))
            {
                using (SqlCommand cmd = new SqlCommand("insert into medicine_dashboard values(@m_name,@price,@quantity)", con))
                {
                con.Open();
                    cmd.Parameters.AddWithValue("@m_name", txt_m_name.Text);
                    cmd.Parameters.AddWithValue("@price",txt_price.Text);
                    cmd.Parameters.AddWithValue("@quantity", txt_quantity.Text);
                    cmd.ExecuteNonQuery();
                    txt_m_name.Clear();
                    txt_price.Clear();
                    txt_quantity.Clear();
                    MessageBox.Show("data inserted successfully");
                }


            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void txt_m_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
