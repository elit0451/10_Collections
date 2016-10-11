using System;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class Portfolio
    {
        private List<IAsset> listOfAssets;
        public Portfolio(List<IAsset> stocks)
        {
            listOfAssets = stocks;
        }
        public Portfolio()
        {
            listOfAssets = new List<IAsset>();
        }

        public void AddAsset(IAsset asset)
        {
            listOfAssets.Add(asset);
        }  

        internal IAsset GetAssetByName(string name)
        {
            IAsset element = null;
            foreach(IAsset stock in listOfAssets)
            {
                if(stock.GetName().Equals(name))
                {
                    element = stock;
                }
            }
            return element;
        }

        internal double GetTotalValue()
        {
            double totalValue = 0;
            foreach(IAsset stock in listOfAssets)
            {
                totalValue = totalValue + stock.GetValue();
            }
            return totalValue;
        }

        //Interfaceof Lists -- create an interface
        internal IList<IAsset> GetAssetsSortedByName()
        {
            //INJECTION for somereason
            listOfAssets.Sort(new StockNameComparator());
            return listOfAssets;
        }
        
        internal IList<IAsset> GetAssets()
        {
            return listOfAssets.AsReadOnly();
        }

        internal IList<IAsset> GetAssetsSortedByValue()
        {
            listOfAssets.Sort(new StockValueComparator());
            return listOfAssets;
        }
    }
}