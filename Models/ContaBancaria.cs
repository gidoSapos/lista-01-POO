using System;
namespace lista01
{
    class ContaBancaria
    {
        public float saldo;
        public void Depositar()
        {
            saldo += 100;
            Console.WriteLine(saldo); 
        }
        public void Sacar()
        {
            if (saldo > 0)
            {
                Console.WriteLine("Ja pode saca");
            }
        }
        public ContaBancaria(float saldo)
        {
            this.saldo = saldo;
        }
    }
}



//if True: print(`Hello World`)