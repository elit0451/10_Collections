using System.Collections.Generic;
using System.Collections;

namespace _10_Collections
{
    internal interface IStockRepository
    {
        long NextId();
        void SaveStock(Stock stockObj);
        Stock LoadStock(long idNumber);

        List<Stock> FindAllStocks();

        void Clear();
    }
}