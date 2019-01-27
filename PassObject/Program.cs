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
            Student st2 = new Student("Alfred", "Hitchcock");
            Student st3 = new Student();
            Student st4 = new Student();
            Student st5 = new Student();
            Console.WriteLine("eerst heet iedereen John Doe, tenzij je de naam meegeeft in de constructor");
            OutputName(st1);
            OutputName(st2);
            OutputName(st3);
            OutputName(st4);
            OutputName(st5);
            Console.WriteLine("After being modified");
            //st1.name = "Madeleine";
            st1.SetName("Herminione", "Granger"); // call instance method, not static
            OutputName(st1);
            Console.Read();

            
            //Setname(st1, "Willa");
            //OutputName(st2);
            //OutputName(st1);
            Console.WriteLine("Press enter to terminate");
            Console.Read();
        }
        public static void OutputName(Student student)
        {
            //Console.WriteLine("Student's name is {0}",student.name);
            Console.WriteLine("Student "+ student.ToString() +" zijn/haar naam is "+student.ToNameString());
        }

        //public static void Setname(Student student, string name)
        //{
        //    //student = new Student();
        //    student.name = name;
        //    OutputName(student);
        //}
    }
}
