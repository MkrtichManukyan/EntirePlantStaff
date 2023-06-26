using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntirePlantStaff
{
    internal class Production
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Production(string name, string description) 
        {
            Name = name;
            Description = description;
        }
    }
}
