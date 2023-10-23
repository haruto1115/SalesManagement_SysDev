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

namespace SalesManagement_SysDev
{
    public partial class kokyakukanri : Form
    {
        public kokyakukanri()
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void seachbtn_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Screnbtn_Click(object sender, EventArgs e)
        {
            SqlConnection kokyaku= new SqlConnection();
            SqlCommand command = new SqlCommand();
            kokyaku.ConnectionString =@"Data Source = (localdb)\MSSQLLocalDB:";

         /*   try
            {
                //利用するデータベースの設定
                var context = new kokyakukanri();
                //M_ClientのデータをList型でkokyakuに設定
                var kokyaku = context.M_Client.ToList();
                //dataGridView1に表示するデータを指定
                dataGridView1.DataSource = kokyaku;
                // DataGridViewを更新
                dataGridView1.Refresh();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         */
        }
    }
}
