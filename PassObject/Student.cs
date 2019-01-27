namespace PassObject
{
    // Demonstrate how to pass an object to a method
     class Student
    {
        public string firstName;
        public string lastName;
        

        public Student()
        {
            firstName = "John";
            lastName = "Doe";
        }

        public Student(string v1, string v2)
        {
            firstName = v1;
            lastName = v2;
        }

        //
        public void SetName(string fName, string lName)
        {
            firstName = fName;
            lastName = lName; ;
        }

        //
        public string ToNameString()
        {
            string s = firstName + " " + lastName;
            return s;
        }
    }
}
