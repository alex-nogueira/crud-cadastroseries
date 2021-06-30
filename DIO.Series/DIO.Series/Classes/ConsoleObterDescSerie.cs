// Instituição: 	Digital Innovation One
// Dev: 			Alex Nogueira
// Data: 			Junho/2021
// App console: 	CRUD Console Simples 
// Versão:			1.0.2
// Código:			Programa principal que interage com usuário através da console - Trata descrição

using System;

namespace DIO.Series
{
    internal class ConsoleObterDescSerie
    {
        public string consoleObterDescSerie()
        {

            Console.Write("Digite um resumo da série: ");
            string entradaDescricao = Console.ReadLine();
            return entradaDescricao;

        }

        public static implicit operator string(ConsoleObterDescSerie v)
        {

            Console.Write("Digite um resumo da série: ");
            string entradaDescricao = Console.ReadLine();
            return entradaDescricao;
            
        }
    }
}