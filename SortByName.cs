using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task4
{
    public class SortByName : IComparer<Warehouse>
    {
        public int Compare(Warehouse o1, Warehouse o2)
        {
            return o1.name.CompareTo(o2.name);
        }
    }
}
