using System;
namespace lista01
{  
    class Carro //Vao ter atributos e metodos dentro dela
    {
        //Atributo ou propriedades, como sao publicos podem ser acessados diretamente de fora da classe, por outros obj ou metodos
        public string marca;
        public string modelo;
        public int ano;

        //Metodo, mesma coisa do def no python Fucção
        public string Ligar()
        {
             return "O carro tá ligado";
        }
        public void Mensagem()
        {
              Console.WriteLine($"Marca: {marca}\nModelo: {modelo}\nDo ano: {ano}");
        }

        //Construtor, Tem o mesmo nome da classe e possui os atributos como parametro
        public Carro(string marca, string modelo, int ano)
        {
            this.ano = ano;
            this.marca = marca;
            this.modelo = modelo;
        }
    }
}