using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencingThisExplicitly
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Init("Stephen Hawkins", 1234);

            Console.WriteLine("Enrolling");
            student.Enroll("Biology 101");
            Console.WriteLine("Resulting student record: ");
            student.DisplayCourse();
            Console.Read();
        }
    }
}
