using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CountSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символы. Для завершения ввода введите точку.");

            int spaceCount = 0;
            char ch;

            do
            {
                ch = (char)Console.Read();

                if (ch == ' ')
                {
                    spaceCount++;
                }

            } while (ch != '.');

            Console.WriteLine($"Количество введенных пробелов: {spaceCount}");
        }
    }
}

