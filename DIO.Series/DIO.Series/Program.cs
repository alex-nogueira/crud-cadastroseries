// Instituição: 	Digital Innovation One
// Dev: 			Alex Nogueira
// Data: 			Junho/2021
// App console: 	CRUD Console Simples 
// Versão:			1.0.2


using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        // ------------------------------------------------------------ Interage com usuário e trata a opção desejada
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
				
			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarSeries();
						break;

					case "2":
						InserirSerie();
						break;

					case "3":
						AtualizarSerie();
						break;

					case "4":
						ExcluirSerie();
						break;

					case "5":
						VisualizarSerie();
						break;

					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}
			
			Console.WriteLine("Obrigado por utilizar nossos serviços !");
			//adicionei linha abaixo
			
			Console.ReadLine();
        }

        // ------------------------------------------------------------ Interage com usuário e exclui a série
        private static void ExcluirSerie()
		{

            Console.WriteLine("Você escolheu: Excluir série");

            // -------------------------------------------------------- Verificar se o ID existe
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            while (indiceSerie > repositorio.ProximoId())
            {
                Console.WriteLine($"Digite o id da série corretamente. Limite máximo: {repositorio.ProximoId()}");
                indiceSerie = int.Parse(Console.ReadLine());
            }

            // -------------------------------------------------------- Confirmar com usuário a exclusão

            Console.WriteLine("Digite SIM para confirmar a exclusão");
            string entradaConfirmação = Console.ReadLine();

			if (entradaConfirmação.ToUpper() == "SIM")
			{
                repositorio.Exclui(indiceSerie);
			}

		}

        // ------------------------------------------------------------ Interage com usuário e visualiza a série
        private static void VisualizarSerie()
		{
            Console.WriteLine("Você escolheu: Visualizar série");

            // -------------------------------------------------------- Verificar se o ID existe
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            while (indiceSerie > repositorio.ProximoId())
            {
                Console.Write($"Digite o id da série corretamente. Limite máximo: {repositorio.ProximoId()}");
                indiceSerie = int.Parse(Console.ReadLine());
            }

			var serie = repositorio.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
		}

        // ------------------------------------------------------------ Interage com usuário e atualiza a série
        private static void AtualizarSerie()
		{

            Console.WriteLine("Você escolheu: Atualizar série");

            // -------------------------------------------------------- Verificar se o ID existe
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            while (indiceSerie > repositorio.ProximoId())
            {
                Console.Write($"Digite o id da série corretamente. Limite máximo: {repositorio.ProximoId()}");
        		indiceSerie = int.Parse(Console.ReadLine());
			}

            // -------------------------------------------------------- Listar generos das séries no console
            new ConsoleListarGeneroSerie();

            // -------------------------------------------------------- Interage com usuário e obtém os dados
            int entradaGenero = new ConsoleObterGeneroSerie();
            string entradaTitulo = new ConsoleObterTituloSerie();
            int entradaAno = new ConsoleObterAnoSerie();
            string entradaDescricao = new ConsoleObterDescSerie();

            // -------------------------------------------------------- Atualizar a série
            Serie atualizaSerie = new Serie(id: indiceSerie,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}

        // ------------------------------------------------------------ Interage com usuário e Lista as séries
        private static void ListarSeries()
		{

            Console.WriteLine("Você escolheu: Listar todas as séries");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? " =Excluído com Sucesso!=" : ""));
			}
		}

        // ------------------------------------------------------------ Interage com usuário e insere a série
        private static void InserirSerie()
		{

            Console.WriteLine("Você escolheu: Inserir série");

            // -------------------------------------------------------- Listar generos das séries no console
            new ConsoleListarGeneroSerie();

            // -------------------------------------------------------- Interage com usuário e obtém os dados
            int entradaGenero = new ConsoleObterGeneroSerie();
			string entradaTitulo = new ConsoleObterTituloSerie();
            int entradaAno = new ConsoleObterAnoSerie();
			string entradaDescricao = new ConsoleObterDescSerie();

            // -------------------------------------------------------- Inserir a série
            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novaSerie);
		}

		// ------------------------------------------------------------ Interage com usuário: obtém a opção desejada
        private static string ObterOpcaoUsuario()
		{
            Console.WriteLine();
			//---------------------------------------------------------- Cor 
					Console.BackgroundColor = ConsoleColor.Blue;
					Console.ForegroundColor = ConsoleColor.White;
					Console.Clear();

            Console.WriteLine(" ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
			Console.WriteLine("                               WOWFLIX                             ");
            Console.WriteLine(" ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.WriteLine();
						
					//Console.BackgroundColor = ConsoleColor.DarkGray;
					Console.ForegroundColor = ConsoleColor.DarkBlue;
				


			Console.WriteLine(" 1 - Listar séries");
			Console.WriteLine(" 2 - Inserir série");
			Console.WriteLine(" 3 - Atualizar série");
			Console.WriteLine(" 4 - Excluir série");
			Console.WriteLine(" 5 - Visualizar série");
			Console.WriteLine(" C - Limpar Tela");
			Console.WriteLine(" X - Sair");

			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(">>----> Informe o item desejado:");

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();

			return opcaoUsuario;
		}
    }
}
