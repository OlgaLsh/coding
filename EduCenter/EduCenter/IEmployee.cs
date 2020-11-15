using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter
{
    interface IEmployee
    {
        void Vacation();
        bool IfVacation // в отпуске ли сотрудник
        {
            get;
            set;
        }

    }
}
