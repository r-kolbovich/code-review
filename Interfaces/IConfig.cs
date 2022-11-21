using Mihai_M_P1.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mihai_M_P1.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser(); 
        string GetUsername();
        string GetPassword();
    }
}
