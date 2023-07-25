using FileStorageContext;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic
{
    public class Calculations 
    {
        private readonly StoreDbContext db;
        public Calculations()
        {
            db = new StoreDbContext();
        }

        public async Task<Dictionary<DateOnly,List<Pallet>>> SortPallets()
        {
            var pallet = await db.Pallets
                .Include(x => x.Boxes)
                .ToListAsync();


            return pallet 
                .Where(x => x.ExpiryDate!=null)
                .GroupBy(key => key.ExpiryDate)
                .OrderBy(x => x.Key)
                .ToDictionary(
                    x=>(DateOnly)x.Key!,
                    y=>y.OrderBy(p=>p.Weight).ToList());
        }

        public async Task<List<Pallet>> GetThreePalletsWithHighestExpiryDate()
        {
            var pal =await db.Pallets
                .Include(x => x.Boxes)
                .ToListAsync();
            var topSortedPallets =  pal
                .Where(x => x.Boxes.Any())
                .OrderByDescending(p => p.Boxes.Max(y => y.ExpiryDate))
                .Take(3)
                .ToList();

            foreach(var pallet in topSortedPallets)
            {
                pallet.Boxes = pallet.Boxes.OrderBy(b => b.Volume).ToList();
            }
            return topSortedPallets;
        }
    }
}