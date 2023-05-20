using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atele
{
    public partial class Form4 : Form
    {
        int x;
        public Form4()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ateleDataSet2.Услуги". При необходимости она может быть перемещена или удалена.
            this.услугиTableAdapter.Fill(this.ateleDataSet2.Услуги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            if (main != null)
            {
                DataRow nRow = main.ateleDataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox1.Text;
                nRow[2] = textBox2.Text;
                nRow[3] = comboBox1.Text;
                nRow[4] = comboBox2.Text;
                nRow[5] = textBox3.Text;
                nRow[6] = textBox4.Text;
                nRow[7] = textBox5.Text;
                nRow[8] = Convert.ToInt32(textBox6.Text);
                nRow[9] = textBox7.Text;
                nRow[10] = Convert.ToInt32(comboBox3.Text) + Convert.ToInt32(textBox6.Text);
                main.ateleDataSet.Tables[0].Rows.Add(nRow);
                main.клиентыTableAdapter.Update(main.ateleDataSet.Клиенты);
                main.ateleDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = comboBox2.SelectedIndex;
            comboBox3.SelectedIndex = x;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
