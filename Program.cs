using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3PoAvramenko
{
    class Program
    {
        static void Main(string[] args)
        {
            string x_str, variant0, variant;
            double x, variant123, y=0;
            Console.WriteLine("Enter x =");
            x_str = Console.ReadLine();
            x = Convert.ToDouble(x_str);
            Console.WriteLine("Choose variant! Enter one of these: 1, 2, 3, first, second, third. (register isn't important)");
            variant0 = Console.ReadLine();
            variant = variant0.Replace(" ", "");
            
                try 
                {
                    variant123 = Convert.ToDouble(variant);
                }
                catch
                {
                    variant = variant.ToLower();
                }
            
            switch (variant)
            {
                case "1":
                case "first" : y = Math.Pow(Math.Sin(x), 2); break;
                case "2":
                case "second": y = Math.Pow(Math.Log10(x), 2); break;
                case "3":
                case "third": y = 1/Math.Cos(Math.Pow(x, 3)); break;
                default: Console.WriteLine("You entered wrong variant. Try again."); break;
            }
            Console.WriteLine("y={0}. Finish!", y);
            Console.ReadLine();
        }
    }
}
