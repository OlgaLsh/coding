using Main.Commands;
using Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Main.Views;

namespace Main.ViewModels
{
    class RegisterViewModel
    {
        public string Login { get; set; }
        public PasswordBox Password { get; set; } = new PasswordBox();
        public string Name { get; set; }
        public string LastName { get; set; }    

        public ICommand Register => new Command(obj =>
        {
            if (obj is Window wind)
            {
                var log = Login;
                var pass = Password.Password;
                var name = Name;
                var lname = LastName;

                using (TrackContext context = new TrackContext())
                {
                    
                    if(context.Users.Any(x => x.Login == log || x.Password == pass))
                    {
                        MessageBox.Show("Пользователь с такими данными уже существует!");

                    }

                    var user = new User
                    {
                        Login = log,
                        Password = pass,
                        Lastname = lname,
                        Name = name
                    };

                    context.Users.Add(user);
                    context.SaveChanges();

                    App.Current.MainWindow = new AutorizeView();
                    wind.Close();
                    App.Current.MainWindow.Show();
                }
            }
            
        });
    public ICommand ToAutorize => new Command(x =>
   {
       if (x is Window wind)
       {
           App.Current.MainWindow = new AutorizeView();
           wind.Close();
           App.Current.MainWindow.Show();
       }
   });

    }
}
