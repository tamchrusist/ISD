using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Struct
{
    struct UserBirthday
    {
        public DateTime userBirthdayNext;
        public void DisplayInfoNextBirthday()
        {
            Console.WriteLine($"До Дня Рождения осталось: {Math.Abs(DateTime.Today.Subtract(userBirthdayNext).Days)} дней");
        }
    }
}
