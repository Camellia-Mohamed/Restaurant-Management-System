using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBillList
{
    public partial class frmBillList : Form   //replace------> sampleAdd
    {
        public frmBillList()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        private void frmBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            //copy from frmproductView----->

            string qry = @"select MainID,TableName,WaiterName,orderType,status,total from tblMain
                           where status <> 'Pending' ";

            ListBox lb = new ListBox();

            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvWaiter);
            lb.Items.Add(dgvType);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTotal);


            MainClass.LoadData(qry, dataGridView1, lb);


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //for serial no

            int count = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentCell.OwningColumn.Name=="dgvedit")
            {
                //this is change as we have to set from text prop before open
                MainID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                this.Close();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
