using System;

namespace Projeto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = false;
            while(!menu)
            {
                menu = MenuPrincipal();
            }
        }

        public static bool MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("+-----------------------------------------------------+");
            Console.WriteLine("|                                                     |");
            Console.WriteLine("|                   Projeto Final                     |");
            Console.WriteLine("|                                                     |");
            Console.WriteLine("+-----------------------------------------------------+");

            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine();

            Console.WriteLine("1) - Operações Básicas");
            Console.WriteLine("2) - Exponenciação e radiciação");
            Console.WriteLine("3) - Sobre o Programa");
            Console.WriteLine("4) - Sair do Programa");

            Console.WriteLine();

            Console.Write("Digite o número da opção para selecioná-la: ");

            switch(Console.ReadLine())
            {
                case "1":
                    OperacoesBasicas();
                    return false;
                case "2":
                    ExponenciaçãoRadiacao();
                    return false;
                case "3":
                    Sobre();
                    return false;
                case "4":
                    return true;
                default:
                    return true;
            }
        }

        public static void OperacoesBasicas()
        {
            while(true)
            {

                Console.Clear();
                Console.WriteLine("+-----------------------------------------------------+");
                Console.WriteLine("|                                                     |");
                Console.WriteLine("|                 Operações Básicas                   |");
                Console.WriteLine("|                                                     |");
                Console.WriteLine("+-----------------------------------------------------+");

                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine();

                Console.WriteLine("1) - Adição");
                Console.WriteLine("2) - Subtração");
                Console.WriteLine("3) - Multiplicação");
                Console.WriteLine("4) - Divisão");
                Console.WriteLine("5) - Volta ao menu");

                Console.WriteLine();

                Console.Write("Digite o número da opção para selecioná-la: ");

                switch(Console.ReadLine())
                {
                    case "1":
                        Adicao();
                        break;
                    case "2":
                        Subtracao();
                        break;
                    case "3":
                        Multiplicacao();
                        break;
                    case "4":
                        Divisao();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida, porfavor tente novamente");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void Adicao()
        {
            string escolha = "";

            while(escolha != "N")
            {
                Console.Clear();

                double num1 = 0, num2 = 0;

                Console.Write("Digite o primeiro número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nDigite o segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = num1 + num2;

                Console.WriteLine($"{num1} mais {num2} é igual à {resultado}");

                Console.Write("\nDeseja continuar nessa operação? (S/N): ");
                escolha = Console.ReadLine()
                .ToUpper();
            }
        }

        public static void Subtracao()
        {
            string escolha = "";

            while(escolha != "N")
            {
                Console.Clear();

                double num1 = 0, num2 = 0;

                Console.Write("Digite o primeiro número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nDigite o segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = num1 - num2;

                Console.WriteLine($"{num1} menos {num2} é igual à {resultado}");

                Console.Write("\nDeseja continuar nessa operação? (S/N): ");
                escolha = Console.ReadLine()
                .ToUpper();
            }
        }

        public static void Multiplicacao()
        {
            string escolha = "";

            while(escolha != "N")
            {
                Console.Clear();

                double num1 = 0, num2 = 0;

                Console.Write("Digite o primeiro número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nDigite o segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = num1 * num2;

                Console.WriteLine($"{num1} vezes {num2} é igual à {resultado}");

                Console.Write("\nDeseja continuar nessa operação? (S/N): ");
                escolha = Console.ReadLine()
                .ToUpper();
            }
        }

        public static void Divisao()
        {
            string escolha = "";

            while(escolha != "N")
            {
                Console.Clear();

                double num1 = 0, num2 = 0;

                Console.Write("Digite o primeiro número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nDigite o segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = num1 / num2;

                Console.WriteLine($"{num1} divido {num2} é igual à {resultado}");

                Console.Write("\nDeseja continuar nessa operação? (S/N): ");
                escolha = Console.ReadLine()
                .ToUpper();
            }
        }

        public static void ExponenciaçãoRadiacao()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("+-----------------------------------------------------+");
                Console.WriteLine("|                                                     |");
                Console.WriteLine("|              Exponenciação e radiciação             |");
                Console.WriteLine("|                                                     |");
                Console.WriteLine("+-----------------------------------------------------+");

                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine();

                Console.WriteLine("1) - Exponenciação");
                Console.WriteLine("2) - Radiciação");
                Console.WriteLine("3) - Voltar ao menu");
                
                Console.WriteLine();

                Console.Write("Digite o número da opção para selecioná-la: ");

                switch(Console.ReadLine())
                {
                    case "1":
                        Exponenciacao();
                        break;
                    case "2":
                        Radiacao();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opção inválida, porfavor tente novamente");
                        Console.ReadKey();
                        break;
                }
            }
            
        }

        public static void Exponenciacao()
        {
           string escolha = "";

            while(escolha != "N")
            {
                Console.Clear();

                double num1 = 0, num2 = 0;

                Console.Write("Digite o valor: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nDigite o expoente: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = Math.Pow(num1 , num2);

                Console.WriteLine($"{num1} elevado à {num2} é igual à {resultado}");

                Console.Write("\nDeseja continuar nessa operação? (S/N): ");
                escolha = Console.ReadLine()
                .ToUpper();
            }
        }

        public static void Radiacao()
        {
            string escolha = "";

            while(escolha != "N")
            {
                Console.Clear();

                double num1 = 0, num2 = 0;

                Console.Write("Digite o radical: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nDigite o indice: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = Math.Pow(num1, 1 / num2);

                Console.WriteLine($" A raíz de {num1} com indice {num2} é igual à {resultado:N2}");

                Console.Write("\nDeseja continuar nessa operação? (S/N): ");
                escolha = Console.ReadLine()
                .ToUpper();
            }
        }

        public static void Sobre()
        {
            string escolha = "";

            while(escolha != "N")
            {
                Console.Clear();
                Console.WriteLine("+-----------------------------------------------------+");
                Console.WriteLine("|                                                     |");
                Console.WriteLine("|                         Sobre                       |");
                Console.WriteLine("|                                                     |");
                Console.WriteLine("+-----------------------------------------------------+");
            
                Console.WriteLine("Projeto Final em C#(.NET) da escola ETEC Adolhpo Berezin");
                Console.WriteLine("Desenvolvido por Ulisses Macedo Silva");
                Console.WriteLine("Link do Repositório: https://github.com/UlissesSilva08/Projeto_Final");

                Console.Write("\nDeseja continuar nessa tela?(S/N): ");
                escolha = Console.ReadLine()
                .ToUpper();
            }
        }
    }
}
