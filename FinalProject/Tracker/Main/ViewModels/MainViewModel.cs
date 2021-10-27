using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Services;
using Models.Models;
using System.Collections.ObjectModel;
using Main.Commands;
using Main.Components;
using Main.Views;
using System.Windows.Input;


namespace Main.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly CurrentUserService userService;
        private readonly TipService tipService;
        private IEnumerable<Tip> userTips;
        private IEnumerable<int> progress;

        public MainViewModel(Services.CurrentUserService userService, Services.TipService tipService)
        {
            this.userService = userService;
            this.tipService = tipService;
            Load();

        }

        public ObservableCollection<TipComponent> UserTips { get; private set; } = new ObservableCollection<TipComponent>();

        public bool IsTipsNotEmpty { get; private set; }


        private async void Load()
        {
            if (userService.IsAutorized)
            {
                userTips = await tipService.GetUsersTipsAsync(userService.User.Id);
                progress = await tipService.GetSelectedTips(userService.User.Id);

                UserTips = new ObservableCollection<TipComponent>(userTips.Select(x =>
                {
                    return new TipComponent
                    {
                        Tip = x,
                        IsChecked = progress.Contains(x.Id),
                    };
                }));



                IsTipsNotEmpty = UserTips.Count > 0;
            }
        }

        //Сохранение отметки привычек и удаление отметки тех привычек, где пользователь снял отметку
        public ICommand SaveCommand => new Command(async x =>
        {
            var newChecked = UserTips.Where(a => a.IsChecked).Select(y => y.Tip.Id).Except(progress);

            if (newChecked.Count() > 0)
            {
                await tipService.MarkTipsForUser(newChecked, userService.User.Id);
            }
        });


        public ICommand AddTipCommand => new Command(async x =>
        {
            var vm = Locator.TryGet<TipViewModel>();
            await vm.Load(userTips);


            var window = new TipView();
            window.DataContext = vm;

            if (window.ShowDialog() == true)
            {
                var tip = vm.Selected;

                await tipService.AddTipForUser(userService.User.Id, tip.Id);

                UserTips.Add(new TipComponent { Tip = tip, IsChecked = false });

            }

        });

    }
}
