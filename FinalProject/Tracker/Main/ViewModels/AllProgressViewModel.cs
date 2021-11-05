using Main.Services;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.ViewModels
{
    class AllProgressViewModel : BaseViewModel
    {
        private readonly CurrentUserService userService;
        private readonly UserProgressService tipService;
        private int choiseIndex;

        public AllProgressViewModel(CurrentUserService userService, UserProgressService tipService)
        {
            this.userService = userService;
            this.tipService = tipService;

            Load();
        }

        private async void Load()
        {
            int id = userService.User.Id;
            progresses = (await tipService.GetAllProgress(id)).ToArray();
            UpdateGroups(0);

        }

        public bool ViewByDate { get; set; }

        void UpdateGroups(int index)
        {
            ViewByDate = index == 0;

            if (ViewByDate && Group1 == null)
            {
                Group1 = new ObservableCollection<IGrouping<DateTime, Tip>>
                    (progresses.GroupBy(x => x.DateTime, y => y.Tips, new GenericComparer<DateTime>(x => x.Date)));
            }
            else if (!ViewByDate && Group2 == null)
            {
                Group2 = new ObservableCollection<IGrouping<Tip, DateTime>>
                    (progresses.GroupBy(x => x.Tips, y => y.DateTime, new GenericComparer<Tip>(x => x.Id)));
            }

        }


        private UserProgress[] progresses;

        public ObservableCollection<IGrouping<DateTime, Tip>> Group1 { get; private set; }
        public ObservableCollection<IGrouping<Tip, DateTime>> Group2 { get; private set; }

        public int ChoiseIndex
        {
            get => choiseIndex;
            set
            {
                choiseIndex = value;
                OnPropertyChanged();
                UpdateGroups(choiseIndex);
            }
        }

        public string[] Choises { get; } = new string[] { "Дате", "Привычке" };
    }
}
