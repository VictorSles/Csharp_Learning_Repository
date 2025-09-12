// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosPassos
{
    public class TiposVar
    {
        public void ConhecendoTiposVar() 
        {
            // INT
            int age = 21;
            float salary = 3.600f; // Acrescentar o "f"
            decimal casa = 74m; // acrescentar o "m"
            double altura = 1.9d; // acrescentar o "d"
            bool namorando = true;
            bool solteiro = false;
            char inicial = 'A';
            string nomeCompleto = "Israel Victor Dias Sales";
            var cidade = "Manauas - AM"; // Variável sem tipo pré-definido
            const int nacimento = 2003;
        }
    }
}
// Escrita no console
Console.WriteLine("Hello, World!");
