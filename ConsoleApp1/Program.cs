using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    /// interface
    interface calcAdd1
    {
        int add(int a, int b);
    }
    interface calcSub1
    {
        int sub(int a, int b);
    }
    interface calcMlti1
    {
        int mlti(int a, int b);
    }
    interface calcDiv
    {
        float div(int a, int b);
    }

    class calculator : calcAdd1, calcSub1, calcMlti1,calcDiv
    {
        public int result1;
        public int add(int a,int b)
        {
            result1 = a + b;
            return result1;
        }

        public int result2;
        public int sub(int a,int b)
        {
            result2 = a - b;
            return result2;
        }
        public int result3;
        public int mlti(int a,int b)
        {
            result3 = a * b;
            return result3;

        }
        public int result4;
        public float div(int a, int b)
        {
            
            result4 = a / b;
            return result4;

            
         
        }
    }

    /// Encapsulation
    class Employee
    {
        private int EmployeeId;
        public int empId
        {
            get
            {
                return EmployeeId;
            }
            set
            {
                EmployeeId = value;
            }

        }
        private string EmployeeName;
        public string empName
        {
            get
            {
                return EmployeeName;
            }
            set
            {
                EmployeeName = value;
            }

        }
        private string Address;
        public string add
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }

        }
        public void ShowDetails()
        {
            Console.WriteLine("Employee Id : {0}, Name : {1}, Address : {2}", EmployeeId, EmployeeName, Address);
        }
    }
    ///polymorph////// and ///// overridding
    ///
    public class calculator1
    {
        public virtual int calc(int a,int b)
        {
            return 0;
        }
    }
    public class calcAdd:calculator1
    {
        public override int calc(int a, int b)
        {
            return a + b;
        }
    }
    public class calcSub : calculator1
    {
        public override int calc(int a, int b)
        {
            return a - b;
        }
    }
    public class calcmulti : calculator1
    {
        public override int calc(int a, int b)
        {
            return a * b;
        }
    }

    ///Inheritance eg
    public class  College
    {
        public string clgName1;
        public College(string clgName1)
        {
            this.clgName1 = clgName1;
        }
    }
    public class Subjects
    {
        public string sub1, sub2, sub3;
        public Subjects(string sub1,string sub2,string sub3)
        {
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
        }
    }
    public class Student
    {
        public int id;
        public string name;
        public Subjects subjects;//Aggregation 
        //public   long enroll = 190470107036;


   
        public Student(int id, string name, Subjects subjects)
        {
            this.id = id;
            this.name = name;
            this.subjects = subjects;
           
            
            //this.clgName1 = clgName1;

        }
        public void display()
        {
            Console.WriteLine(id + " " + name+"   " +subjects.sub1+" "+subjects.sub2+"  "+subjects.sub3);
        }
        //~Student()
        //{
        //    Console.WriteLine("its destructor");
        //       Console.ReadLine();
        //}
     
    }
    /// method overloading eg
    public class Clac
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }

    }

    public class InvalidInput : Exception
    {
        public InvalidInput(string msg):base(msg)
        {

        }
    }


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
        /// out param eg
        public int show3(out int val,out bool check)
        {
            int val1 = 7;
            val = val1;
            val *= val;
            check = val > 100 ? true : false;

            Console.WriteLine("value inside calling: " + val);
            return val;
        }

        public void show4(int[] arr1)
        {
            int min = arr1[0];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (min > arr1[i])
                {
                    min = arr1[i];
                }
            }

            int max = arr1[0];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (max < arr1[i])
                {
                    max = arr1[i];
                }
            }
            Console.WriteLine("this is min number: " + min);
            Console.WriteLine("this is max number: " + max);
        }

        
        public static void validate(int n)
        {
            if (n > 26)
            {
                throw new InvalidInput("Enter Proper value btw 1 to 26");
            }
        }
    static void Main(string[] args)
        {

            Class1 exeClass = new Class1();
            Console.Write("Enter number of rows in pattern u want: ");
            

            int n = Convert.ToInt32(Console.ReadLine());

            try
            {
                validate(n);
                exeClass.exe1(n);
            }
            catch(InvalidInput e) { Console.WriteLine(e);}




            ///Obj and classes
            ///
            College c = new College("vvp");
            Subjects sub = new Subjects("AJAVA", "ADA", "DBMS");
            Student s1 = new Student(21, "Rishit",sub);
            Student s2 = new Student(25, "RK",sub);
            //s1.insert(21,"Rishit");
            //s2.Student();
            s1.display();
            s2.display();
            //Clac c = new Clac();
            Console.WriteLine( Clac.add(12, 13, 45));

            calculator1 c1 = new calculator1();
            c1 = new calcAdd();
            Console.WriteLine( c1.calc(5, 12));
            c1 = new calcSub();
            Console.WriteLine(c1.calc(20, 25));
            c1 = new calcmulti();
            Console.WriteLine(c1.calc(10, 10));



            Employee emp = new Employee();
            emp.empId = 1;
            emp.empName = "Rishit";
            emp.add = "Rajkot";
            emp.ShowDetails();

            try
            {
                calculator cal = new calculator();
                cal.add(5, 8);
                Console.WriteLine(cal.result1);
                cal.sub(5, 8);
                Console.WriteLine(cal.result2);
                cal.mlti(5, 8);
                Console.WriteLine(cal.result3);
                cal.div(5, 0);
                Console.WriteLine(cal.result4);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }


            ////basic conceptss
            ////////////////////
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



            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
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

            ////////Arrays///////
            int[] arr = new int[5];
            arr[0] = 10;
            arr[3] = 20;
            arr[4] = 30;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();


            //one of the type to  write array     --int[] arr1 = { 1, 23, 5, 6, 8, 9 };
            //one of the type to  write array     --int[] arr1 = new int[] { 1, 23, 5, 6, 8, 9 };
            //one of the type to  write array     --int[] arr1 = new int[5]{ 1, 23, 5, 6, 8, 9 };

            int[] arr1 = { 56, 23, 12, 100, 2, 89, 0, 8, 3, 899, 99 };

            foreach (int i in arr1)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

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


            int[][] arr3 = new int[3][];
            arr3[0] = new int[] { 1, 2, 3, 4, 5 };
            arr3[1] = new int[] { 6, 7, 8, 9, 10, 11 };
            arr3[2] = new int[] { 6, 7, 8, 9, 10, 11 };

            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3[i].Length; j++)
                {
                    Console.WriteLine(arr3[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Argument Length: " + args.Length);
            Console.WriteLine("Supplied Argument: ");

            foreach (object obj in args)
            {
                Console.WriteLine(obj);
            }



            int val = 50, val2;
            bool check;
            Console.WriteLine("before calling value: " + val);
            Program p = new Program();
            Program z = new Program();
            String message = p.Show("Rishit");
            Console.WriteLine(message);
            z.show1(val);
            z.show2(ref val);
            Console.WriteLine("After calling: " + val);

            //// out parameter eg;
            z.show3(out val2,out check);
            Console.WriteLine("after calling out function: " + val2 +check);
            Console.WriteLine("after calling arr fun:");
            z.show4(arr1);
            Console.ReadLine();


        }
   
    }
}
