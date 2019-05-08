using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08052019
{
    class Program
    {
        static void Main(string[] args)
        {



            // int a = 10;
            //int b = 17;
            // string city = "Paris";
            // string capital = "Baku";

            // a += 12;
            // a -= 5;


            // if (city == capital)
            // {
            //         Console.WriteLine("That is right");

            //  }
            //  else
            // {
            //        Console.WriteLine("That is no right");
            // }
            //   Console.ReadLine();

            //int[] ages={ 13,34,56,87};

            //  foreach(int item in ages)
            //  {
            //     Console.WriteLine(item);

            //      Console.ReadLine();

            //    }


            student stu1 = new student();

            stu1.Name = "Behruz";
            stu1.Surname ="Fatalizade";
           

            car car1 = new car();
            Console.WriteLine(car1.currentfuel);
            Console.ReadLine();

        }
    }
}
