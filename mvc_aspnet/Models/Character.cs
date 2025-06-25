using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAspnet.Models
{
    public class Character
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "Bob";
        public string Picture { get; set; } = "";
        // public Show Show { get; set; }
    }
}