using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10; #1
            //int b = 10;
            //if (a > b)
            //{
            //    Console.WriteLine("Siema stary ");

            //}else
            //{
            //    Console.WriteLine(" macierzy");
            //}
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();
            //2-----------------
            //int a = 200;
            //int b = 300;
            //string aa = "";

            //string tekst = (a>b) ? "a jest wieksze od b " : "b jest wieksze od a";
            //Console.WriteLine(tekst);
            //Console.ReadKey();

            //3-----------------
            //for (int i = 0; i<10; i++)
            //{
            //    int j = 5 * i;
            //    Console.WriteLine(i*j);
            //}

            // Console.WriteLine("podaj a");
            //string a = (Console.ReadLine());
            // Console.WriteLine(a);

            // for (int i= 0; i<4; i++)
            //     for(int j = 0; j<2;j++)
            //         Console.WriteLine(j);

            //Tabliczka Mnożenia jupi ojej
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i == 3)

            //        continue;

            //        for (int j = 1; j <= 10; j++)
            //            Console.Write("  " + i * j);
            //    Console.WriteLine();
            //}
            //tabliczka za pomoca jednej petli
            //for (int i = 1, j = 1; i <= 10; i++)
            //{


            //    Console.WriteLine(i * j + "");
            //    if (i == 10)
            //    {
            //        i = 0;
            //        j++;
            //        Console.WriteLine();
            //    }
            //    if (j == 10 + 1)
            //    {
            //        break;
            //    }
            //}
            //Console.ReadLine();

            //int[] tab = new int [0];
            //tab[0] = 100;
            //tab[1] = 300;

            //for(int i= 0; i <tab.Length; i++)
            //{
            //    Console.WriteLine(tab[i]);
            //}
            // foreach 
            //int[] tab = new int[15];
            //for(int i = 0; i<15; i++)
            //{
            //    tab[i] = i + 1;
            //    Console.WriteLine("liczby w tablicy to " + i);
            //}
            //Console.WriteLine(tab[2]);

            //foreach (var item in tab)
            //{
            //    if(item == 12)
            //        Console.WriteLine("hohoh 12");
            //    Console.WriteLine(item);
            //}
            //WielowYmiarówkiiiiiii ! @ ! @ ! @  !
            string[,] tab2D = new string[4, 3];

            for (int i = 0; i < tab2D.GetLength(0); i++)
                for (int j = 0; j < tab2D.GetLength(1); j++)
                {
                    tab2D[i, j] = "tab [" + i + "," + j + "]";

                }
            for (int i = 0; i < tab2D.GetLength(0); i++)
            {
                for (int j = 0; j < tab2D.GetLength(1); j++)
                {
                    Console.WriteLine(tab2D[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[4] { 6, 7, 8, 2 };
            jaggedArray[1] = new int[] { 5, 6 };
            jaggedArray[2]= new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j] + "");

                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }


        }
    }


