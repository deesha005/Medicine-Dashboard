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
    public partial class Form5 : Form
    {
        String Connectingstring = "Server=DEESHA\\SQLEXPRESS;Database=workspace;Trusted_Connection=true";
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Connectingstring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("insert into add_to_cart values(@m_name,@quant,@pric)",con)) 
                { 
                    cmd.Parameters.AddWithValue("@m_name", txt_mn.Text);
                    cmd.Parameters.AddWithValue("@quant", txtq.Text);
                    cmd.Parameters.AddWithValue("@pric", txtp.Text);
                    cmd.ExecuteNonQuery();
                    txt_mn.Clear();
                    txtq.Clear();
                    txtp.Clear();
                    MessageBox.Show("data inserted into the cart successfully");
                    
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
