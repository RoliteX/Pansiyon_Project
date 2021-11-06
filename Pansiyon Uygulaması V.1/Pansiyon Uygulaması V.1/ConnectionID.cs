using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pansiyon_Uygulaması_V._1
{
    class ConnectionID
    {
        public string Address = System.IO.File.ReadAllText(@"C:\PansiyonProject.txt");
    }
}
