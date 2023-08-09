using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT2
{
    internal interface IRegistrationSevice
    {
        void Register(string name, string surname, string patronymic, string emailAddress, string username);
    }
}
