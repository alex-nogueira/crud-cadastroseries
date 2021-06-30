// Instituição: 	Digital Innovation One
// Dev: 			Alex Nogueira
// Data: 			Junho/2021
// App console: 	CRUD Console Simples 
// Versão:			1.0.2
// Código:			Programa principal que interage com usuário através da console - Trata ano

using System;

namespace DIO.Series
{
    internal class ConsoleObterAnoSerie
    {
        public int consoleObterAnoSerie()
        {

            Console.Write("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            return entradaAno;

        }

        public static implicit operator int(ConsoleObterAnoSerie v)
        {

            Console.Write("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            return entradaAno;
            
        }
    }
}