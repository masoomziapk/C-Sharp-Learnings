// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int myNum = 10000;
//Console.WriteLine(myNum);

//string myName = "Muhammad Masoom";
//Console.WriteLine(myName);

//long aNum = 394820492038483902L;
//Console.WriteLine(aNum);

//float fNum = 17.2f;
//Console.WriteLine(fNum);

//double dNum = 16.212d;
//Console.WriteLine(dNum);

//bool bNum = false;
//Console.WriteLine(bNum);

//char cNum = 'a';
//Console.WriteLine(cNum);

//using System;

//class program
//{
//    static void Main(string[] args)
//    {
//        student student1 = new student();
//        student1.name = "Muhammad Masoom";
//        student1.age = 25;
//        student1.Introduce();
//    }
//}

//class program
//{
//    static void Main(string[] args)
//    {
//        book book1 = new book();
//        book1.booknum = 1;
//        book1.title = "The Alchemist";
//        book1.aurthor = "Paulo Coelho";
//        book1.pages = 197;
//        book1.DisplayInfo();

//        book book2 = new book();
//        book2.booknum = 2;
//        book2.title = "Atomic Habits";
//        book2.aurthor = "James Clear";
//        book2.pages = 320;
//        book2.DisplayInfo();
//    }
//}

//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Book book1 = new Book();
//        book1.BookNumber = 1;
//        book1.Title = "The Alchemist";
//        book1.Author = "Paulo Coelho";
//        book1.Pages = 197;
//        book1.DisplayInfo();

//        Book book2 = new Book();
//        book2.BookNumber = 2;
//        book2.Title = "Atomic Habits";
//        book2.Author = "James Clear";
//        book2.Pages = 320;
//        book2.DisplayInfo();
//    }
//}

//using System;

//class program
//{
//    static void Main(string[] args)
//    {
//        Book book1 = new Book("The Alchemist", 1, "Paulo Coelho", 197);
//        Book book2 = new Book("Atomic Habits", 2, "James Clear", 320);

//        book1.DisplayInfo();
//        book2.DisplayInfo();
//    }
//}

//using System;

//class program
//{
//    static void Main(string[] args)
//    {
//        Person person = new Person();

//        person.Name = "Masoom";
//        person.Age = -25;

//        Console.WriteLine("Name : " + person.Name);
//        Console.WriteLine("Age : " + person.Age);
//    }
//}

//using System;

//class program
//{
//    static void Main(string[] args)
//    {
//        Person person = new Person();

//        person.Name = "Masoom Zia";
//        person.Age = 25;

//        Console.WriteLine("Name : " + person.Name);
//        Console.WriteLine("Age : " + person.DisplayAge);
//        Console.WriteLine(person.DisplayAge.GetType()); //From this we will check the datatype of Age
//    }
//}

//using System;

//namespace LearnCSharp
//{
//    public class MyClass
//    {
//        public static void Main(string[] args)
//        {
//            Console.Write("Enter Name: ");
//            string name = Console.ReadLine();
//            Console.WriteLine("Your Name is " + name);
//        }
//    }
//}

//using System;
//using System.Security.Cryptography.X509Certificates;

//public class program
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter Your Name: ");
//        string name = Console.ReadLine();
//        Console.WriteLine("Your Name is " + name);
//    }
//}

//using System;

//public class program
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter First Value: ");
//        int a = int.Parse(Console.ReadLine());
//        Console.Write("Enter Second Value: ");
//        int b = int.Parse(Console.ReadLine());
//        int c = a + b;
//        Console.WriteLine("Your answer is " + c);
//    }
//}

//using System;

//public class program
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter First Value: ");
//        bool successA = int.TryParse(Console.ReadLine(), out int a);
//        Console.Write("Enter Second Value: ");
//        bool successB = int.TryParse(Console.ReadLine(),out int b);

//        if (successA && successB)
//        {
//            int c = a + b;
//            Console.WriteLine("Your answer is " + c);
//        }
//        else
//        {
//            Console.WriteLine("Invalid Input! Please Enter Numeric Value");
//        }
//    }
//}

//using System;
//using System.Security.Authentication;
//using System.Security.Cryptography.X509Certificates;

