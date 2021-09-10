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
    public partial class FormDepositar : Form
    {
        Conta conta;
        public FormDepositar()
        {
            InitializeComponent();
            conta = new Conta();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtContaD.Text = conta.Nconta;
        }

        private void txtValorD_TextChanged(object sender, EventArgs e)
        {
            txtValorD.Text = conta.Valordepositar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voce realizou um Deposito. O seu saldo atual é de: " + conta.Soma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
