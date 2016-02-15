using TestProjectConsole.DAL;
using System;

namespace TestProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            Console.WriteLine("Calling db!!");
            try
            {
                var result = p.GetNumberOfClasses();
                Console.WriteLine("Number of classes are: " + result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        public int GetNumberOfClasses()
        {
            //MSSQLDA da = new MSSQLDA();

            var data = MSSQLDA.GetClasses();

            return data.Count;
        }
    }
}
