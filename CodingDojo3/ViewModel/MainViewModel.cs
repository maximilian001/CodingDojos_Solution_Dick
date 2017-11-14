using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo3.ViewModel
{
    public class MainViewModel
    {
        string zeit = DateTime.Now.ToLocalTime().ToShortTimeString();
        string datum = DateTime.Now.ToLocalTime().ToShortDateString();

        public MainViewModel()
        {
            
        }
    }
}
