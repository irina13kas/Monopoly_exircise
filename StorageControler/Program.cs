using BusinessLogic;
using DbStorageContext;
using PrintToConsole;

namespace StorageControler
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            StoreDbContext db = new StoreDbContext();
            Calculation calculator= new Calculation();
            var r = await calculator.SortPallets();
            Printer printer = new Printer();

            printer.PrintSortedByExpiryDatePallets(await calculator.SortPallets());
            printer.PrintTopThreePalletsByBoxesExpiryDate(await calculator.GetThreePalletsWithHighestExpiryDate());
        }
    }
}