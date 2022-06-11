
using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_menu_opcoes
{
    public class Executar
    {
        List<Opcoes> _opcoes;

        public Executar(List<Opcoes> opcoes)
        {
            _opcoes = opcoes;
        }

        public void MostrarMenu()
        {
            Console.WriteLine("Selecione uma das opções:");
            foreach (var opcao in _opcoes)
            {
                Console.WriteLine($"{opcao.Valor}. {opcao.Descricao}");
            }
            var opcaoSelecionada = Console.ReadLine();
            SelecionarOpcao(opcaoSelecionada);
        }

        private void SelecionarOpcao(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    CalcularMediaAritmetica();
                    break;
                case "2":
                    CalcularMediaPonderada();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Selecione uma opção valida: ");
                    MostrarMenu();
                    break;
            }
        }

        private void CalcularMediaPonderada()
        {
            List<Nota> notas = new List<Nota>();

            for (int i = 0; i < 3; i++)
            {
                notas.Add(new NotaParaMediaPonderada(ValidarNota(i), ValidarPeso(i)));
            }

            var listaPesoVezesNota = notas.Select(x => x.Peso * x.Valor).ToList();

            var media = listaPesoVezesNota.Sum() / notas.Select(x => x.Peso).Sum();

            Console.WriteLine($"A média ponderada das notas {string.Join(",", notas.Select(x => x.Valor))} é: {media}");
        }

        private void CalcularMediaAritmetica()
        {
            List<Nota> notas = new List<Nota>();
            double nota = 0;

            for (int i = 0; i <= 1; i++)
            {
                notas.Add(new NotaParaMediaArimetica(ValidarNota(i)));
            }

            var media = notas.Average(x => x.Valor);
            Console.WriteLine($"A média aritmética das notas {string.Join(",", notas.Select(x => x.Valor))} é: {media}");
        }

        private double ValidarNota(int indice)
        {
            double notaValidada = 0;
            Console.WriteLine(@$"Digite a nota {indice + 1}: ");
            while (!double.TryParse(Console.ReadLine(), out notaValidada))
            {
                Console.WriteLine(@$"Digite a nota {indice + 1}: ");
            }

            return notaValidada;
        }

        private int ValidarPeso(int indice)
        {
            int pesoValidado = 0;
            Console.WriteLine($@"Digite o peso da nota {indice + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out pesoValidado))
            {
                Console.WriteLine($@"Digite o peso da nota {indice + 1}: ");
            }

            return pesoValidado;
        }
    }
}