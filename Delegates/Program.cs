using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        private static void Main(string[] args)
        {
            var valorTotal = Faixas("Faixa2", "Felipe Portela", 100);

            Console.WriteLine($"Valor total da bonificação + comissão foi: {valorTotal}");

            Console.ReadKey();

        }

        private static void ExibirMensagem()
        {
            Console.WriteLine("Delegate");
        }

        private static decimal Faixas(string faixa, string nomeFuncionario, decimal comissao)
        {
            var faixas = new Dictionary<string, Func<string, decimal, decimal>>()
            {
                {"Faixa1", EnviarEmailFaixa1},
                {"Faixa2", EnviarEmailFaixa2},
                {"Faixa3", EnviarEmailFaixa3},
                {"Faixa4", EnviarEmailFaixa4},
            };

            return faixas[faixa].Invoke(nomeFuncionario, comissao);
        }

        private static decimal EnviarEmailFaixa1(string nomeFuncionario, decimal comissao)
        {
            decimal bonificacao = 0;
            Console.WriteLine($"Enviado email para {nomeFuncionario} devido a faixa 1");
            return bonificacao + comissao;
        }

        private static decimal EnviarEmailFaixa2(string nomeFuncionario, decimal comissao)
        {
            decimal bonificacao = 20;
            Console.WriteLine($"Enviado email para {nomeFuncionario} devido a faixa 2");
            return bonificacao + comissao;
        }

        private static decimal EnviarEmailFaixa3(string nomeFuncionario, decimal comissao)
        {
            decimal bonificacao = 40;
            Console.WriteLine($"Enviado email para {nomeFuncionario} devido a faixa 3");
            return bonificacao + comissao;
        }

        private static decimal EnviarEmailFaixa4(string nomeFuncionario, decimal comissao)
        {
            decimal bonificacao = 50;
            Console.WriteLine($"Enviado email para {nomeFuncionario} devido a faixa 4");
            return bonificacao + comissao;
        }
    }
}