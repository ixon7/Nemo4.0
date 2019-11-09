using System;

namespace Nemo4._0
{

    class Program
    {
        static int[] Kopiuj(int[] tablica)
        {
            int[] x = new int[tablica.Length];
            for (int i = 0; i < tablica.Length; i++)
            {
                x[i] = tablica[i];
            }
            return x; 
        }
        static void Main(string[] args)
        {
            int[][] g = new int[5][];
            for (int i = 0; i < g.Length; i++)
            {
                g[i] = new int[i + 1];
                for (int j = 0; j < g[i].Length; j++)
                {
                    g[i][j] = i + j;
                }
            }
            int[] r = { 1, 2, 3,4,5,6,7,8 };
            int[] e= Kopiuj(r);
            for (int i = 0; i < e.Length; i++)
            {
                Console.WriteLine(e[i]);
            }


            //int u = 10;
            //int o = u;
            //Console.WriteLine(u);
            //Console.WriteLine(o);
            //int[] z = { 0 };
            //int[] a = z;
            //z[0] = 7;
            //Console.WriteLine("Hello World!");

            //int[] x = { 1, 2, 3, 4, 5 };
            //int[] y = new int[x.Length];
            //for (int i = 0; i < x.Length; i++)
            //{
            //    y[i] = x[i];
            //}
            //x[2] = 100;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(x[i] + " ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(y[i] + " ");
            //}

            //int[,] f =
            //    {
            //    {1,2,3,4,5},
            //    {1,2,3,4,5},
            //    {1,2,3,4,5},
            //    {1,2,3,4,5}
            //};

            //for (int i = 0; i < f.GetLength(0); i++)
            //{
            //    for (int j = 0; j < f.GetLength(1); j++)
            //    {
            //        Console.Write(f[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //int[][] g = new int[5][];
            //for (int i = 0; i < g.Length; i++)
            //{
            //    g[i] = new int[i+1];
            //}

            //for (int i = 0; i < g.GetLength(0); i++)
            //{
            //    for (int j = 0; j < g[i].Length; j++)
            //    {
            //        Console.WriteLine(g[j][1]);
            //    }
            //    Console.WriteLine();
            //}
            //int[][] g = new int[5][];
            //for (int i = 0; i < g.Length; i++)
            //{
            //    g[i] = new int[i + 1];
            //    for (int j = 0; j < g[i].Length; j++)
            //    {
            //        g[i][j] = i + j;
            //    }
            //}
            //for (int i = 0; i < g.Length; i++)
            //{
            //    for (int j = 0; j < g[i].Length; j++)
            //    {
            //        Console.WriteLine(g[i][j] + ", ");
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}
