using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFightWebApi.Models
{
    public class Problem
    {
        public int Id { get; set; }
        public string Qestion { get; set; }
        public string Answer { get; set; }
        public int Difficulty { get; set; }
    }
}
