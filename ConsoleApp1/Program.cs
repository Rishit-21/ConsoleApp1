using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public int id;
        public string name;
        public   long enroll = 190470107036;

        public Student(int id,string name)
        {
            this.id = id;
            this.name = name;

        }
        public void display()
        {
            Console.WriteLine(id + " " + name+" "+enroll);
        }
    }
    class Program
    {
        //public String Show(string msg)
        //{
        //    Console.WriteLine("hello  there");
        //    return msg;
        //}
        //public void show1(int val)
        //{
        //    val *= val;
        //    Console.WriteLine("value inside calling: " + val);
        //}
        //public void show2(ref int val)
        //{
        //    val *= val;
        //    Console.WriteLine("value inside calling: " + val);
        //}

        //public void show3(out int val)
        //{
        //    int val1 = 7;
        //    val = val1;
        //    val *= val;
        //    Console.WriteLine("value inside calling: " + val);
        //}

        //public void show4(int[] arr1)
        //{
        //    int min = arr1[0];
        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        if (min > arr1[i])
        //        {
        //            min = arr1[i];
        //        }
        //    }

        //    int max = arr1[0];
        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        if (max < arr1[i])
        //        {
        //            max = arr1[i];
        //        }
        //    }
        //    Console.WriteLine("this is min number: " +min);
        //    Console.WriteLine("this is max number: " +max);
        //}

        static void Main(string[] args)
        {

            Class1 exeClass = new Class1();
            Console.Write("Enter number of rows in pattern u want: ");

            int n = Convert.ToInt32(Console.ReadLine());
            exeClass.exe1(n);




            ///Obj and classes
            ///

            Student s1 = new Student(21, "Rishit");
            s1.enroll = 190470107029;
            Student s2 = new Student(25, "RK");
            //s1.insert(21,"Rishit");
            //s2.Student();
            s1.display();
            s2.display();


            //int a = 12;
            //int b = 5;
            //int total = a + b;
            //Console.WriteLine("Total:{0} + {1} = {2}", a, b, total, "\n");
            //Console.Write("Enter a number: ");


            //int num1 = Convert.ToInt32(Console.ReadLine());
            //if (num1 % 2 == 0)
            //{
            //    Console.WriteLine("It is even number");
            //}
            //else
            //{
            //    Console.WriteLine("It is odd number");
            //}
            ////Console.ReadLine();



            //Console.Write("Enter Marks: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num < 0 || num > 100)
            //{
            //    Console.WriteLine("wrong Number.");
            //}
            //else if (num > 0 && num < 50)
            //{
            //    Console.WriteLine("FAIL");
            //}
            //else if (num >= 50 && num < 60)
            //{
            //    Console.WriteLine("D Grade");
            //}
            //else if (num >= 60 && num < 70)
            //{
            //    Console.WriteLine("C Grade");
            //}
            //else if (num >= 70 && num < 80)
            //{
            //    Console.WriteLine("B Grade");
            //}
            //else if (num >= 80 && num < 90)
            //{
            //    Console.WriteLine("A Garde");
            //}
            //else if (num >= 90 && num <= 100)
            //{
            //    Console.WriteLine("A+ Grade");
            //}
            ////Console.ReadLine();

            //Console.Write("Enter aa number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //switch (num2)
            //{
            //    case 13:
            //        Console.WriteLine("It is 13");
            //        break;
            //    case 23:
            //        Console.WriteLine("It is 23");
            //        break;
            //    case 33:
            //        Console.WriteLine("It is 33");
            //        break;
            //    default:
            //        Console.WriteLine("Its nither 13,23,33");
            //        break;
            //}



            //for(int i=1; i <= 12; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for(int i = 1; i<5; i++)
            //{
            //    for(int j = 1; j < 5; j++)
            //    {
            //        Console.WriteLine(i + " " + j);
            //    }
            //}




            //int l = 1;
            //while (l <= 10)
            //{
            //    Console.WriteLine(l);
            //        l++;
            //}


            //for (int i = 1; i <= 12; i++)
            //{
            //    if (i == 5) break;

            //    else Console.WriteLine(i);
            //}



            //for (int i = 1; i < 5; i++)
            //{
            //    for (int j = 1; j < 5; j++)
            //    {
            //        if (i == 2 && j == 2) break;

            //        else Console.WriteLine(i + " " + j);
            //    }
            //}

            //for (int i = 1; i <= 12; i++)
            //{
            //    if (i == 5) continue;

            //    else Console.WriteLine(i);
            //}

            //for (int i = 1; i < 5; i++)
            //{
            //    for (int j = 1; j < 5; j++)
            //    {
            //        if (i == 2 && j == 2) continue;

            //        else Console.WriteLine(i + " " + j);
            //    }
            //}

            ////////Arrays///////
            //int[] arr = new int[5];
            //arr[0] = 10;
            //arr[3] = 20;
            //arr[4] = 30;

            //for(int i=0; i < arr.Length; i++)
            //{
            //    Console.Write(" " +arr[i]);
            //}
            //Console.WriteLine();


            //one of the type to  write array     --int[] arr1 = { 1, 23, 5, 6, 8, 9 };
            //one of the type to  write array     --int[] arr1 = new int[] { 1, 23, 5, 6, 8, 9 };
            //one of the type to  write array     --int[] arr1 = new int[5]{ 1, 23, 5, 6, 8, 9 };

            //int[] arr1 = {56,23,12,100,2,89,0,8,3,899,99};

            //foreach(int i in arr1)
            //{
            //    Console.Write(" " +i);
            //}
            //Console.WriteLine();

            int[,] arr2 = new int[3, 3];

            arr2[0, 1] = 10;
            arr2[1, 2] = 20;
            arr2[2, 0] = 30;

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j] + "  ");
                }
                Console.WriteLine();

            }


            //int[][] arr3 = new int[3][];
            //arr3[0] = new int[] { 1, 2, 3, 4, 5 };
            //arr3[1] = new int[] { 6, 7, 8, 9, 10, 11 };
            //arr3[2] = new int[] { 6, 7, 8, 9, 10, 11 };

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    for (int j = 0; j < arr3[i].Length; j++)
            //    {
            //        Console.WriteLine(arr3[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Argument Length: " + args.Length);
            //Console.WriteLine("Supplied Argument: ");

            //foreach(object obj in args)
            //{
            //    Console.WriteLine(obj);
            //}



            //int val = 50 ,val2;
            //Console.WriteLine("before calling value: " +val);
            //Program p = new Program();
            //Program z = new Program();
            //String message = p.Show("Rishit");
            //Console.WriteLine(message);
            //z.show1(val);
            //z.show2(ref val);
            //Console.WriteLine("After calling: " + val);
            //z.show3(out val2);
            //Console.WriteLine("after calling out function: " + val2);
            //Console.WriteLine("after calling arr fun:");
            //z.show4(arr1);
            Console.ReadLine();

        }
   
    }
}
