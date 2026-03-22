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
    public partial class Form1 : Form
    {
        String Connectingstring = "Server=DEESHA\\SQLEXPRESS;Database=workspace;Trusted_Connection=true";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void addm_btn_Click(object sender, EventArgs e)
        {
           Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void showm_btn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void medicinehistory_btn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void addtocart_btn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void showcart_btn_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void showbill_btn_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();  
            form7.ShowDialog();
        }

        private void client_hist_btn_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
          
           string b = textBox.Text;
            DataTable dt = Search(b);
            if(dt.Rows.Count > 0)
            {
                searchResult xy = new searchResult(dt);
                xy.Show();
                
            }
            else
            {
                MessageBox.Show("dont have!!");
            }
            textBox.Text = "";

        }

        private DataTable Search(string name)
        {
            DataTable dt = new DataTable();
            string a = "select * from medicine_dashboard where medicine_name like @name";
            using (SqlConnection con = new SqlConnection(Connectingstring)) 
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(a,con))
                { 
                    cmd.Parameters.AddWithValue("@name","%" + name+"%");
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    sqlDataAdapter.Fill(dt);
                }
                return dt;
            }
        
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
