using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioContaCP.Classes
{
    class Conta
    {
        //Criar uma classe de nome Conta que possua atributos privados para cliente, numero da conta e saldo.
        private string cliente;
        private string saldo;
        private string nconta;
        private string valorsacar;
        private string valordepositar;
        int subs;
        int soma;

        //Crie métodos de acesso set e get e construtores.
        public Conta()
        {
            cliente = "";
            saldo = "";
            nconta = "";
        }

        public Conta(string cliente, string saldo, string nconta)
        {
            this.cliente = cliente;
            this.saldo = saldo;
            this.nconta = nconta;
        }

        public string Cliente { get => cliente; set => cliente = value; }
        public string Saldo { get => saldo; set => saldo = value; }
        public string Nconta { get => nconta; set => nconta = value; }
        public string Valorsacar { get => valorsacar; set => valorsacar = value; }
        public string Valordepositar { get => valordepositar; set => valordepositar = value; }
        public int Subs { get => subs; set => subs = value; }
        public int Soma { get => soma; set => soma = value; }

        //Crie um método chamado sacar e outro depositar que recebe valores a ser movimentados na conta.
        //metodo sacar - subtrair
        //metodo depositar - somar
        public int Sacar(string valorsacar)
        {
            valorsacar = "";
            int valor1 = Convert.ToInt32(valorsacar);
            int valor2 = Convert.ToInt32(saldo);
            Subs =  valor2 - valor1;
            return Subs;
        }
        public int Depositar(string valordepositar)
        {
            valordepositar = "";
            int valor1 = Convert.ToInt32(valordepositar);
            int valor2 = Convert.ToInt32(saldo);
            Soma = valor1 + valor2;
            return Soma;
        }
    }
}
