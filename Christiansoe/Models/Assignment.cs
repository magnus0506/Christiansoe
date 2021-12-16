using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Christiansoe.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Details { get; set; }

        public string Difficulty { get; set; }

        public Assignment()
        {

        }
    }
}
