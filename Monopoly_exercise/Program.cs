using BusinessLogic;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Data;
using FileStorageContex;
using FileStorageContext;
using Microsoft.Data.Sqlite;
using PrintToConsole;

namespace Monopoly_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var dbContextOptions = new DbContextOptionsBuilder<StoreDbContext>()
                .Options;*/


            /* StoreDbContext db = new StoreDbContext(dbContextOptions);*/
            StoreDbContext db = new StoreDbContext();

            Console.WriteLine($"Using {ProjectConstants.DatabaseProvider} database provider.");
            FileStorage fileStorage = new FileStorage();
            Calculations palletBuilder = new Calculations(fileStorage);
            Printer printer = new Printer();
            printer.PrintSortedByExpiryDatePallets(palletBuilder.SortedPallets);
            printer.PrintTopThreePalletsByBoxesExpiryDate(palletBuilder.TopThreeSortedPallets);

           
        }
    }
}