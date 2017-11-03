using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1.Stack
{
    class StackElem<T>
    {
        public T Value { get; set; } //Wert des obersten Elements
        public StackElem<T> Next { get; set; } //Verweis auf das 'nächste' Element -> vom Stack ausgesehen das 2te von oben
    }
}
