using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntirePlantStaff
{
    public abstract class DepartmentTwo
    {
        Production productTwo;

        public DepartmentTwo()
        {
            productTwo = new Production("Vernashapik", "Ays bajin@ artadrum e vernashapikner");
        }
    }
}
