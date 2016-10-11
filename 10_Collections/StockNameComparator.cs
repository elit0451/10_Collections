using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    class StockNameComparator : IComparer<IAsset>
    {
        public int Compare(IAsset first,IAsset second)
        {
            int result = 0;
            if(first.GetName().CompareTo(second.GetName())> 0)
            {
                result = 1;
            }
            else if(first.GetName().CompareTo(second.GetName()) < 0)
            {
                result = -1;
            }
            return result;

            //EAZY SOLUTIONZ: return first.GetName().CompareTo(second.GetName())
        }
    }
}
