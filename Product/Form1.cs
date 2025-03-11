using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Product
{
    public partial class Form1: Form
    {
        DataTable table = new DataTable("table");
        int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("productname", Type.GetType("System.String"));
            table.Columns.Add("price", Type.GetType("System.Double"));
            table.Columns.Add("quantity", Type.GetType("System.Int32"));
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Product Name";
            dataGridView1.Columns[2].HeaderText = "Price";
            dataGridView1.Columns[3].HeaderText = "Quantity";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("productname  like '%" + textBox1.Text + "%'");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox2.Text = row.Cells[0].Value.ToString();
            textBox3.Text = row.Cells[0].Value.ToString();
            textBox4.Text = row.Cells[0].Value.ToString();
            textBox5.Text = row.Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = textBox2.Text;
            newdata.Cells[0].Value = textBox3.Text;
            newdata.Cells[0].Value = textBox4.Text;
            newdata.Cells[0].Value = textBox5.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);


        }
    }
}
