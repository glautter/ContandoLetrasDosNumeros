using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ContandoLetrasDosNumeros.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Total de letras: {new ContadorLetras(1000).GetResultadoSoma}");
            Console.ReadKey();
        }
    }
}
