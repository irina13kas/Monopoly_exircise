namespace FileStorageContext
{
    internal static class DataGeneration
    {
        private const double MaxValueOfPallet = 1000;
        private static List<Pallet> Pallets=new List<Pallet>();
        private const int numberOfPallets = 10;
        private const int numberOfBoxes = 50;

        private static Random rdm = new Random();
        public static ICollection<Pallet> GeneratePallets()
        {
            var pallets= new List<Pallet>();
            for (int i = 1; i < numberOfPallets; i++)
            {
                int countOfBoxes = rdm.Next(20);
                Pallet pallet = new Pallet(
                    i,
                    (decimal)(rdm.NextDouble() * MaxValueOfPallet),
                    (decimal)(rdm.NextDouble() * MaxValueOfPallet),
                    (decimal)(rdm.NextDouble() * MaxValueOfPallet));
                pallets.Add(pallet);
            }
            Pallets = pallets;
            return pallets;
        }

        public static ICollection<Box> GenerateBoxes()
        {
            var boxes = new List<Box>();
            Random rdm = new Random();
            for (int i = 0; i < numberOfBoxes; i++)
            {
                int palletId = rdm.Next(1, numberOfPallets);
                var pallet = Pallets[palletId-1];
                Box box = new Box(
                    palletId,
                   i + 1,
                   GenerateRandomDecimal(1,pallet.Height),
                   GenerateRandomDecimal(1, pallet.Width),
                   GenerateRandomDecimal(1, pallet.Depth),
                   GenerateRandomDecimal(1, pallet.Weight));
                {
                    box.DateOfProdaction = (new DateOnly(2020, 10, 1)).AddDays(rdm.Next(730));
                }
                boxes.Add(box);
                Pallets[palletId-1].Boxes.Add(box);
            }
            return boxes;
        }

        private static bool CheckSizeOfPallet(decimal boxHeight, decimal boxWidth, decimal palletHeight, decimal palletWidth)
        {
            if (boxHeight<=palletHeight && boxWidth<=palletWidth || boxWidth<=palletHeight && boxHeight<=palletWidth)
            {
                return true;
            }
            return false;
        }

        private static decimal GenerateRandomDecimal(decimal min,decimal max)
        {
            return (decimal)new Random().NextDouble() * (max - min) + min;
        }

    }
}
