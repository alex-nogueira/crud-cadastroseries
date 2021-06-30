// Instituição: 	Digital Innovation One
// Dev: 			Alex Nogueira
// Data: 			Junho/2021
// App console: 	CRUD Console Simples 
// Versão:			1.0.2
// Código:			Classe abstrata "EntidadeBase" para ser herdada em outras classes protegendo a chave dos objetos

namespace DIO.Series
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }

    }
}