using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestMethod();
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static void TestMethod()
        {
            int x = 4;
            int y = 0;
            int result = x / y;

            Console.WriteLine("Успешно!");
        }
    }
}
