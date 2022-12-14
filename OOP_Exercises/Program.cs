#define Hello
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Security.Policy;

namespace OOP_Exercises
{
    //This is Constructor Exercise.
    /*internal class Program
    {
        string name;
        int age;
        int rollNo;

        public Program(string name, int age, int rollNo) // This is a Parametrized Constructor.
        {
            this.name = name;
            this.age = age;
            this.rollNo = rollNo;
                      
        }

        void DisplayDetails()
        {
            Console.WriteLine("Name of Student is {0}", name);
            Console.WriteLine("Name of Student is {0}", age);
            Console.WriteLine("Name of Student is {0}", rollNo);
        }

        public Program() // This is a Default Constructor.
        {
            Console.WriteLine("This is a Default Constructor!!");
        }              

        static void Main(string[] args)
        {
            Program p = new Program("asd", 25, 2569);
            
            Console.ReadLine();
        }
    }*/

    //This is Struct Exercise.
    /* struct Program
    {
        public int a;
        public void Display()
        {
            Console.WriteLine("The value of a = {0}", a);             
        }

        static void Main(string[] args)
        {
            Program obj;
            obj.a = 10;
            obj.Display();
            Console.ReadLine();
        }
    } */

    //This is Enum Exercise.
    /*class Enum
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        static void Main(string[] args)
        {
            int weekStart = (int)Days.Mon;
            int weekEnd = (int)Days.Sat;

            Console.WriteLine("First day of a week is: {0}", weekStart);
            Console.WriteLine("Last day of a week is: {0}", weekEnd);
            Console.ReadLine();

        }
    }*/

    //This is Inheritance Exercise.
    /*    class GetArea
        {
            protected double l = 10.5;
            protected double w = 5.6;
        }

        class Rectangle : GetArea
        {
            public void Total()
            {
                double area = l * w;
                Console.WriteLine(area);
            }
        }

        class Programn { 
            static void Main(string[] args)
            {
                Rectangle obj = new Rectangle();
                obj.Total();
                Console.ReadLine();
            }   
        }*/

    //This is Polymorphism Exercise.
    /*class Methodoverloading //This is Static/Compile-Time Polymorphism.
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sum(float a, float b)
        {
            Console.WriteLine(a + b);
        }
    }

    class Program
    {
        static void Main()
        {
            Methodoverloading obj = new Methodoverloading();
            obj.Sum(10.5F, 10.5F);
            Console.ReadLine();
        }
    }*/

    /*class Methodoverriding //This is Dynamic/Run-Time Polymorphism.
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class Dog : Methodoverriding
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }

        static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();
            Console.ReadLine();
        }
    }*/

    //This is Interface Exercise.
    /* public interface IDisplayArea
     {
        void Area();
     }

     class Hello : IDisplayArea
     {
         public void Area()
         {
             Console.WriteLine("Interface invoked!!");
         }

         static void Main()
         {
             Hello obj = new Hello();
             obj.Area();
             Console.ReadLine();
         }
     }*/

    //This is Object and Dynamic Datatype Exercise.
    /*class Program
    {
        static void Main()
        {
            object a = 10;
            object b = 20;
            object c = (int)a + (int)b;
            Console.WriteLine(c);
            Console.ReadLine();
        }

    }*/

    //This is Loops Exercise.
    /*class Program
    {
        static void Main()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Hello");
                i++;
            }
            Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int i = 0;
            do
            {
                i++;
                Console.WriteLine("Hello");
            } while (i < 5);

            Console.ReadLine();

     class Program
        {
            static void Main()
            {
                int i = 0;
                Console.WriteLine("Even Numbers:");
                for (i = 0; i < 50; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }

                Console.WriteLine("\nOdd Numbers:");
                for (i = 0; i < 50; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.ReadLine();
            }
        }*/

    //This is Null-Colease operator
    /*class Program
    {
        static void Main()
        {
            int? a = null;
            int? b = 20;
            int? c = a ?? b;
            Console.WriteLine(c);

        }
    }*/

