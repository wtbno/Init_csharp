using System;

namespace Aula4
{
    class Program
    {
        static void Main(String[] args)
        {

            Boolean condicao = true;
            int valor;
            do
            {
                System.Console.WriteLine("Digite um valor ou insira 0 para sair");
                valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    System.Console.WriteLine("Você saiu da aplicação");
                    break;
                }
                else
                {
                    System.Console.WriteLine("O valor inserido foi: " + valor);
                    continue;
                }
            } while (condicao == true);
        }
    }
}