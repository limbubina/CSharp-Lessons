using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section12
{
    internal interface ITraveller
    {
        string GetDestination();
        string GetStartLocation();

        double DetermineMiles();
    }
}