//public class program
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("First Value: ");
//        bool aaa = int.TryParse(Console.ReadLine(), out int a);
//        Console.Write("Enter Second: ");
//        bool aab = int.TryParse(Console.ReadLine(), out int b);

//        if(aaa && aab)
//        {
//            int c = a + b;
//            Console.WriteLine("Your answer is " + c);
//        }
//        else
//        {
//            Console.WriteLine("Invalid Input! Supported Numeric Value Only");
//        }


//    }
//}

//using System;

//public class program
//{
//    public static void Main(string[] args)
//    {
//        string a = @"Masoom\";
//        Console.WriteLine(a);
//    }
//}

//using System;

//public class program
//{
//    public static void Main(string[] args)
//    {
//        int b = 15;
//        string a = "Masoom";
//        Console.WriteLine($"My name is {a} and my age is {b}.");
//    }
//}

//using System;

//namespace First;
//public class Program
//{
//    public static void Main(String[] args)
//    {
//        bool isPrinterConnected = false;
//        if (isPrinterConnected)
//        {
//            Console.WriteLine("Document Printed Successfully!");
//        }
//        else
//        {
//            Console.WriteLine("Printer is not connected to host");
//        }
//    }
//}

//using System;

//namespace First;
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter number: ");
//        int enteredNumber = int.Parse(Console.ReadLine());

//        if (enteredNumber == 10)
//        {
//            Console.WriteLine("Correct");
//        }
//        else if (enteredNumber < 10)
//        {
//            Console.WriteLine("Very Less");
//        }
//        else
//        {
//            Console.WriteLine("Very Big");
//        }
//    }
//}

//using System;

//namespace First;

//public class program
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter Marks: ");
//        int sMarks = int.Parse(Console.ReadLine());

//        if (sMarks >= 0 && sMarks <= 100)
//        {
//            if (sMarks >= 90)
//            {
//                Console.WriteLine("Your grade is A+");
//            }
//            else if (sMarks >= 80)
//            {
//                Console.WriteLine("Your grade is A");
//            }
//            else if (sMarks >= 70)
//            {
//                Console.WriteLine("Your grade is B");
//            }
//            else if (sMarks >= 60)
//            {
//                Console.WriteLine("Your grade is C");
//            }
//            else if (sMarks >= 50)
//            {
//                Console.WriteLine("Your grade is D");
//            }
//            else
//            {
//                Console.WriteLine("Your Fail.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid Input! Number should be positive or less than 100.");
//        }

//    }
//}

//using System;

//namespace First;
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter grade (A, B, C, D): ");
//        string sGrade = Console.ReadLine().ToUpper();

//        switch (sGrade)
//        {
//            case "A":
//                Console.WriteLine("Brilliant");
//                break;

//            case "B":
//                Console.WriteLine("Execellent");
//                break;

//            case "C":
//                Console.WriteLine("Great");
//                break;

//            case "D":
//                Console.WriteLine("Average");
//                break;

//            default:
//                Console.WriteLine("Invalid Input");
//                break;
//        }
//    }
//}

//using System;

//public class Program
//{
//    public static void Main(String[] args)
//    {
//        for (int i = 1; i <=5 ; i++)
//        {
//            Console.WriteLine("Results are " + i);
//        }
//    }
//}

//using System;

//public class Program
//{
//    public static void Main(String[] args)
//    {
//        for (int i = 2; i <= 10; i += 2)
//        {
//            Console.WriteLine("Even numbers are " + i);
//        }
//    }
//}

//using System;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        for (int i = 0; i <= 10; i++)
//        {
//            if (i % 2 == 0)
//            {
//                Console.WriteLine("Even numbers are " + i);
//            }
//        }
//    }
//}

//for (int i = 1; i <= 10; i++)
//{
//    if (i == 5)
//    {
//        continue; // skip 5
//    }
//    Console.WriteLine(i);
//}

using System;

namespace First_CSharp;

public class Program
{
    public static void Main(string[] args)
    {
        string[] cars = { "Mazda", "Honda", "Volvo", "BMW", "Toyota" };
        Console.WriteLine("* * * *** Fruits List *** * * *");
        Console.WriteLine("");
        
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }
    }
}