using BusinessLogic;
using FileStorageContext;
using PrintToConsole;

namespace Monopoly_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStorage fileStorage = new FileStorage();
            Calculations palletBuilder = new Calculations(fileStorage);
            Printer printer = new Printer();
            printer.PrintSortedByExpiryDatePallets(palletBuilder.SortedPallets);
            printer.PrintTopThreePalletsByBoxesExpiryDate(palletBuilder.TopThreeSortedPallets);
        }
    }
}