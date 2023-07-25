namespace FileStorageContext
{
    internal static class DataGeneration
    {
        private const double MaxValueOfPallet = 1000;
        private const double MaxValueOfBox = 200;
        private const int numberOfPallets = 20;
        private static Random rdm = new Random();
        public static ICollection<Pallet> GeneratePallets()
        {
            var pallets= new List<Pallet>();
            for (int i = 0; i < numberOfPallets; i++)
            {
                int countOfBoxes = rdm.Next(20);
                Pallet pallet = new Pallet(
                    i+1,
                    (decimal)(rdm.NextDouble() * MaxValueOfPallet),
                    (decimal)(rdm.NextDouble() * MaxValueOfPallet),
                    (decimal)(rdm.NextDouble() * MaxValueOfPallet));
                pallets.Add(pallet);
            }
            return pallets;
        }

        public static ICollection<Box> GenerateBoxes()
        {
            var boxes = new List<Box>();
            Random rdm = new Random();
            for (int i = 0; i < numberOfPallets; i++)
            {
                Box box = new Box(
                   rdm.NextInt64(),
                   (decimal)(rdm.NextDouble() * MaxValueOfBox),
                   (decimal)(rdm.NextDouble() * MaxValueOfBox),
                   (decimal)(rdm.NextDouble() * MaxValueOfBox),
                   (decimal)(rdm.NextDouble() * MaxValueOfBox),
                   rdm.NextInt64(1, i + 1));
                if (i % 2 == 0)
                {
                    box.DateOfProdaction = (new DateOnly(2020, 10, 1)).AddDays(rdm.Next(730));
                }
                boxes.Add(box);
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

    }
}
