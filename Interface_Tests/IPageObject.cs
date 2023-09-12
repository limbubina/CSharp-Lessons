using OpenQA.Selenium.DevTools.V108.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Tests
{
    internal interface IPageObject
    {
        //can contain properites
        string PageName
        {
            get;     
        }
    }
}
