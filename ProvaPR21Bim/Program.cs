using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPR21Bim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("    menu");
            Console.WriteLine("Exercicio 1");
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("Exercicio 3");
            Console.WriteLine("Exercicio 4");
            Console.WriteLine("Exercicio 5");
            Console.WriteLine("Exercicio 6");
            Console.WriteLine("Exercicio 7");
            int exec = int.Parse(Console.ReadLine());

            switch (exec)
            {
                case 1:

                    int num;
                    Console.WriteLine("Digite um valor inteiro:");
                    num = int.Parse(Console.ReadLine());

                    if (num <= 0)
                    {
                        num = -num;
                    }
                    Console.WriteLine("o valor absoluto do número é" + num);


                case 2:

                    int num1;

                    Console.WriteLine("digite um valor:");
                    num1 = int.Parse(Console.ReadLine());

                    num1 % 3


                    if
                        ((num1 & 1) != 0)
                        Console.WriteLine("ele é divisível por algum desses números");

                    else
                        (num1 > 0) Console.WriteLine("ele não é divisível");



                case 3:

                    int num2, num3, num4;

                    Console.WriteLine("digite um valor:");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite outro valor:");
                    num3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite outro valor:");
                    num4 = int.Parse(Console.ReadLine());

                    if
                        ((num2 > num3) & ((num2 > num4))


                        Console.WriteLine("o maior número é:" + num2);
                    else (num3 > num2) & ((num3 > num4))

                            Console.WriteLine("o maior número é:" + num3); 
                    else ((num4 > num2) & ((num4 > num3))

                       Console.WriteLine("o maior número é:" + num4)




                        case 4:

                    Console.WriteLine("digite um número de 1 a 7 (eles equivalem a cada dia da semana)");
                    string dia = Console.ReadLine().ToUpper();

                    string DOMINGO, SEGUNDA, TERÇA, QUARTA, QUINTA, SEXTA, SÁBADO;

                    switch (1, 2, 3, 4, 5, 6, 7)
                    {
                        case "1":
                            DOMINGO = "gosto de assistir séries e filmes:";
                            break;
                        case "2":
                            SEGUNDA = "tenho aulas de filosofia, português e matemática";
                            break;
                        case "3":
                            TERÇA = "tenho aulas de química, história e inglês para o mundo da informática (IMI)";
                            break;
                        case "4":
                            QUARTA = "tenho aulas biologia, português e programação";
                            break;
                        case "5":
                            QUINTA = "tenho aulas de física, redes de computadores e sociologia";
                            break;
                        case "6":
                            SEXTA = "tenho aulas de geografia, matemática e banco de dados";
                            break;
                        case "7":
                            SÁBADO = "gosto de jogar futebol";



                        case 5:
                            int nume1, nume2, nume3, nume4;


                            Console.WriteLine("digite um valor:");
                            nume = int.Parse(Console.ReadLine());

                            if (nume1 <= 0)
                                break;

                            else

                                Console.WriteLine("digite um valor:");
                            nume2 = int.Parse(Console.ReadLine());

                            break;

                            if (nume2 <= 0)
                            Console.WriteLine("digite um valor:");
                            nume = int.Parse(Console.ReadLine());
                            Console.WriteLine("digite um valor:");
                            nume = int.Parse(Console.ReadLine());
                            Console.WriteLine("digite um valor:");
                            nume = int.Parse(Console.ReadLine());


                        case 6:

                            int nu1, nu2 = 0;

                            Console.WriteLine("digite um número inteiro:");
                            nu1 = int.Parse(Console.ReadLine());

                            for (int i = 1; i < nu1; i++)
                            {
                                if (nu1 % i == 0)
                                {
                                     nu2 += i;
                                }
                            }
                            if (nu2 == nu1)
                            {
                                Console.WriteLine("este é um número perfeito");
                            }
                            else
                                Console.WriteLine("este não é um número perfeito");


                        case 7:

                            int numm;

                            Console.WriteLine("digite um valor");


                            //não consegui resolver a maioria =(












                    }
            }
        }
    }
}
