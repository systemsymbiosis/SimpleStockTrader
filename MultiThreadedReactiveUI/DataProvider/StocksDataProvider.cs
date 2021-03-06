﻿using System.Collections.Generic;
using MultiThreadedReactiveUI.DataProvider;
using MultiThreadedReactiveUI.Model;

namespace MultiThreadedReactiveUI.DataProvider
{
    public class StocksDataProvider : IStocksDataProvider
    {
        public IEnumerable<Model.Stock> LoadStocks()
        {
            return new List<Model.Stock>
            {
                new Model.Stock {Symbol = "TEA", Type = StockType.Common, FixedDividend=0, LastDividend=0, ParValue=100, Price=45},
                new Model.Stock {Symbol = "POP", Type = StockType.Common, FixedDividend=0, LastDividend=8, ParValue=100, Price=67},
                new Model.Stock {Symbol = "ALE", Type = StockType.Common, FixedDividend=0, LastDividend=23, ParValue=60, Price=42},
                new Model.Stock {Symbol = "GIN", Type = StockType.Preferred, FixedDividend=2, LastDividend=8, ParValue=100, Price=76},
                new Model.Stock {Symbol = "JOE", Type = StockType.Common, FixedDividend=0, LastDividend=13, ParValue=250, Price=90},

            };

        }
    }
}
