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
        [Key]
        [Column(Order =1)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int TipId { get; set; }

        public DateTime DateTime { get; set; }

        public User User { get; set; }

        public Tip Tips { get; set; }
    }
}