    //This is Single and Multi-dimensional Array Exercise.
    /*class Program
    {
        static void Main()
        {
            int[,] my_array = new int[2, 2]
            {
                {25, 58},
                {85, 45}
            };
            int i, j;

            for(i=0; i<2; i++)
            {
                for(j=0; j<2; j++)
                {
                    Console.WriteLine("my_array[{0},{1}] = {2}", i, j, my_array[i, j]);
                }
            }

            Console.ReadLine();


            //my_array[0] = 11;
            //my_array[1] = 22;

            Console.WriteLine(my_array[0,1]);
        }
    }*/

    //This is a jagged array Exercise.
    /*class JaggedArray
    {
        static void Main()
        {
            int[][] my_array = new int[2][];
            my_array[0] = new[] {25, 26, 258, 5};
            my_array[1] = new[] { 54, 47, 32 };

            int i, j;

            for(i = 0; i < 2; i++)
            {
                for(j = 0; j < 3; j++)
                {
                    Console.WriteLine("my_array[{0},{1}] = {2}", i, j, my_array[i][j]);
                }
            }            
        }        
    }*/

    //This is String Exercise.
    /* class StringProg
     {
         static void Main(string[] args)
         {
             string str = "This is test";

             if (str.Contains("hello"))
             {
                 Console.WriteLine("The sequence 'test' was found.");
             }
             else
             {
                 Console.WriteLine("OUT");
             }

             Console.ReadKey();
         }
     }*/

    //This is Operator-Overloading Exercise.
    /*class qwerty
    {
        public int num;
        public string str;

        public static qwerty operator +(qwerty obj1, qwerty obj2)
        {
            qwerty obj3 = new qwerty();
            obj3.num = obj1.num + obj2.num;
            obj3.str = obj1.str + obj2.str;
            return obj3;
        }
    }

    class Exe
    {
        static void Main()
        {
            qwerty obj1 = new qwerty();
            obj1.num = 20;
            obj1.str = "Hussnain ";

            qwerty obj2 = new qwerty();
            obj2.num = 30;
            obj2.str = "Fareed";

            qwerty obj3 = new qwerty();
            obj3 = obj1 + obj2;

            Console.WriteLine(obj3.num);
            Console.WriteLine(obj3.str);
            Console.ReadLine();
        }
    }*/

    //This is Preprocessor Directives Exercise.
    /*class Pre
    {
        #region
        static void Main()
        {
#if Hello
            Console.WriteLine("Preprocessor is defined!");
#else
global::System.Console.WriteLine("Preprocessor is not defined!");

#endif
        }        
#endregion
    }*/

    //This is Pointers Exercise.
    /*unsafe class PointerExercise
    {
        static void Main()
        {
            int* a;
            int b = 100;

            a = &b;
            Console.WriteLine((int)a);
        }       
    }*/

    //This is Conditional Operator Exercise.
    /*class Operator
    {
        static void Main()
        {
            int x = 5, y = 10;
            var result = x > y ? "X is greater" : "Y is greater";
            Console.WriteLine(result);
        }
    }*/

    //This is Recursion Exercise.
    /*class Program
    {
        int num = 5;
        int result = 1;
        public int Factorial()
        {
            if (num == 0)
            {
                return result;
            }
            result = result * num;
            num--;
            Factorial();
            return result;
        }

        static void Main()
        {
            Program obj = new Program();
            int a = obj.Factorial();
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }*/

    //This is Main Method Arguments Exercise.
    /*class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine("Argument: " + arg);    
            }
            Console.ReadLine();
        }
    }*/

    //This is C# Properties Exercise.
    /*class Program{

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        static void Main()
        {
            Program program = new Program();
            program.Name = "Hello";
            Console.WriteLine(program.Name);
        }
    }*/

    //This is File Read Write Exercise.
    /*class Program
    {
        static void Main()
        {
            string writeText = "Hello World!";
            File.WriteAllText(@"C:\Users\hasni\Desktop\C# OOP concepts with examples\text.txt", writeText);

            string readText = File.ReadAllText(@"C:\Users\hasni\Desktop\C# OOP concepts with examples\text.txt");
            Console.WriteLine(readText);
            Console.ReadLine();
        }
        
    }*/

    //This is Exception Exercise. try, catch, finally
    /*class Program
    {
        static void Main()
        {
            try
            {
                int[] arr = { 1, 2, 6 };
                Console.WriteLine(arr[3]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine("Finally block is running now!");

            }
            Console.ReadLine();
        }
    }*/

