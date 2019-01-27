using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencingThisExplicitly
{
    class CourseInstance
    {
        public Student _student;
        public string _courseID;

        // init
        public void Init(Student student, string courseID)
        {
            this._student = student;
            this._courseID = courseID;
        }

        // display
        public void Display()
        {
            Console.WriteLine(_courseID);
        }
    }
}
