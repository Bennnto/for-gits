namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //1, using streamReader Class to read from a file
                //2. using streamWriter Class to write to a file
                string input;
                int recordNumber;
                StreamReader myFile = new StreamReader(student.txt);
                recordNumber = Convert.ToInt32(input);
                Console.WriteLine("Number of record: " + recordNumber);
            }
        }
        
    }
}
