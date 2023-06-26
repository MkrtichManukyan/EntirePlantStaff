using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntirePlantStaff
{
    internal class Factory
    {
        DepartmentOne departmentOne;
        DepartmentTwo departmentTwo;

        public Factory(DepartmentOne departmentIncomeOne, DepartmentTwo departmentIncomeTwo)
        {
            departmentOne = departmentIncomeOne;
            departmentTwo = departmentIncomeTwo;
        }
    }
}
