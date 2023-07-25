using FileStorageContext;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic
{
    public class Calculations 
    {
        private readonly ApplicationContext db;
        //public readonly Dictionary<DateOnly, List<Pallet>> SortedPallets;
        //public readonly List<Pallet> TopThreeSortedPallets;
        public Calculations()
        {
            db = new ApplicationContext();
            //TopThreeSortedPallets = GetThreePalletsWithHighestExpiryDate();
        }

        public async Task<Dictionary<DateOnly,List<Pallet>>> SortPallets()
        {
            return await db.Pallets
                .Include(x=>x.Boxes)
                .Where(x => x.ExpiryDate!=null)
                .GroupBy(key => key.ExpiryDate)
                .OrderBy(x => x.Key)
                .ToDictionaryAsync(
                    x=>(DateOnly)x.Key!,
                    y=>y.OrderBy(p=>p.Weight).ToList());
        }

        public async Task<List<Pallet>> GetThreePalletsWithHighestExpiryDate()
        {
            var topSortedPallets = await db.Pallets
                .Include(x => x.Boxes)
                .OrderByDescending(p => p.Boxes.Max(y => y.ExpiryDate))
                .Take(3)
                .ToListAsync();

            foreach(var pallet in topSortedPallets)
            {
                pallet.Boxes = pallet.Boxes.OrderBy(b => b.Volume).ToList();
            }
            return topSortedPallets;
        }
    }
}