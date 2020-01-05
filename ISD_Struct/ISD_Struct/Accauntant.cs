using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Struct
{

//Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
//Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за
//месяц.
//Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее давать
//или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, то ему положена
//премия.

    enum Post
    {
        Sales = 40,
        CEO = 50,
        Marketer = 35,
        Support = 60
    }

    class Accauntant
    {
        public bool AskForBonus (Post worker, int hours)
        {

            if(worker == Post.CEO|| worker == Post.Marketer || worker == Post.Sales || worker == Post.Support)
            {
                if(worker-hours <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }         
        }
    }
}

