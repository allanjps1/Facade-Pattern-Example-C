using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternExample
{
    public class Cliente
    {
        public string Nome { get; set; }
        public Cliente(string nome)
        {
            Nome = nome;
        }

    }
}
