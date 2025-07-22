using System.Formats.Asn1;
using StudentApp2;
//create objects of the student class
Student first = new Student();
Student second = new Student();
Student third = new Student(3.4, "Ben", "Promkaew", 101582010, "AZC");
//Object x = new object()
//first.GPA = 3.9;
//first.firstName = "Beth";
//first.lastName = "BB";

//Console.WriteLine(first.firstName + " " + first.lastName + " " + "has a GPA of " + first.GPA);
// Use Get / Set
first.SetGPA(3.9);
first.SetfirstName("Beth");
first.SetlastName("BB");
first.SetcourseCode("AB");
Console.WriteLine(first.GetfirstName() + " " + first.GetlastName() + " " + "has a GPA of " + first.GetGPA());

second.SetGPA(3.5);
second.SetfirstName("Vissarut");
second.SetlastName("P");
second.SetcourseCode("AC");
Console.WriteLine(second.GetfirstName() + " " + second.GetlastName() + " " + "has a GPA of " + "Course" + " " + second.GetcourseCode() + " " + second.GetGPA());


ToString(Console.WriteLine(first.DisplayInfo));
ToString(Console.WriteLine(second.DisplayInfo));
Console.WriteLine(third.DisplayInfo);