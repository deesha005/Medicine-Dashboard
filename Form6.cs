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
    public partial class Form6 : Form
    {
        String Connectingstring = "Server=DEESHA\\SQLEXPRESS;Database=workspace;Trusted_Connection=true";
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Connectingstring))
            {
                con.Open();
                string a = "select * from add_to_cart";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(a, con);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
