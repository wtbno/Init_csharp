using System;



namespace Aula03
{
    class Program
    {
        static void Main(String[] args)
        {

            int[] list = { 1, 2, 3, 4, 5 };
            foreach (int numero in list)
            {
                System.Console.WriteLine(numero);
            }

            //FOR
            // System.Console.WriteLine("Digite um valor: ");
            // valor = int.Parse(Console.ReadLine());
            // //i => indice, i++ => incremento
            // for(int i = valor; i <= 10; i++)
            // {
            //     System.Console.WriteLine(i);
            // }

            // Boolean condicao = true;
            // int valor;


            //WHILE

            // do
            // {
            //     System.Console.WriteLine("Digite um valor ou insira 0 para sair");
            //     valor = int.Parse(Console.ReadLine());

            //     if (valor == 0)
            //     {
            //         System.Console.WriteLine("Você saiu da aplicação");
            //         condicao = false;
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("O valor inserido foi: " + valor);
            //     }
            // } while (condicao == true);
        }
    }
}