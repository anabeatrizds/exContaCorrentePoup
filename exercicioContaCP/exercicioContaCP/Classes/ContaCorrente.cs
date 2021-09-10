using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioContaCP.Classes
{
    class ContaCorrente : Conta
    {
        //Criar uma classe de nome ContaCorrente que herde de Conta
        //e tenha atributo adicional privado para limite. Crie construtores.
        private string limite;

        public ContaCorrente(string limite)
        {
            this.limite = limite;
        }
    }
}
