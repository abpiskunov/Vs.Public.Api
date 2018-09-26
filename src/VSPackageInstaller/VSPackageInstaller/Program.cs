using System;
using VSPackageInstaller.MarketplaceService;

namespace VSPackageInstaller
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketplaceDataService marketplaceDataService = new MarketplaceDataService();
            Console.WriteLine("***** Marketplace data *****");
            marketplaceDataService.GetMarketplaceData();
        }
    }
}
