using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Models;
using Main.Commands;
using Main.Services;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Main.ViewModels
{
    public class TipViewModel : BaseViewModel
    {
        private readonly TipService tipService;
        private readonly CurrentUserService userService;

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
                MessageBox.Show("Пройдите авторизацию!", "", MessageBoxButton.OK, MessageBoxImage.Error);

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
