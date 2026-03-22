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
    
    public partial class Form4 : Form
    {
        String Connectingstring = "Server=DEESHA\\SQLEXPRESS;database=workspace;Integrated Security=true";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Connectingstring))
            {
            
                con.Open();
                String a = "select md.medicine_name,md.price,md.quantity\r\nfrom medicine_dashboard as md\r\nunion all \r\nselect addc.medicine_name,addc.price,addc.quantity \r\nfrom add_to_cart as addc";
                SqlDataAdapter adapter = new SqlDataAdapter(a,con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                dataGridView1.DataSource = dt;




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
