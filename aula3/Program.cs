using System;
using System.Globalization;

namespace aula3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            Console.WriteLine("{0} tem {1} anos e seu saldo eh {2:F2} reais",nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e seu saldo eh {saldo:F2} reais");
            Console.WriteLine(nome+ "tem "+ idade+ " anos e seu saldo eh " + saldo.ToString("F2") + " reais");
        }
    }
}
