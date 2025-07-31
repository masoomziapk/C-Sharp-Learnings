//using System;

//public class Person
//{
//	private string name;
//	private int age;

//	public string Name
//	{
//		get { return name; }
//		set { name = value; }
//	}

//	public int Age
//	{
//		get { return age; }
//		set
//		{
//			if (value >= 0)
//				age = value;
//			else
//				Console.WriteLine("Age cannot be negative");
//		}
//	}
//}

//using System;

//public class Person
//{
//    private string name;
//    private int? age = null;

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }

//    public int? Age
//    {
//        get { return age; }
//        set
//        {
//            if (value >= 0)
//            {
//                age = value;
//            }
//            else
//            {
//                age = null;
//                Console.WriteLine("Age cannot be negative.");
//            }
//        }
//    }

//    public string DisplayAge
//    {
//        get
//        {
//            return age.HasValue ? age.ToString() : "Invalid Value";
//        }
//    }
//}
