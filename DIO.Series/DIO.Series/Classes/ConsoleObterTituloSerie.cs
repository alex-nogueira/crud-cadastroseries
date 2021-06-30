// Instituição: 	Digital Innovation One
// Dev: 			Alex Nogueira
// Data: 			Junho/2021
// App console: 	CRUD Console Simples 
// Versão:			1.0.2
// Código:			Programa principal que interage com usuário através da console - Trata titulo

using System;

namespace DIO.Series
{
    internal class ConsoleObterTituloSerie
    {
        public string consoleObterTituloSerie()
        {

            Console.Write("Digite o título da série: ");  
            string entradaTitulo = Console.ReadLine();
            return entradaTitulo;

        }
        public static implicit operator string(ConsoleObterTituloSerie v)
        {

            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();
            return entradaTitulo;
            
        }
    }
}