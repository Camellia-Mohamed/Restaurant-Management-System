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

namespace frmWaiterSelect
{
    public partial class frmWiterSelect : Form
    {
        public frmWiterSelect()
        {
            InitializeComponent();
        }
        public string WaiterName;

        public object MainClass { get; private set; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string qry = "Select * from staff where sRole like 'waiter'";
            SqlCommand cmd = new SqlCommand(qry, MainClass.Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Button b = new System.Windows.Forms.Button();
                b.Text = row["sName"].ToString();
                b.Width = 150;
                b.Height = 50;
                //b.fillColor = Color.FromArgb(241, 85, 126);
                //b.hoverState.FillColor = Color.FromArgb(50, 55, 89);

                //event for click
                b.Click += new EventHandler(b_Click);
                flowLayoutPanel1.Controls.Add(b);

            }
        }

        private void b_Click(object sender, EventArgs e)
        {

            WaiterName = (sender as System.Windows.Forms.Button).Text.ToString();
            this.Close();
        }
        
    }
}
