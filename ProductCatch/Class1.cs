using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatch
{
    interface IA
    {
        string GetDateTime();
    }

    interface IB
    {
        string GetDateTime();
    }

    public class CMRTime : IA, IB
    {
        string IA.GetDateTime()
        {
            return DateTime.Now.ToString();
        }

        string IB.GetDateTime()
        {
            return DateTime.UtcNow.ToString();
        }
    }

}
