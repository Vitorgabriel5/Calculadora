using System.Globalization;
using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual vai ser a operação desejada:");
            Console.WriteLine("1-Adição");
            Console.WriteLine("2-Subitração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divição \n");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual vai ser o primeiro numero desejado");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual vai ser o segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao) {
                case 1: {
                        resultado =Adicao(num1,num2);
                        break;
                    }
                case 2: {
                        resultado = Subitracao(num1, num2);
                        break;
                    }
                case 3: {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }
                case 4: {
                        resultado = Divicao(num1, num2);
                        break;
                    }

                default:
                    Console.WriteLine("Informe outro numero pois o numero e invalido:");
                    break;
            }
            Console.WriteLine("O Resultado da operação {0} é {1} :{2} ",num1,num2, resultado);

        }
        public static int Adicao(int numero1, int numero2) {
            int resultado = numero1 + numero2;
            return resultado;

        }
        public static int Subitracao(int numero1, int numero2) {
            int resultado = numero1 - numero2;
            return resultado;

        }
        public static int Multiplicacao(int numero1, int numero2) {
            int resultado = numero1 * numero2;
            return resultado;

        }
        public static int Divicao(int numero1, int numero2) {
            int resultado = numero1 / numero2;
            return resultado;

        }
    }

    }
