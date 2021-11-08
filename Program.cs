using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._02._2021_dvumeren_masiv
{
    class DvumerenMasiv
    {
        private int[,] symvoli;
        public DvumerenMasiv(int x, int y )
        {
            symvoli = new int[x, y];
            for (int i = 0; i < symvoli.GetLength(0); i++)
            {
                for (int j = 0; j < symvoli.GetLength(1); j++)
                {
                    symvoli[i, j] = 0;
                }
            }
        }
        public void Show()
        {
            Console.WriteLine("Dvumeren masiv: ");
            for (int i = 0; i < symvoli.GetLength(0); i++)
            {
                for (int j = 0; j < symvoli.GetLength(1); j++)
                {
                    Console.Write(symvoli[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public int this[int a, int b ]
        {
            get
            {
                return symvoli[a, b];
            }
            set
            {
                symvoli[a, b] = value;
            }
        }
        public void Change(int i, int j, int num)
        {
            symvoli[i, j] = num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DvumerenMasiv class1 = new DvumerenMasiv(6, 7);
            class1.Show();
            class1.Change(3, 5, 10);
            class1.Change(1, 2, 3);
            class1.Change(2, 4, 30);
            class1.Change(0, 0, 2);
            class1.Show();
            Console.ReadKey(true);
        }
    }
}
