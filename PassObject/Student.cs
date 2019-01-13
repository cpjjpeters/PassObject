namespace PassObject
{
    // Demonstrate how to pass an object to a method
     class Student
    {
        public string firstName;
        public string lastName;

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
