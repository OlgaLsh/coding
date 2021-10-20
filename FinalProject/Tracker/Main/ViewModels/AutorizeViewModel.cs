using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Main.ViewModels
{
    public class AutorizeViewModel
    {
        private string login;
        private PasswordBox password = new PasswordBox();

        public AutorizeViewModel()
        {

        }


        public string Login
        {
            get => login;
            set
            {
                login = value;
            }
        }


        public PasswordBox Password
        {
            get => password;
            set
            {
                password = value;
            }

        }

       // public ICommand EnterCommand { get; } = new Command(() =>
       // {
        //    using (TrackContext context = new TrackContext())
        //    {
        //        string pass = Password.Password;
                //найти пользователя с логином и паролем
       //     }
       // });

    }
}

