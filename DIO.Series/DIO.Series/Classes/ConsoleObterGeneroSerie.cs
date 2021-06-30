// Instituição: 	Digital Innovation One
// Dev: 			Alex Nogueira
// Data: 			Junho/2021
// App console: 	CRUD Console Simples 
// Versão:			1.0.2
// Código:			Programa principal que interage com usuário através da console - Trata genero

using System;

namespace DIO.Series
{
    internal class ConsoleObterGeneroSerie
    {

        public int consoleObterGeneroSerie()
        {

            Console.Write("Digite o gênero desejado: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            while (!Enum.IsDefined(typeof(Genero), entradaGenero))
            {
                Console.Write("Digite o gênero desejado que exista na lista: ");
                entradaGenero = int.Parse(Console.ReadLine());
            }

            return entradaGenero;

        }

        public static implicit operator int(ConsoleObterGeneroSerie v)
        {
            Console.Write("Digite o gênero desejado: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            while (!Enum.IsDefined(typeof(Genero), entradaGenero))
            {
                Console.Write("Digite o gênero desejado que exista na lista: ");
                entradaGenero = int.Parse(Console.ReadLine());
            }

            return entradaGenero;
        }
    }
}