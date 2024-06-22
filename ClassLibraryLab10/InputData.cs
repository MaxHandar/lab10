using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public static class InputData
    {
        public static int NumInput(string msg = "", bool notNegative = true)
        {
            bool isConvert;
            int N;
            do
            {
                Console.WriteLine(msg);
                string buf = Console.ReadLine();
                isConvert = int.TryParse(buf, out N);

                if (!isConvert)
                {
                    Console.WriteLine("Неправильно введено число, попробуй еще раз");
                }
                else if (notNegative && N<0)
                {
                    Console.WriteLine("Число должно быть >=0!");
                }
            } while (!isConvert || notNegative && N < 0);
            return N;
        }
        public static string StringInput(string msg = "")
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }
        public static bool BoolInput(string question = "")
        {
            do
            {
                Console.WriteLine(question);
                Console.WriteLine("1. Да");
                Console.WriteLine("2. Нет");
                int answer = NumInput();

                switch (answer)
                {
                    case 1:
                        {
                            return true;
                        }
                    case 2:
                        {
                            return false;
                        }
                    default:
                        {
                            Console.WriteLine("Неправильно задан пункт меню");
                            break;
                        }
                }
            } while (true);
        }
    }
}
