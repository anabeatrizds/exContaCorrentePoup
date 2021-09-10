using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioContaCP.Classes
{
    class ContaPoupanca : Conta
    {
        //Criar outra classe de nome Poupanca que herde de Conta
        //e tenha atributo privado adicional para dia de aniversário. Crie construtores
        private String dianiver;

        public ContaPoupanca(string dianiver)
        {
            this.dianiver = dianiver;
        }
    }
}
