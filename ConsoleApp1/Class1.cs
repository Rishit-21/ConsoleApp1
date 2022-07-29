using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Class1
    {
        public void exe1(int n)
        {
            int asci,c=0;
             
            for(int i = 0; i < n; i++)
            {
                asci = 65;
                c = asci + i;
                for (int j=i; j >= 0; j--)
                {
                    Console.Write(" " + Convert.ToChar(asci));
                   
                    asci++;
                }
               
            if (i > 0)
            {
                for(int k=i; k > 0; k--)
                {
                        c--;
                        Console.Write(" " + Convert.ToChar(c));
                }
                    }
                Console.WriteLine();
            }
        }
    }
}