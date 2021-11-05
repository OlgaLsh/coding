using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.Entity;

namespace Main.Services
{
    class UserProgressService
    {
        internal async Task<List<UserProgress>> GetAllProgress(int id)
        {
            using (TrackContext context = new TrackContext())
            {
                await context.UserProgresses.Where(x => x.UserId == id).Include(x => x.Tips).LoadAsync();
                var progresses = context.UserProgresses.Local.ToList();
                return progresses;
            }
        }
    }
}
