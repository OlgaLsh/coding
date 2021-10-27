using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Main.Commands;
using Main.Services;
using Main.Views;


namespace Main.ViewModels
{
    public class AutorizeViewModel
    {
        private readonly CurrentUserService userService;
        private string login;
        private PasswordBox password = new PasswordBox();

        public AutorizeViewModel(CurrentUserService userService)
        {
            this.userService = userService;
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

        public ICommand EnterCommand => new Command(obj =>
        {
            if (obj is Window wind)
            {
                if (userService.TryAutorize(login, Password.Password))
                {
                    App.Current.MainWindow = new MainWindow();

                    wind.Close();
                    App.Current.MainWindow.Show();
                }
            }
        }, obj => Login != null && Password != null && Password.Password != null && Login.Length > 2
        && Password.Password.Length > 2);


        public ICommand ToRegister => new Command(x =>
        {
            if (x is Window wind)
            {

                App.Current.MainWindow = new RegisterView();
                wind.Close();
                App.Current.MainWindow.Show();
            }
        });
    }
}

