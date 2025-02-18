using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatch
{
    public interface IProfile
    {
        string GetPersonalInformation(String name, String address, String email, String phone);
    }
}
