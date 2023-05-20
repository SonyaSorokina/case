using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Atele
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 main = this.Owner as Form3;
            if (main != null)
            {
                DataRow nRow = main.ateleDataSet1.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = comboBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = Convert.ToInt32(textBox3.Text);
                main.ateleDataSet1.Tables[0].Rows.Add(nRow);
                main.услугиTableAdapter.Update(main.ateleDataSet1.Услуги);
                main.ateleDataSet1.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                comboBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
