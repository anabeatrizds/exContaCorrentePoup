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
    public partial class Form1 : Form
    {
        //Conta conta;
        //Conta sacar;
        //Conta depositar;
        public Form1()
        {
            InitializeComponent(); 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formcriarconta form2 = new Formcriarconta();
            this.Hide();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSacar form3 = new FormSacar();
            this.Hide();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDepositar form4 = new FormDepositar();
            this.Hide();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formcontapoup form5 = new Formcontapoup();
            this.Hide();
            form5.Show();
        }
    }
}
