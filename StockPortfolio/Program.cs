using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockPortfolio.Models;
namespace StockPortfolio
{
    class Program
    {        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Inicializando Portafolio de Stocks");
                Portfolio PortfolioList = new Portfolio();
                PortfolioList.StockList.Add(new Stock(200, DateTime.Now));
                PortfolioList.StockList.Add(new Stock(100, DateTime.Now));
                PortfolioList.StockList.Add(new Stock(150, DateTime.Now));
                PortfolioList.StockList.Add(new Stock(520, DateTime.Now));
                Console.WriteLine("------Inicialización Completa------");

                Console.WriteLine("----Llamando a método Profit-------");
                var profit = PortfolioList.Profit(DateTime.Now, DateTime.Now);
                Console.WriteLine("Profit = " + profit.ToString());

                var annual = PortfolioList.AnnualizedReturn(2019);
                Console.WriteLine("Annualized Return 2019 = " + annual.ToString());
                Console.ReadLine();
            }
            catch (Exception ex)
            {   //TODO: Chequear por cada innerException
                Debug.WriteLine(ex.Message);
            }
            
        }
    }
}
