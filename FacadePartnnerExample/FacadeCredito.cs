using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternExample
{
    public class FacadeCredito
    {
        private LimiteCredito limite = new LimiteCredito();
        private Serasa serasa = new Serasa();
        
        public bool ConcederEmprestimo(Cliente cliente, double valor)
        {
            Console.WriteLine("{0} esta pleitando um empréstimo no valor de {1:C}\n", cliente.Nome, valor);

            bool ConcederEmprestimo = true;

            if (serasa.EstaNoSerasa(cliente))
            {
                Console.WriteLine("Cliente " + cliente.Nome + " possui restrição no SERASA");
                ConcederEmprestimo = false;
            }
            else if (!limite.PossuiLimiteCredito(cliente, valor))
            {
                Console.WriteLine("O Cliente {0} possui limite de crédido inferior a {1:C}\n ", cliente.Nome, valor);
                ConcederEmprestimo = false;
            }
            return ConcederEmprestimo;
        }
    }
}
