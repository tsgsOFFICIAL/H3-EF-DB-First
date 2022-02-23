using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_EF_DB_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (masterEntities ctx = new masterEntities())
            {
                var list = ctx.airports.ToList().Where(x => x.name != null).OrderBy(x => x.name).Take(69);

                foreach (var item in list)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{item.name}");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" (");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(item.code);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(")");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($" {item.countryName}");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" (");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{item.countryCode}");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(")\n");

                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            Console.ReadKey(true);
        }
    }
}
