using _4_menu_opcoes;
using System;
using System.Collections.Generic;
using Tela;

namespace GFT_START_WOMEN_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Criar();

            var listaOpcoes = new List<Opcoes>();
            listaOpcoes.Add(new Opcoes("Média aritmética", "1"));
            listaOpcoes.Add(new Opcoes("Média ponderada", "2"));
            listaOpcoes.Add(new Opcoes("Sair", "3"));

            var executar = new Executar(listaOpcoes);
            executar.MostrarMenu();

            Console.ReadLine();
        }
    }
}
