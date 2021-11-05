using Main.Commands;
using Main.Services;
using Main.Views;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Main.ViewModels
{
    public class TipViewModel : BaseViewModel
    {
        private readonly TipService tipService;
        private readonly CurrentUserService userService;
        private bool isNewTip;

        public ObservableCollection<Tip> Tips { get; private set; }

        public TipViewModel(TipService tipService, CurrentUserService userService)
        {
            this.tipService = tipService;
            this.userService = userService;
        }

        public async Task Load(IEnumerable<Tip> userTips)
        {
            if (userService.IsAutorized)
            {
                Tips = new ObservableCollection<Tip>((await tipService.GetAllTips()).
                    Except(userTips, new GenericComparer<Tip>(x => x.Id)));

            }
            else
            {
                MessageBox.Show("Пользователь не авторизован", "", MessageBoxButton.OK, MessageBoxImage.Error);
                //var current = App.Current.MainWindow;

                //App.Current.MainWindow = new AutorizeView();
                //App.Current.MainWindow.Show();
                //current.Close();

            }
        }

        public bool IsNewTip
        {
            get => isNewTip;
            set
            {
                isNewTip = value;
                if (value && Selected == null)
                    Selected = new Tip();
            }
        }


        public Tip Selected { get; set; }

        public ICommand ChooseCommand => new Command(x =>
        {
            if (x is Window w)
            {

            }
        });
    }
}
