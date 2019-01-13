using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassObject
{

    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();

            Console.WriteLine("eerst heet ze Madeleine");
            //st1.name = "Madeleine";
            st1.SetName("Herminione", "Granger"); // call instance method, not static
            OutputName(st1);
            Console.Read();

            Console.WriteLine("After being modified");
            //Setname(st1, "Willa");
            OutputName(st1);
            Console.WriteLine("Press enter to terminate");
            Console.Read();
        }
        public static void OutputName(Student student)
        {
            //Console.WriteLine("Student's name is {0}",student.name);
            Console.WriteLine("Student zijn/haar naam is "+student.ToNameString());
        }

        //public static void Setname(Student student, string name)
        //{
        //    //student = new Student();
        //    student.name = name;
        //    OutputName(student);
        //}
    }
}
