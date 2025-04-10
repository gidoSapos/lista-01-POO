using System;
namespace lista01;
class Program{
    static void Main(String[] args)
    {
        //Antes eu fiz essa parte sem o construtor e em cada linha ficou a marca, modelo e etc, o contrutor comprime no parametro do Carro
        Carro carro1 = new Carro("Monster truck", "O mais poderoso e alto", 2005);
        Carro carro2 = new Carro("Kbolinha de sapo", "Ford eu acho", 2000); //pesquisei e e um ford ka verde com adesivo de sapo

        carro1.Mensagem();
        carro2.Mensagem();

        ContaBancaria conta1 = new ContaBancaria(324);
        conta1.Depositar();
    }
}
