using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class UserProgress
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public int TipId { get; set; }

        public DateTime DateTime { get; set; }

        public User User { get; set; }

        public Tip Tips { get; set; }
    }
}
