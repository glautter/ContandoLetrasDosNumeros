using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContandoLetrasDosNumeros.AppConsole
{
    public abstract class Numero
    {
        public Numero[] _numerosEscrita;
        public Numero() { }
        public void SetNumerosEscrita(Numero[] numeros) => _numerosEscrita = numeros;
        public virtual int CalcularCaracteres(int numero) 
            => Equal(numero) ? GetQuantidadeDeCaracteres : 0;
        public abstract int GetValor { get; }
        public int GetQuantidadeDeCaracteres => this.GetType().Name.Length;        
        public bool Equal(int numero) => GetValor == numero;
        private int StringToInt(string numero) => int.Parse(numero);

        public Numero GetNumeroNaoIrregular(int number)
        {
            foreach (var numeroEscrita in _numerosEscrita)
                if (numeroEscrita.GetValor == number)
                    return numeroEscrita;

            return null;
        }
        public Numero GetNumero(int numero)
        {
            var numeroEncontrado = GetNumeroNaoIrregular(numero);
            if (numeroEncontrado != null)
                return numeroEncontrado;

            foreach (var numeroEscrita in _numerosEscrita)
            {
                if (numeroEscrita.GetValor > numero)
                    return numeroEscrita;
            }

            return numeroEncontrado;
        }

        public int GetSomaNumero(int numero)
        {
            int numberSum = 0;

            foreach (var unidade in SepararUnidades(numero))
            {
                if (StringToInt(unidade) > 0)
                {
                    var numeroEncontrado = GetNumero(int.Parse(unidade));
                    numberSum += numeroEncontrado.CalcularCaracteres(numeroEncontrado.GetValor);
                    numberSum++;
                }
            }

            return numberSum--;
        }

        private string[] SepararUnidades(int numero)
        {
            int index = 0;
            int indexador = numero.ToString().Length;
            string texto = string.Empty;

            var unidadesSeparadas = new string[indexador];

            foreach (char caracter in numero.ToString())
            {
                var valorCaracter = caracter - '0';
                texto = valorCaracter.ToString();

                for (int i = 1; i < indexador; i++)
                {
                    texto += "0";
                    indexador--;
                }

                unidadesSeparadas.SetValue(texto, index);
                index++;
            }

            return unidadesSeparadas;
        }
    }
}
