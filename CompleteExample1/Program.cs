using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteExample1
{
    class DrivingLisence {
        public int age;

        public int Check(int a)
        {
            this.age = a;
            if (a < 0)
            {
                Console.WriteLine("negative numbers cannot be an age value!!!!");
                Check(a);
            }
            else if (age >= 18)
            {
                return 1;

            }
            return 0;
   
        }
        public string checkRes()
        {
            int res = Check(age);

            if (res == 0)
            {
                Console.WriteLine("not available for driving lisence");

            }
            else if (res==1)
            {
                Console.WriteLine("available");
            }

            return string.Format("---");
        }
                
    }


   
    class Program
    {
        static void Main(string[] args)
        {

            int age;
            Console.WriteLine("type your age: ");
            age = Int32.Parse(Console.ReadLine());
            DrivingLisence obj = new DrivingLisence();
            object obj1 = obj.Check(age);
            object ress = obj.checkRes();

            Console.Read();

         

        }
    }
}
