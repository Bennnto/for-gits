using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace StudentApp2
{
    internal class Student
    {
        //Attribute - fields 
        private double GPA;
        private int studentID;
        private string firstName;
        private string lastName;
        private string courseCode;

        //default constructor
        public Student()
        {

        }
        public Student(double gPA, string fName, string lName, int sID, string cCode)
        {
            GPA = gPA;
            firstName = fName;
            lastName = lName;
            studentID = sID;
            courseCode = cCode;

        }

        //Get Accessors
        public double GetGPA()
        {
            return GPA;
        }
        public string GetfirstName()
        {
            return firstName;
        }
        public string GetlastName()
        {
            return lastName;
        }
        public int GetstudentID()
        {
            return studentID;
        }
        public string GetcourseCode()
        {
            return courseCode;
        }
        //setter Mutators
        public void SetGPA(double gPA)
        {
            GPA = gPA;
        }
        public void SetfirstName(string fName)
        {
            firstName = fName;
        }
        public void SetlastName(string lName)
        {
            lastName = lName;
        }
        public void SetstudentID(int sID)
        {
            studentID = sID;
        }
        public void SetcourseCode(string cCode)
        {
            courseCode = cCode;
        }
        public void DisplayInfo(string args)
        {
            Console.WriteLine(firstName + lastName + "student id : " + studentID + "\n" + "Grade :" + GPA + " " + "of Course" + courseCode
            + "---------------------------------");
        }
        
    }

}