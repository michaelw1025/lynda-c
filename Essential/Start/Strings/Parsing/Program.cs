using System;
using System.Globalization;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string numStr1 = "1";
            string numStr2 = "2.00";
            string numStr3 = "3,000";
            string numStr4 = "3,000.00";

            int targetNum = 0;
            try {
                // Parse integer
                targetNum = int.Parse(numStr1);
                Console.WriteLine(targetNum);

                // Parse a floating point number
                // Only works if the decimal value is 0
                targetNum = int.Parse(numStr2, NumberStyles.Float);
                Console.WriteLine(targetNum);

                // Parse with a thousands marker
                targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
                Console.WriteLine(targetNum);

                // Parse with a thousands marker and a decimal
                targetNum = int.Parse(numStr4, NumberStyles.Float | NumberStyles.AllowThousands);
                Console.WriteLine(targetNum);

                // Parse with bool
                Console.WriteLine($"{bool.Parse("True")}");

                // Parse with floating point number
                Console.WriteLine($"{float.Parse("1.235"):F2}");

            }
            catch {
                Console.Write("Converstion failed");
            }

            //  TryParse funcion handles the exceptions for us
            bool succeeded = false;
            succeeded = Int32.TryParse(numStr1, out targetNum);
            if(succeeded) {
                Console.WriteLine($"{targetNum}");
            }
        }
    }
}
