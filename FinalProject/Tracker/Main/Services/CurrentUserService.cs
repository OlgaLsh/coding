using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Models;

namespace Main.Services
{
    public class CurrentUserService
    {
        public bool IsAutorized { get; private set; }
        public User User { get; private set; }

        public event Action<User> Autorized;
        public event Action Exited;
        private void Autorize(User user)
        {
            User = user;
            IsAutorized = true;
            Autorized?.Invoke(user);
        }

        public void Exit()
        {
            User = null;
            IsAutorized = false;
            Exited?.Invoke();
        }
        public bool TryAutorize(string log, string pass)
        {
            using (TrackContext context = new TrackContext())
            {
                var user = context.Users.FirstOrDefault(x => x.Login == log && x.Password == pass);

                if (user != null)
                {
                    Autorize(user);
                }
                return user != null;

            }
        }

    }
}
