using System;
using System.ComponentModel;
using System.Threading.Channels;

namespace ILU7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Max(0));

        }
        static int Max(int n) 
        {
            int u = 0;
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            foreach (int i in list) 
            { 
                if(i > u)
                {
                    u = i;
                }
            }
            return u;
        }
    }
}