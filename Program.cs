using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse[] G = new Warehouse[3];
            for(int i = 0; i<3; i++)
                G[i] = new Warehouse();
            for (int i = 0; i < 3; i++)
                G[i].Add();
            /*
rum
15
30
03.03.20

paper
0,25
600
01.02.20

rum
16,6
10
05.03.20
             */

           Console.WriteLine("\nSearch product by name");
           string n = Console.ReadLine();
           for (int i = 0; i < 3; i++)
               G[i].Search_Name(G[i], n);


            Console.WriteLine("\nSearch product by price");
            float p = float.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
                G[i].Search_Price(G[i], p);

            Console.WriteLine("\nSearch product by volume");
            float v = float.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
                G[i].Search_Volume(G[i], v);

            Console.WriteLine("\nSorting array by alphabet");
            G[0].Sorting(G);

            for (int i = 0; i < 3; i++)
                G[i].Get_Info(G[i]);

            Console.ReadKey();
        }
    }
}
