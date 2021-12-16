using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Christiansoe.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }

        public string Details { get; set; }

        public Animal()
        {

        }
    }
}
