using System;

class program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int valor1;
        int valor2;
        System.Console.WriteLine("Digite o primeiro valor: ");
        //Conversão de string para int
        valor1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite o segundo valor: ");
        valor2 = int.Parse(Console.ReadLine());

        int soma = valor1 + valor2;
        System.Console.WriteLine("A soma dos valores foram: " + soma);
    }

}
