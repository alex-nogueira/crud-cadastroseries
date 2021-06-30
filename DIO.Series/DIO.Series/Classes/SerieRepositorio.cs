// Instituição: 	Digital Innovation One
// Dev: 			Alex Nogueira
// Data: 			Junho/2021
// App console: 	CRUD Console Simples 
// Versão:			1.0.2
// Código:			Classe "SerieRepositorio" herda Interface "IRepositorio" para realizar CRUD

using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
        // -------------------------------------- Cria instância Série
        private List<Serie> listaSerie = new List<Serie>();

        // -------------------------------------- Atualiza a série com os dados informados pelo usuário
        public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

        // -------------------------------------- Atualiza a série com marcação de registro exlcuído
        public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

        // -------------------------------------- Inclui a série informada pelo usuário
        public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

        // -------------------------------------- Obtém a lista de séries
        public List<Serie> Lista()
		{
			return listaSerie;
		}

        // -------------------------------------- Obtém o número de séries existentes para determinar o próximo ID de série
        public int ProximoId()
		{
			return listaSerie.Count;
		}

        // -------------------------------------- Retorna a série escolhida pelo usuário
        public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}
	}
}