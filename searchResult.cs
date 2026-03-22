using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicine.dashboard
{
    public partial class searchResult : Form
    {
        public searchResult(DataTable name)
        {
            InitializeComponent();
            dataGridView1.DataSource = name;
        }
    }
}
