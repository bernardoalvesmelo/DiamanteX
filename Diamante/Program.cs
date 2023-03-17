namespace Diamante
{
    internal class Program
    {
            public static void Main()
            {
                int tamanhoDiamante = lerNumeroImpar();
                for (int i = 1; i < tamanhoDiamante; i += 2)
                {
                    Console.WriteLine(EscreverLinha(i, tamanhoDiamante));
                }

                for (int i = tamanhoDiamante; i >= 1; i -= 2)
                {
                    Console.WriteLine(EscreverLinha(i, tamanhoDiamante));
                }

                Console.ReadLine();
            }

            public static string EscreverLinha(int i, int tamanhoDiamante)
            {
                string escrita = "";
                int espaco = (tamanhoDiamante - i) / 2;
                escrita += new string(' ', espaco);
                escrita += new string('x', i);
                return escrita;
            }

            public static int lerNumeroImpar()
            {
                while (true)
                {
                    Console.WriteLine("Digite um número ímpar para o diamante: ");
                    int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());
                    if (tamanhoDiamante % 2 == 0)
                    {
                        Console.WriteLine("Não digite um número par!");
                    }
                    else
                    {
                        return tamanhoDiamante;
                    }
                }
            }
        }
    }