using Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TrackContext context = new TrackContext())
            {
                // Tip tip = new Tip
                // {
                //    Name = "Выключение воды во время чистки зубов",
                //     Description = "В среднем за минуту из крана вытекает от 7 до 11 литров воды. Если выключать воду во время чистки зубов, то за год получится сохранить около 8 000 литров. При использовании стакана для полоскания можно еще больше сократить расход, ведь вода будет включаться уже только один раз."
                // };
                // context.Tips.Add(tip);

               // var tip = context.Tips.FirstOrDefault();

                User user = new User
                {
                    Name = "Olga",
                    Lastname = "Lashkevich",
                    Login = "Olga123",
                    Password = "12345678",
                    //Tips = new List<Tip> {tip}
                };

                context.Users.Add(user);
                context.SaveChanges(); 
                //update database
            }
        }
    }
}
