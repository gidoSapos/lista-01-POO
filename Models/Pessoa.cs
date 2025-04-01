using System;
namespace lista01
{
    class Pessoa
    {
        //Atributos
        public string Nome;
        public int Idade;

        //Metodos (ações da classe)
        public string Mensagem()
        {
            return $"Olá {Nome}, você tem mais ou menos {Idade - 100} anos, em tempo de vida.";
        }
        public int IdadeEmAnos()
        {
            return Idade * 12;
        }

        //Construtor, se eu n'ao me engano, usando a atv de relacionamento como base, e possivel comprimir o construtor
        public Pessoa(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }
    }
}