using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _10_Collections
{
    internal class StockValueComparator : IComparer<IAsset>
    {
       public int Compare(IAsset first,IAsset second)
        {
            int result = 0;
            if(first.GetValue() < second.GetValue())
            {
                result = 1;
            }
            else if(first.GetValue() > second.GetValue())
            {
                result = -1;
            }

            return result;
        }
    }
}