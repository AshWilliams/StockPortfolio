using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPortfolio.Models
{
    class Stock
    {
        public readonly decimal p_Price;
        public readonly DateTime PriceDate;

        public Stock(decimal price, DateTime priceDate)
        {
            p_Price = price;
            PriceDate = priceDate;
        }

        public decimal Price(DateTime priceDate)
        {
            return p_Price;
        }
    }
}
