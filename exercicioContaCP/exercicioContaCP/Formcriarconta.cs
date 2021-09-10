using exercicioContaCP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioContaCP
{
    public partial class Formcriarconta : Form
    {
        Conta conta;
        public Formcriarconta()
        {
            InitializeComponent();
            conta = new Conta();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtCliente.Text = conta.Cliente;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtNConta.Text = conta.Nconta;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtSaldo.Text = conta.Saldo;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente: " + conta.Cliente + " / Conta: " + conta.Nconta + " / Saldo: " + conta.Saldo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Formcriarconta_Load(object sender, EventArgs e)
        {

        }
    }
}
