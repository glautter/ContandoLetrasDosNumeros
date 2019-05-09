using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ContandoLetrasDosNumeros.AppConsole
{
    public class ContadorLetras
    {
        private Numero[] _numeroEscrita;
        private Numero _numero = new Zero();
        public int GetResultadoSoma { get; private set; }

        //Obter as classes correspondentes aos números
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
        //Construtor inicia o processo
        public ContadorLetras(int valor)
        {
            _numeroEscrita = GetInstanciasDosNumeros();

            _numero.SetNumerosEscrita(_numeroEscrita);

            for (int index = 1; index <= valor; index++)
            {
                var numero = _numero.GetNumero(index);

                if (numero.Equal(index))
                    Incrementar(numero.CalcularCaracteres(index));
                else
                {
                    numero.SetNumerosEscrita(_numeroEscrita);
                    Incrementar(numero.GetSomaNumero(index));
                }
            }
        }

        public int Incrementar(int numero)
        {
            return GetResultadoSoma += numero;
        }
    }
}
