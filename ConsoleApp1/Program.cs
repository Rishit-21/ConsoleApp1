using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public String Show(string msg)
        {
            Console.WriteLine("hello  there");
            return msg;
        }
        public void show1(int val)
        {
            val *= val;
            Console.WriteLine("value inside calling: " + val);
        }
        public void show2(ref int val)
        {
            val *= val;
            Console.WriteLine("value inside calling: " + val);
        }

        public void show3(out int val)
        {
            int val1 = 7;
            val = val1;
            val *= val;
            Console.WriteLine("value inside calling: " + val);
        }

        static void Main(string[] args)
        {
            int a = 12;
            int b = 5;
            int total = a + b;
            Console.WriteLine("Total:{0} + {1} = {2}", a, b, total, "\n");
            Console.Write("Enter a number: ");


            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("It is even number");
            }
            else
            {
                Console.WriteLine("It is odd number");
            }
            //Console.ReadLine();



            Console.Write("Enter Marks: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0 || num > 100)
            {
                Console.WriteLine("wrong Number.");
            }
            else if (num > 0 && num < 50)
            {
                Console.WriteLine("FAIL");
            }
            else if (num >= 50 && num < 60)
            {
                Console.WriteLine("D Grade");
            }
            else if (num >= 60 && num < 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (num >= 70 && num < 80)
            {
                Console.WriteLine("B Grade");
            }
            else if (num >= 80 && num < 90)
            {
                Console.WriteLine("A Garde");
            }
            else if (num >= 90 && num <= 100)
            {
                Console.WriteLine("A+ Grade");
            }
            //Console.ReadLine();

            Console.Write("Enter aa number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (num2)
            {
                case 13:
                    Console.WriteLine("It is 13");
                    break;
                case 23:
                    Console.WriteLine("It is 23");
                    break;
                case 33:
                    Console.WriteLine("It is 33");
                    break;
                default:
                    Console.WriteLine("Its nither 13,23,33");
                    break;
            }



            for(int i=1; i <= 12; i++)
            {
                Console.WriteLine(i);
            }
            for(int i = 1; i<5; i++)
            {
                for(int j = 1; j < 5; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }




            int l = 1;
            while (l <= 10)
            {
                Console.WriteLine(l);
                    l++;
            }


            for (int i = 1; i <= 12; i++)
            {
                if (i == 5) break;

                else Console.WriteLine(i);
            }



            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (i == 2 && j == 2) break;

                    else Console.WriteLine(i + " " + j);
                }
            }

            for (int i = 1; i <= 12; i++)
            {
                if (i == 5) continue;

                else Console.WriteLine(i);
            }

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (i == 2 && j == 2) continue;

                    else Console.WriteLine(i + " " + j);
                }
            }


            int val = 50 ,val2;
            Console.WriteLine("before calling value: " +val);
            Program p = new Program();
            Program z = new Program();
            String message = p.Show("Rishit");
            Console.WriteLine(message);
            z.show1(val);
            z.show2(ref val);
            Console.WriteLine("After calling: " + val);
            z.show3(out val2);
            Console.WriteLine("after calling out function: " + val2);

            Console.ReadLine();
        }
   
    }
}
