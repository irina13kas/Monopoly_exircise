using FileStorageContext;

namespace BusinessLogic
{
    public class Calculations 
    {
        private const int EndOfExpirationDate = 100;
        private const int StartPalletWeight = 30;
        public ICollection<Pallet> pallets;
        public readonly Dictionary<DateOnly, List<Pallet>> SortedPallets;
        public readonly List<Pallet> TopThreeSortedPallets;
        public Calculations(FileStorage fileStorage)
        {
            pallets=fileStorage.palletsData;
            ComputeParametrs();
            SortedPallets=SortPallets();
            TopThreeSortedPallets = GetThreePalletsWithHighestExpiryDate();
        }

        private void ComputeParametrs()
        {
            foreach(Pallet pallet in pallets) 
            {
                foreach(Box box in pallet.Boxes)
                {
                    if (box.ExpiryDate == null)
                    {
                        box.ExpiryDate = box.DateOfProdaction?.AddDays(EndOfExpirationDate);
                    }
                    box.Volume = box.Height * box.Depth * box.Width;
                }

                pallet.ExpiryDate = pallet.Boxes.Any() ?
                                pallet.Boxes.Min(x => x.ExpiryDate) : null;
                pallet.Volume = pallet.Depth * pallet.Width * pallet.Height + pallet.Boxes.Sum(x => x.Volume);
                pallet.Weight = StartPalletWeight + pallet.Boxes.Sum(x => x.Weight);
            }
        }
        private Dictionary<DateOnly,List<Pallet>> SortPallets()
        {
            var sortedPallets = pallets
                .Where(x => x.ExpiryDate != null)
                .GroupBy(key => key.ExpiryDate)
                .OrderBy(x => x.Key)
                .ToDictionary(
                    x=>(DateOnly)x.Key!,
                    y=>y.OrderBy(p=>p.Weight).ToList());
            return sortedPallets;
        }

        private List<Pallet> GetThreePalletsWithHighestExpiryDate()
        {
            var topSortedPallets = pallets.OrderByDescending(p => p.Boxes.Max(y => y.ExpiryDate))
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