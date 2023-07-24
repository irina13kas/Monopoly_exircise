namespace FileStorageContex
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
                    rdm.NextInt64(),
                    (decimal)(rdm.NextDouble() * MaxValueOfPallet),
                    (decimal)(rdm.NextDouble() * MaxValueOfPallet),
                    (decimal)(rdm.NextDouble() * MaxValueOfPallet));
                pallets.Add(pallet);
            }
            return pallets;
        }

        private static ICollection<Box> GenerateBox(int index)
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
                   rdm.NextInt64(numberOfPallets));
                if (index % 2 == 0)
                {
                    box.DateOfProdaction = (new DateOnly(2020, 10, 1)).AddDays(rdm.Next(730));
                }
                else
                {
                    box.ExpiryDate = (new DateOnly(2020, 10, 1)).AddDays(rdm.Next(730));
                }
                boxes.Add(box);
            }
            return boxes;
        }

        private static bool CheckSizeOfPallet(decimal boxHeight, decimal boxWidth, decimal palletHeight, decimal palletWidth)
        {
            decimal maxParametrOfBox = Math.Max(boxHeight, boxWidth);
            decimal maxParametrOfPallet = Math.Max(palletHeight, palletWidth);
            decimal minParametrOfBox = boxHeight + boxWidth - maxParametrOfBox;
            decimal minParametrOfPallet = palletHeight + palletWidth - maxParametrOfPallet;
            if (maxParametrOfBox <= maxParametrOfPallet && minParametrOfBox <= minParametrOfPallet)
            {
                return true;
            }
            return false;
        }

    }
}
