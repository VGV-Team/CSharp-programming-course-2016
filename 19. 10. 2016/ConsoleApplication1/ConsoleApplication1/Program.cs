using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool b = Convert.ToBoolean(Console.ReadLine());

            char[,] tabela = napolniMatrikoOptimalno(b);
            izpisiMatriko(tabela);

            Console.WriteLine();

            tabela = napolniMatriko(!b);
            izpisiMatriko(tabela);


            izpisiMatriko(napolniMatriko(b));

            Console.ReadKey();
        }

        private static char[,] napolniMatriko(bool b)
        {
            char[,] mojaTabela = new char[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (b)
                    {
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 0)
                            {
                                mojaTabela[i, j] = '*';
                            }
                            else
                            {
                                mojaTabela[i, j] = '_';
                            }
                        }
                        else
                        {
                            if (j % 2 == 0)
                            {
                                mojaTabela[i, j] = '_';
                            }
                            else
                            {
                                mojaTabela[i, j] = '*';
                            }
                        }
                    }
                    else
                    {
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 0)
                            {
                                mojaTabela[i, j] = '_';
                            }
                            else
                            {
                                mojaTabela[i, j] = '*';
                            }
                        }
                        else
                        {
                            if (j % 2 == 0)
                            {
                                mojaTabela[i, j] = '*';
                            }
                            else
                            {
                                mojaTabela[i, j] = '_';
                            }
                        }
                    }
                }
            }
            return mojaTabela;
        }

        private static char[,] napolniMatrikoOptimalno(bool b)
        {
            char[,] mojaTabela = new char[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 == 1 && j % 2 == 1))
                    {
                        if(b)
                            mojaTabela[i, j] = '*';
                        else
                            mojaTabela[i, j] = '_';
                    }
                    else
                    {
                        if (b)
                            mojaTabela[i, j] = '_';
                        else
                            mojaTabela[i, j] = '*';
                    }

                }
            }
            return mojaTabela;
        }

        private static void izpisiMatriko(char[,] mojaTabela)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(mojaTabela[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

    

}
