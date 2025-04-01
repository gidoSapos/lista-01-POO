using System;
namespace Models 
{
    class Livro
    {
        //Atributos
        public string titulo;
        public string autor;
        public int ano;

        //Metodo
        public void ExibirMensagem()
        {
            Console.WriteLine($"Titulo: {titulo}/nAutor: {autor}/nAno: {ano}");
        }

        public Livro(string titulo, string autor, int ano)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.ano = ano;
        }
    }
}