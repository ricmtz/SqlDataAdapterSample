using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlDataAdapterSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            String connection = @"Server=HGDLMARTINEZHRI\SQLEXPRESS; Database=Hitss_TM; Trusted_Connection=True;";
            HitssDB hitssDB = new HitssDB(connection);
            this.dataGridView1.DataSource = hitssDB.GetAllEmployees().Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
