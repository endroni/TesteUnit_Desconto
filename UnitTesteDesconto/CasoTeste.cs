using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteUnit;

namespace UnitTesteDesconto
{
    [TestClass]
    public class CasoTeste
    {
        // Casao de Teste#1: ´Valor das Vendas é Maior ou Igual a 1000 : Verificação
        [TestMethod]
        public void MaiorOuIgual_1000()
        {
            Desconto oDesconto = new Desconto();
            Assert.AreEqual(950, oDesconto.calcularDesconto(1000));
        }

        // Caso de Teste #2: Valor das Vendas é Maior ou Igual a 200: Verificação 
        [TestMethod]
        public void MaiorOuIgual_2000()
        {
            Desconto obj = new Desconto();
            Assert.AreEqual(1800, obj.calcularDesconto(2000));
        }

        // Caso de Teste#3: Valor das Vendas é Maior ou igual a 5000 : Verificação
        [TestMethod]
        public void MaiorOuIgual_5000()
        {
            Desconto obj = new Desconto();
            Assert.AreEqual(2500, obj.calcularDesconto(5000));
        }

        // Caso de Teste#4: Valor das Vendas é 0 : Verificação
        [TestMethod]
        public void ValorZero()
        {
            Desconto obj = new Desconto();
            try
            {
                obj.calcularDesconto(0);
            }
            catch (Exception ex) { throw ex; }
        }

        // Caso de Teste#5: Valor das Vendas é menor que 1000 : Verificação
        [TestMethod]
        public void AbaixoDe_1000()
        {
            Desconto obj = new Desconto();
            Assert.AreEqual(999, obj.calcularDesconto(999));
        }

        // Caso de Teste#6: Valor das Vendas não produziu os resultados esperados : Verificação
        [TestMethod]
        public void Mil()
        {
            Desconto obj = new Desconto();
            Assert.AreNotEqual(930, obj.calcularDesconto(1000));
        }

        // Caso de Teste#7: Valor das Vendas não produziu os resultados esperados : Verificação
        [TestMethod]
        public void DoisMil()
        {
            Desconto obj = new Desconto();
            Assert.AreNotEqual(1900, obj.calcularDesconto(2000));
        }
    }
}
