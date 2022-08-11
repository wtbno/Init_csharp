using System;


namespace Aula_2
{
    public class Condicional
    {
        static void Main(String[] args)
        {
            int mes;
            System.Console.WriteLine("Insira um número correspondente a um mês do ano");
            mes = int.Parse(Console.ReadLine());


            switch (mes)
            {
                case 1:
                    System.Console.WriteLine("Mês de Janeiro");
                    break;
                case 2:
                    System.Console.WriteLine("Mês de Fevereiro");
                    break;
                case 3:
                    System.Console.WriteLine("Mês de Março");
                    break;
                case 4:
                    System.Console.WriteLine("Mês de Abril");
                    break;
                case 5:
                    System.Console.WriteLine("Mês de Maio");
                    break;
                case 6:
                    System.Console.WriteLine("Mês de Junho");
                    break;
                case 7:
                    System.Console.WriteLine("Mês de Julho");
                    break;
                case 8:
                    System.Console.WriteLine("Mês de Agosto");
                    break;
                case 9:
                    System.Console.WriteLine("Mês de Setembro");
                    break;
                case 10:
                    System.Console.WriteLine("Mês de Outubro");
                    break;
                case 11:
                    System.Console.WriteLine("Mês de Novembro");
                    break;
                case 12:
                    System.Console.WriteLine("Mês de Dezembro");
                    break;

                default:
                    System.Console.WriteLine("Mês inválido");
                    break;

            }

            // if (mes == 1)
            // {
            //     System.Console.WriteLine("Mês de Janeiro");
            // }
            // else if
            //     (mes == 2)
            // {
            //     System.Console.WriteLine("Mês de Fevereiro");
            // }
            // else if
            // (mes == 3)
            // {
            //     System.Console.WriteLine("Mês de Março");
            // }
            // else if
            // (mes == 4)
            // {
            //     System.Console.WriteLine("Mês de Abril");
            // }
            // else if
            // (mes == 5)
            // {
            //     System.Console.WriteLine("Mês de Maio");
            // }
            // else if
            // (mes == 6)
            // {
            //     System.Console.WriteLine("Mês de Junho");
            // }
            // else if
            // (mes == 7)
            // {
            //     System.Console.WriteLine("Mês de Julho");
            // }
            // else if
            // (mes == 8)
            // {
            //     System.Console.WriteLine("Mês de Agosto");
            // }
            // else if
            // (mes == 9)
            // {
            //     System.Console.WriteLine("Mês de Setembro");
            // }
            // else if
            // (mes == 10)
            // {
            //     System.Console.WriteLine("Mês de Outubro");
            // }
            // else if
            // (mes == 11)
            // {
            //     System.Console.WriteLine("Mês de Novembro");
            // }
            // else
            // {
            //     System.Console.WriteLine("Mês de Dezembro");
            // };
        }
    }
}
