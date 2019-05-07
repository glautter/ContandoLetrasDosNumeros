using ContandoLetrasDosNumeros.AppConsole;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ContantoLetrasTest
{
    [TestClass]
    public class NumeroTest
    {
        private readonly IDictionary _numeroEQuantidadeCaracter = new Dictionary<int, int> {
            {0, 4}, {1, 2}, {2, 4}, {3, 4}, {4, 6}, {5, 5}, {6, 4}, {7, 4}, {8, 4}, {9, 4}, {10, 3}, {11, 4}, {12, 4}, {13, 5}, {14, 7},
            {15, 6}, {16, 9}, {17, 9}, {18, 7}, {19, 8}, {20, 5}, {30, 6}, {40, 8}, {50, 9}, {60, 8}, {70, 7}, {80, 7}, {90, 7}, {100, 3},
            {200, 8}, {300, 9}, {400, 12}, {500, 10}, {600, 10}, {700, 10}, {800, 10}, {900, 10}, {1000, 3}
        };

        [TestMethod]
        public void ObterInstanciaDosNumeros()
        {
            int index = 0;
            IOrderedEnumerable<Numero> numeros = ObterInstancias();
            foreach (var numero in numeros)
            {
                Assert.IsTrue(_numeroEQuantidadeCaracter.Contains(numero.GetValor));
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
        public void DeveObterValorDoNumeroOnze()
        {
            Numero onze = new Onze();
            Assert.AreEqual(11, onze.GetValor, "Valor diferente de onze");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroDoze()
        {
            Numero doze = new Doze();
            Assert.AreEqual(12, doze.GetValor, "Valor diferente de doze");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroTreze()
        {
            Numero treze = new Treze();
            Assert.AreEqual(13, treze.GetValor, "Valor diferente de treze");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroCatorze()
        {
            Numero catorze = new Catorze();
            Assert.AreEqual(14, catorze.GetValor, "Valor diferente de catorze");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroQuinze()
        {
            Numero quinze = new Quinze();
            Assert.AreEqual(15, quinze.GetValor, "Valor diferente de quinze");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroDezesseis()
        {
            Numero dezesseis = new Dezesseis();
            Assert.AreEqual(16, dezesseis.GetValor, "Valor diferente de dezesseis");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroDezessete()
        {
            Numero dezessete = new Dezessete();
            Assert.AreEqual(17, dezessete.GetValor, "Valor diferente de dezessete");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroDezoito()
        {
            Numero dezoito = new Dezoito();
            Assert.AreEqual(18, dezoito.GetValor, "Valor diferente de dezoito");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroDezenove()
        {
            Numero dezenove = new Dezenove();
            Assert.AreEqual(19, dezenove.GetValor, "Valor diferente de dezenove");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroVinte()
        {
            Numero vinte = new Vinte();
            Assert.AreEqual(20, vinte.GetValor, "Valor diferente de vinte");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroTrinta()
        {
            Numero trinta = new Trinta();
            Assert.AreEqual(30, trinta.GetValor, "Valor diferente de trinta");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroQuarenta()
        {
            Numero quarenta = new Quarenta();
            Assert.AreEqual(40, quarenta.GetValor, "Valor diferente de quarenta");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroCinquenta()
        {
            Numero cinquenta = new Cinquenta();
            Assert.AreEqual(50, cinquenta.GetValor, "Valor diferente de cinquenta");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroSessenta()
        {
            Numero sessenta = new Sessenta();
            Assert.AreEqual(60, sessenta.GetValor, "Valor diferente de sessenta");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroSetenta()
        {
            Numero setenta = new Setenta();
            Assert.AreEqual(70, setenta.GetValor, "Valor diferente de setenta");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroOitenta()
        {
            Numero oitenta = new Oitenta();
            Assert.AreEqual(80, oitenta.GetValor, "Valor diferente de oitenta");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroNoventa()
        {
            Numero noventa = new Noventa();
            Assert.AreEqual(90, noventa.GetValor, "Valor diferente de noventa");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroCem()
        {
            Numero cem = new Cem();
            Assert.AreEqual(100, cem.GetValor, "Valor diferente de cem");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroDuzentos()
        {
            Numero duzentos = new Duzentos();
            Assert.AreEqual(200, duzentos.GetValor, "Valor diferente de duzentos");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroTrezentos()
        {
            Numero trezentos = new Trezentos();
            Assert.AreEqual(300, trezentos.GetValor, "Valor diferente de trezentos");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroQuatrocentos()
        {
            Numero quatrocentos = new Quatrocentos();
            Assert.AreEqual(400, quatrocentos.GetValor, "Valor diferente de quatrocentos");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroQuinhentos()
        {
            Numero quinhentos = new Quinhentos();
            Assert.AreEqual(500, quinhentos.GetValor, "Valor diferente de quinhentos");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroSeiscentos()
        {
            Numero seiscentos = new Seiscentos();
            Assert.AreEqual(600, seiscentos.GetValor, "Valor diferente de seiscentos");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroSetecentos()
        {
            Numero setecentos = new Setecentos();
            Assert.AreEqual(700, setecentos.GetValor, "Valor diferente de setecentos");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroOitocentos()
        {
            Numero oitocentos = new Oitocentos();
            Assert.AreEqual(800, oitocentos.GetValor, "Valor diferente de oitocentos");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroNovecentos()
        {
            Numero novecentos = new Novecentos();
            Assert.AreEqual(900, novecentos.GetValor, "Valor diferente de novecentos");
        }
        [TestMethod]
        public void DeveObterValorDoNumeroMil()
        {
            Numero mil = new Mil();
            Assert.AreEqual(1000, mil.GetValor, "Valor diferente de mil");
        }

        [TestMethod]
        public void DeveObterQuantidadeDeCaracter()
        {
            var index = 0;
            var instanciasDeNumeros = ObterInstancias();
            foreach (var numero in instanciasDeNumeros)
            {
                Assert.AreEqual(_numeroEQuantidadeCaracter[numero.GetValor], numero.GetQuantidadeDeCaracteres, $"Valor diferente de {_numeroEQuantidadeCaracter[numero.GetValor]}");
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
        public void DeveIncrementarSoma()
        {
            var contador = new ContadorLetras(100);
            Assert.AreEqual(contador.Incrementar(10), contador._soma);
        }
    }
}
