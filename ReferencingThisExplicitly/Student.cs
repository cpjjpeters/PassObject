using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencingThisExplicitly
{
    public class Student
    {
        public string _name;
        public int _id;
        // The course
        CourseInstance _courseInstance;

        // init
        public void Init(string name, int id)
        {
            this._name = name;
            this._id = id;
            _courseInstance = null;
        }

        // Enroll
        public void Enroll(string courseID)
        {
            _courseInstance = new CourseInstance();
            _courseInstance.Init(this, courseID); // the eexplici reference
        }

        // Display
        public void DisplayCourse()
        {
            Console.WriteLine(_name);
            _courseInstance.Display();
        }


    }
}
