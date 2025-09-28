using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectOOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> banks = new List<string>()
    {
        "Vietcombank",
        "VietinBank",
        "BIDV",
        "Techcombank",
        "ACB",
        "MB Bank",
        "Sacombank"
    };

            comboBox1.DataSource = banks;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null || string.IsNullOrWhiteSpace(textBox1.Text)
        || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please input fully information");
                return;
            }

            string selectedBank = comboBox1.SelectedItem.ToString();

        
            string amount = textBox2.Text;
            string receiver_id = textBox1.Text;

            MessageBox.Show($"Transferred {amount} VND to {receiver_id} ( {selectedBank}) successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
