using BusinessLogic;
using DbStorageContext;
using PrintToConsole;

namespace StorageControler
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            StorageDbContext db = new StorageDbContext();
            Calculation calculator= new Calculation();
            Printer printer = new Printer();

            printer.PrintSortedByExpiryDatePallets(await calculator.SortPallets());
            printer.PrintTopThreePalletsByBoxesExpiryDate(await calculator.GetThreePalletsWithHighestExpiryDate());
        }
    }
}