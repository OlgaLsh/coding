using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Models;
using System.Data.Entity;


namespace Main.Services
{
    public class TipService
    {
        public async Task<IEnumerable<Tip>> GetUsersTipsAsync(int userId)
        {
            using (var context = new TrackContext())
            {
                var user = await context.Users.FindAsync(userId);
                await context.Entry(user).Collection(x => x.Tips).LoadAsync();

                return user.Tips;
            }
        }

        // Привычки отмеченные пользователем сегодня.
        public async Task<IEnumerable<int>> GetSelectedTips(int userId)
        {
            var date = DateTime.Now;

            using (var context = new TrackContext())
            {
                await context.UserProgresses.Where(x => x.UserId == userId && x.DateTime.Day == DateTime.Now.Day).LoadAsync();

                return context.UserProgresses.Local.Select(x => x.TipId);
            }

        }

        public async Task<Tip[]> GetAllTips()
        {
            using (var context = new TrackContext())
            {
                await context.Tips.LoadAsync();

                return context.Tips.ToArray();
            }
        }

        public async Task AddTipForUser(int userId, int tipId)
        {
            using (var context = new TrackContext())
            {
                var user = await context.Users.FindAsync(userId);
                var tip = await context.Tips.FindAsync(tipId);
                await context.Entry(user).Collection(x => x.Tips).LoadAsync();
                user.Tips.Add(tip);

                await context.SaveChangesAsync();
            }
        }

        internal async Task MarkTipsForUser(IEnumerable<int> newChecked, int userId)
        {

            using (var context = new TrackContext())
            {

                var newProgresses = newChecked.
                    Select(x => new UserProgress { TipId = x, UserId = userId, DateTime = DateTime.Now });

                context.UserProgresses.AddRange(newProgresses);

                await context.SaveChangesAsync();
            }
        }
    }
}
