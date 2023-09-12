using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    internal class CustomException:Exception
    {
        //constructor
        public CustomException(string message)
            :base(message)
        {

        }
    }
}
