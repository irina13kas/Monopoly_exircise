using BusinessLogic;
using FileStorageContext;
using Microsoft.EntityFrameworkCore;

namespace PrintToConsole
{
    public class Printer
    {
        private readonly ApplicationContext db;

        public Printer() 
        {
            db = new ApplicationContext();
        }
        public void PrintSortedByExpiryDatePallets(Dictionary<DateOnly, List<Pallet>> pallets)
        {
            int index = 1;
            foreach(var groupOfPallets in pallets)
            {
                Console.WriteLine($"Группа {index} срок годности: {groupOfPallets.Key}");
                index++;
                foreach(var pallet in groupOfPallets.Value)
                {
                    Console.WriteLine($"Паллет {pallet.Id}: Вес - {pallet.Weight}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void PrintTopThreePalletsByBoxesExpiryDate(List<Pallet> pallets)
        {
            foreach(Pallet pallet in pallets)
            {
                Console.WriteLine($"Паллет {pallet.Id}");
                Console.WriteLine($"Наибольший срок годности у коробки: {(DateOnly)db.Pallets.Include(x=>x.Boxes).Max(y=>y.ExpiryDate)}");
                foreach(Box box in pallet.Boxes)
                {
                    Console.WriteLine($"Объем: {box.Volume}");
                }
                Console.WriteLine();
            }
        }

       
    }
}