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
    public partial class FormSacar : Form
    {
        Conta conta;

        public FormSacar()
        {
            InitializeComponent();
            conta = new Conta();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtContaSaque_TextChanged(object sender, EventArgs e)
        {
            txtContaSaque.Text = conta.Nconta;
        }

        private void txtValorSaque_TextChanged(object sender, EventArgs e)
        {
            txtValorSaque.Text = conta.Valorsacar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voce realizou um Saque. O seu saldo atual é de: " + conta.Subs);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void FormSacar_Load(object sender, EventArgs e)
        {

        }
    }
}