    //This is Dependency Injection Exercise.
    //DI using Constructor injection
    /* interface IAccount
     {
         void AccountDetails();
     }

     class CurrentAccount : IAccount
     {
         public void AccountDetails()
         {
             Console.WriteLine("Details of Currnet Accounts");
         }
     }

     class SavingAccount : IAccount
     {
         public void AccountDetails()
         {
             Console.WriteLine("Details of Saving Accounts");
         }
     }

     class Account
     {
         private IAccount account;

         public Account(IAccount acc)
         {
             this.account = acc;
         }

         public void PrintAccount()
         {
             account.AccountDetails();
         }
     }

     class Program
     {        
         static void Main()
         {
             IAccount ca = new CurrentAccount();
             Account a = new Account(ca);
             a.PrintAccount();

             IAccount sa = new SavingAccount();
             Account a2 = new Account(sa);
             a2.PrintAccount();

             Console.ReadLine();
         }
     }*/

    //DI using Property injection.
    /* interface IAccount
     {
         void AccountDetails();
     }

     class CurrentAcount : IAccount
     {
         public void AccountDetails()
         {
             Console.WriteLine("Details of Current Accounts.");
         }
     }

     class SavingAcount : IAccount
     {
         public void AccountDetails()
         {
             Console.WriteLine("Details of Saving Accounts.");
         }
     }

     class Account
     {
         public IAccount property { get; set; }

         public void PrintAccounts()
         {
             property.AccountDetails();
         }
     }

     class Program
     {
         static void Main()
         {
             Account ca = new Account();
             ca.property = new CurrentAcount();
             ca.PrintAccounts();

             Account sa = new Account();
             ca.property = new SavingAcount();
             ca.PrintAccounts();

             Console.ReadLine();
         }
     }*/

    //DI using Method Injection.
    /*interface IAccount
    {
        void AccountDetails();
    }

    class CurrentAcount : IAccount
    {
        public void AccountDetails()
        {
            Console.WriteLine("Details of Current Accounts.");
        }
    }

    class SavingAcount : IAccount
    {
        public void AccountDetails()
        {
            Console.WriteLine("Details of Saving Accounts.");
        }
    }

    class Account
    {
       public void PrintDetails(IAccount account)
        {
            account.AccountDetails();
        }
    }

    class Program
    {
        static void Main()
        {
            Account ca = new Account();
            ca.PrintDetails(new CurrentAcount());

            Account sa = new Account();
            sa.PrintDetails(new SavingAcount());

            Console.ReadLine();
        }
    }*/

    //This is Regular Expressions Exercise.
    /*class Program
    {
        private static void showMatch(string text, string exp)
        {
            Console.WriteLine("Expression is " + exp);
            MatchCollection mc = Regex.Matches(text, exp);

            foreach (Match i in mc)
            {
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            string str = " A Thousand Splendid Suns";

            Console.WriteLine("Matching words that start with 'S': ");
            showMatch(str, @"\bS\S+");

            Console.ReadLine();
        }
    }*/

    //This is Custom Data Annotation Exercise.
    /*class Program
    {
        [AttributeUsage(AttributeTargets.Class)]
        class CustomAttribute : Attribute
        {

        }

        [Custom]
        class Person
        {
            //[Custom] You cannot define Custom attribute here cuz its target is class only.
            int id { get; set; }
            string name { get; set; }
        }
    }*/

    //This is LINQ Exercise.
    /*class Program
    {
        static void Main()
        {
            int[] age = { 26, 87, 12, 35, 18, 20 };

            var a = from i in age where i > 20 orderby i descending select i;

            foreach(int item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }*/

    //This is LINQ to SQL Exercise.

}

//This is namespace Exercise.
/*namespace one
{
    class One
    {
        public void MethodOne()
        {
            Console.WriteLine("This is class one!!");
        }
    }
}

namespace two
{
    class Two
    {       
        public void MethodTwo()
        {
            Console.WriteLine("This is class two!!");
        }
    }
}

class Hello
{
    static void Main()
    {
        one.One obj1 = new one.One();
        two.Two obj2 = new two.Two();
        obj1.MethodOne();
        obj2.MethodTwo();
    }
}*/


