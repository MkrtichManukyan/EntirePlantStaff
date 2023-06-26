using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntirePlantStaff
{
    public abstract class DepartmentOne
    {
        Production productOne;

        public DepartmentOne()
        {
            productOne = new Production("Tabat", "Ays bajin@ artadrum e tabatner");
        }
    }
}
