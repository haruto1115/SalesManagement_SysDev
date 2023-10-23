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


namespace SalesManagement_SysDev
{
    public partial class zaikokanri : Form
    {
        public zaikokanri()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string constr = 
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string sqlstr = "select * from productsB";
            SqlCommand com = new SqlCommand(sqlstr, con);
        }
    }
}
