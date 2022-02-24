using System;

namespace Par_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;            
            Console.WriteLine("Informe o primeiro numero!");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero!");
            n2 = Convert.ToInt32(Console.ReadLine());
            soma = n1 + n2;
            if ((n1 + n2) % 2 == 0)
                Console.WriteLine(" A soma dos numeros e {0}, entao o numero e PAR.", soma);
            else
                Console.WriteLine("A soma dos numeros e {0}, entao o numero e IMPAR.", soma);

        }
    }
}
