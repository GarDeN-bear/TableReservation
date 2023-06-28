using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableReservation
{
    internal class Table
    {
        private int Number;
        private int MaxFreePlaces;
        public Table (int number, int maxFreePlaces)
        {
            Number = number;
            MaxFreePlaces = maxFreePlaces;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Номер стола: {Number}\nСвободных мест за столом: {MaxFreePlaces}");
        }
        public void ReservePlaces(int countPlaces)
        {
            Console.SetCursorPosition(0, 15);
            Console.WriteLine($"Необходимо забронировать {countPlaces} мест за столом под номером {Number}");
            if (countPlaces > MaxFreePlaces)
            {
                Console.WriteLine($"За столом под номером {Number} недостаточно свободных мест");
            }
            else
            {
                MaxFreePlaces -= countPlaces;
                Console.WriteLine($"Бронирование прошло успешно");
            }
        }

    }
}
