namespace FileStorageContex
{
    internal static class DataGeneration
    {
        private const double MaxValueOfPallet = 1000;
        private const double MaxValueOfBox = 200;
        private static Random rdm = new Random();
        public static Pallet GeneratePallet()
        {
            int countOfBoxes=rdm.Next(20);
            Pallet pallet = new Pallet(
                rdm.NextInt64(),
                (decimal)(rdm.NextDouble() * MaxValueOfPallet),
                (decimal)(rdm.NextDouble() * MaxValueOfPallet),
                (decimal)(rdm.NextDouble() * MaxValueOfPallet));
            for (int j = 0; j < countOfBoxes; j++)
            {
                Box box = GenerateBox(j);
                if (CheckSizeOfPallet(box.Height, box.Width, pallet.Height, pallet.Width))
                {
                    pallet.Boxes.Add(box);
                }
            }
            return pallet;
        }

        private static Box GenerateBox(int index)
        {
            Random rdm = new Random();
            Box box = new Box(
                   rdm.NextInt64(),
                   (decimal)(rdm.NextDouble() * MaxValueOfBox),
                   (decimal)(rdm.NextDouble() * MaxValueOfBox),
                   (decimal)(rdm.NextDouble() * MaxValueOfBox),
                   (decimal)(rdm.NextDouble() * MaxValueOfBox));
            if (index % 2 == 0)
            {
                box.DateOfProdaction = (new DateOnly(2020, 10, 1)).AddDays(rdm.Next(730));
            }
            else
            {
                box.ExpiryDate = (new DateOnly(2020, 10, 1)).AddDays(rdm.Next(730));
            }
            return box;
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
