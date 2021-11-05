using Main.Components;
using Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        public async Task<IEnumerable<int>> GetMarkedTips(int userId)
        {
            var date = DateTime.Now;

            using (var context = new TrackContext())
            {
                await context.UserProgresses.Where(x => x.UserId == userId &&
                    x.DateTime.Day == DateTime.Now.Day &&
                    x.DateTime.Month == DateTime.Now.Month &&
                    x.DateTime.Year == DateTime.Now.Year).LoadAsync();

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

        public async Task AddNewTipForUser(int userId, Tip tip)
        {
            using (var context = new TrackContext())
            {
                var user = await context.Users.FindAsync(userId);

                tip.Id = 0;
                tip.Users = new List<User> { user };

                context.Tips.Add(tip);
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

        internal async Task RemoveMarkedTipsForUser(IEnumerable<int> newUnchecked, int id)
        {
            using (var context = new TrackContext())
            {

                string p2 = string.Join(",", newUnchecked.Select(x => x));

                await context.Database.ExecuteSqlCommandAsync($"DELETE FROM [UserProgresses] WHERE [UserId]=@uId AND [TipId] IN ({p2})", new SqlParameter("uId", id));

            }
        }
    }
}
