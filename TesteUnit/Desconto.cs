using System;

namespace TesteUnit
{
    public class Desconto
    {
        public double calcularDesconto(double ValorVenda)
        {
            double valorDesconto = 0.0;

            if (ValorVenda == 0 || ValorVenda < 0)
            {
                throw new ArgumentException(" O valor das vendas não pode ser Zero ou Negativo");
            }
            else if (ValorVenda >= 1000 && ValorVenda < 2000)
            {
                // 5% Desconto
                valorDesconto = ValorVenda - (ValorVenda * 0.05);
            }
            else if (ValorVenda >= 2000 && ValorVenda < 5000)
            {
                // 10% Desconto
                valorDesconto = ValorVenda - (ValorVenda * 0.1);
            }
            else if (ValorVenda >= 5000 && ValorVenda < 20000)
            {
                // 50% Desconto 
                valorDesconto = ValorVenda - (ValorVenda * 0.5);
            }
            else
            {
                //Sem desconto 
                valorDesconto = ValorVenda - 0.0;
            }
            return valorDesconto;
        }
    }
}


