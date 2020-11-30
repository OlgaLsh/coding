using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblWorm
{
   class Magazine : Item, IPubs
    {
        private String volume; // том
        private int number; // номер
        private String title; // название
        private int year; // дата выпуска
        private bool returnSrok; // возврат
        public bool IfSubs { get; set; } // подписка на журнал

        public Magazine(String volume, int number, String title, int year, long invNumber, bool taken, bool IfSubs) : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
            this.IfSubs = IfSubs;
        }
        public void ReturnSrok()
        {
            returnSrok = true;
        }
        public override void Return() // операция "вернуть"
        {
            //taken = true;
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }

        public void Subs()
        {

        }

        public override string ToString()
        {
            if (IfSubs)
                return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
                "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка оформлена" + base.ToString();
            else
                return "\nЖурнал:\n Название: " + title + "\nТом: " + volume +
                "\n Номер: " + number + "\nГод выпуска: " + year + "\n Подписка не оформлена" + base.ToString(); ;
        }
    }

}
