using ContandoLetrasDosNumeros.AppConsole;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ContantoLetrasTest
{
    [TestClass]
    public class NumeroTest
    {
        private readonly int[] _numerosArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
        private readonly int[] _quantidade_numerosArray = { 4, 2, 4, 4, 6, 5, 4, 4, 4, 4, 3, 4, 4, 5, 7, 6,
            9, 9, 7, 8, 5, 6, 8, 9, 8, 7, 7, 7, 3, 8, 9, 12, 10, 10, 10, 10, 10, 3 };

        [TestMethod]
        public void ObterInstanciaDosNumeros()
        {
            int index = 0;
            IOrderedEnumerable<Numero> numeros = ObterInstancias();
            foreach (var numero in numeros)
            {
                Assert.AreEqual(numero.GetValor, _numerosArray[index]);
                index++;
            }
        }
        private static IOrderedEnumerable<Numero> ObterInstancias()
        {
            return new ContadorLetras(1000).GetInstanciasDosNumeros()
                            .OrderBy(x => x.GetValor);
        }
        [TestMethod]
        public void DeveObterValorDoNumeroUm()
        {
            Numero um = new Um();
            Assert.AreEqual(1, um.GetValor, "Valor diferente de um");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroDois()
        {
            Numero dois = new Dois();
            Assert.AreEqual(2, dois.GetValor, "Valor diferente de dois");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroTres()
        {
            Numero tres = new Tres();
            Assert.AreEqual(3, tres.GetValor, "Valor diferente de três");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroQuatro()
        {
            Numero quatro = new Quatro();
            Assert.AreEqual(4, quatro.GetValor, "Valor diferente de quatro");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroCinco()
        {
            Numero cinco = new Cinco();
            Assert.AreEqual(5, cinco.GetValor, "Valor diferente de cinco");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroSeis()
        {
            Numero seis = new Seis();
            Assert.AreEqual(6, seis.GetValor, "Valor diferente de seis");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroSete()
        {
            Numero sete = new Sete();
            Assert.AreEqual(7, sete.GetValor, "Valor diferente de sete");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroOito()
        {
            Numero oito = new Oito();
            Assert.AreEqual(8, oito.GetValor, "Valor diferente de oito");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroNove()
        {
            Numero nove = new Nove();
            Assert.AreEqual(9, nove.GetValor, "Valor diferente de nove");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroDez()
        {
            Numero dez = new Dez();
            Assert.AreEqual(10, dez.GetValor, "Valor diferente de dez");
        }
        [TestMethod]
        public void DeveObterQuantidadeDeCaracter()
        {
            var index = 0;
            var instanciasDeNumeros = ObterInstancias();
            foreach (var numero in instanciasDeNumeros)
            {
                Assert.AreEqual(_quantidade_numerosArray[index], numero.GetQuantidadeDeCaracteres, $"Valor diferente de {_quantidade_numerosArray[index]}");
                index++;
            }
        }
        [TestMethod]
        public void DeveCompararIgualdadeTrue()
        {
            Numero um = new Um();
            Assert.IsTrue(um.Equal(1));
        }
        [TestMethod]
        public void DeveCompararIgualdadeFalse()
        {
            Numero um = new Um();
            Assert.IsFalse(um.Equal(2));
        }
        [TestMethod]
        public void DeveObterAQuantidadeDeCaracter()
        {
            Numero um = new Um();
            Assert.AreEqual(um.GetQuantidadeDeCaracteres, 2);
        }
        [TestMethod]
        public void DeveObterAQuantidade()
        {
            Numero um = new Um();
            Assert.AreEqual(um.GetQuantidadeDeCaracteres, 2);
        }
        [TestMethod]
        public void DeveIncrementarSoma()
        {
            var contador = new ContadorLetras(100);            
            Assert.AreEqual(contador.Incrementar(10), contador._soma);
        }
    }
}
