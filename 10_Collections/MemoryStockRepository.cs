using System.Collections;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class MemoryStockRepository : IStockRepository
    {
        private List<Stock> allStockObjs = new List<Stock>();
        public int Id { get; set; }

        public long NextId()
        {
            Id = Id + 1;
            return Id;
        }

        public void SaveStock(Stock stockObj)
        {
            allStockObjs.Add(stockObj);
        }



        public Stock LoadStock(long idNumber)
        {
            Stock same =new Stock();
            foreach (Stock allStockObj in allStockObjs)
            {
                
                if (idNumber == allStockObj.Id)
                {
                    same = allStockObj;
                }
            }
            return same;
            
        }


        public List<Stock> FindAllStocks()
        {

            return allStockObjs;
        }


        public void Clear()
        {
            allStockObjs.Clear();
        }

    }
}