using System;

namespace FacadePatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeCredito concedeCredito = new FacadeCredito();

            Cliente cliente1 = new Cliente("Teste001");

            bool resultado = concedeCredito.ConcederEmprestimo(cliente1, 199000.00);

            Console.WriteLine("O empréstimo pleiteado pelo cliente " + cliente1.Nome + " foi  " + (resultado ? "Aprovado" : "Negado"));

            Console.ReadKey();
        }
    }
}
