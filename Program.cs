using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TableReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool resetrvationIsOpen = true;
            Random rnd = new Random();
            int countTables = 5;
            Table[] tables = new Table[countTables];
            for (int i = 0; i < countTables; ++i)
            {
                tables[i] = new Table(i + 1, rnd.Next(2, 6));
            }
            while (resetrvationIsOpen)
            {
                for (int i = 0; i < countTables; ++i)
                {
                    tables[i].ShowInfo();
                }
                int reservationNumber = rnd.Next(1, 5);
                int countPlaces = rnd.Next(2, 6);
                tables[reservationNumber - 1].ReservePlaces(countPlaces);
                while (true)
                {
                    Console.SetCursorPosition(0, 17);
                    string clear = "                                                     ";
                    Console.WriteLine(clear);
                    Console.WriteLine(clear);
                    Console.WriteLine(clear);
                    Console.WriteLine(clear);
                    Console.SetCursorPosition(0, 17);
                    Console.Write($"Остановить регистрацию?)\nВведите [д/н]: ");
                    string breakReservation = Console.ReadLine();
                    if (breakReservation == "д")
                    {
                        resetrvationIsOpen = false;
                        break;
                    }
                    else if (breakReservation != "н" && breakReservation != "д")
                    {
                        Console.Write("Я не знаю такой команды.\nНажмите на любую кнопку для повтора команды");
                        Console.ReadKey();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Clear();
            }

        }
    }
}
