using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Acesso
{
    internal class Produto
    {
        /*
        public    -> Atributos e metodos visiveis em qualquer classe
        private   -> Atributos e metodos visiveis apenas na classe onde sao criados
        protected -> Atributos e metodos visiveis em classes onde sao criados ou herdados
        */

        public string nome;
        private double valor;
    }
}
