using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ContandoLetrasDosNumeros.AppConsole
{
    public class ContadorLetras
    {
        public Numero[] _numeroEscrita;
        public int _soma;
        public Numero Numero = new Zero();
        internal int GetResultadoSoma() => _soma;

        public Numero[] GetInstanciasDosNumeros()
        {
            Type parentType = typeof(Numero);
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            List<Numero> tipos = new List<Numero>();

            IEnumerable<Type> subclasses = types.Where(t => t.IsSubclassOf(parentType));

            foreach (var type in subclasses)
                tipos.Add((Numero)Activator.CreateInstance(type));

           return tipos.OrderBy(x => x.GetValor).ToArray();
        }
        public ContadorLetras(int valor)
        {
            _numeroEscrita = GetInstanciasDosNumeros();

            Numero.SetNumerosEscrita(_numeroEscrita);

            for (int index = 1; index <= valor; index++)
            {
                var numero = Numero.GetNumero(index);

                if (numero.Equal(index))
                    _soma += numero.CalcularCaracteres(index);
                else
                {
                    numero.SetNumerosEscrita(_numeroEscrita);
                    _soma += numero.GetSomaNumero(index);
                }
            }
        }
    }
}
