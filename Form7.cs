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
    public partial class Form7 : Form
    {
        String Connectingstring = "Server=DEESHA\\SQLEXPRESS;Database=workspace;Integrated Security=true";
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Connectingstring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("insert into billing values(@c_name,@med_name,@qunt,@price)",con))
                {
                  
                    cmd.Parameters.AddWithValue("@c_name", txt_cust_name.Text);
                    cmd.Parameters.AddWithValue("@med_name",txt_mname.Text);
                    cmd.Parameters.AddWithValue("@qunt",txt_quntity.Text);
                    cmd.Parameters.AddWithValue("@price",txt_price.Text);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("bill printed successfully");

                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show("error: "+ex.Message);
                    }
                    
                     txt_cust_name.Clear();
                     txt_mname.Clear();
                     txt_quntity.Clear();
                     txt_price.Clear();
                   // MessageBox.Show("bill printed successfully");

                }
            
            
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
