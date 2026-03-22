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
    public partial class Form8 : Form
    {
        String Connectingstring = "Server=DEESHA\\SQLEXPRESS;Database=workspace;Trusted_Connection=true";

        public Form8()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Connectingstring)) 
            { 
                con.Open();
                string a = "select * from billing ";
                SqlDataAdapter adapter= new SqlDataAdapter(a,con);
                DataTable dt= new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource= dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
