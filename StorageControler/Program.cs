﻿using BusinessLogic;
using FileStorageContext;
using PrintToConsole;

namespace StorageControler
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            ApplicationContext db = new ApplicationContext();
            Calculations calculator= new Calculations();
            var r = await calculator.SortPallets();
            Printer printer = new Printer();

            printer.PrintSortedByExpiryDatePallets(await calculator.SortPallets());
            printer.PrintTopThreePalletsByBoxesExpiryDate(await calculator.GetThreePalletsWithHighestExpiryDate());
        }
    }
}