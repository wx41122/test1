using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gitTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private DataTable ConnectData(string strsql)
        {
            DataSet temp = new DataSet();
            string strconnect = "Data Source=192.168.224.53;Integrated Security=false;Initial Catalog=FP_EMS_DB;User ID=sa;Password=nianhuahuayang";
            System.Data.SqlClient.SqlDataAdapter sa = new System.Data.SqlClient.SqlDataAdapter(strsql, strconnect);
            temp.Reset();

            sa.Fill(temp);

            if (temp.Tables.Count > 0)
            { return temp.Tables[0]; }

            else
            {
                return null;
            }
        }
    }
}
