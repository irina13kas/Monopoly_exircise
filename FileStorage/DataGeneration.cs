namespace DbStorageContext
{
    internal static class DataGeneration
    {
        private const double MaxValueOfParametrOfPallet = 300;
        private static List<Pallet> Pallets=new List<Pallet>();
        private const int numberOfPallets = 10;
        private const int numberOfBoxes = 50;

        private static Random rdm = new Random();
        public static List<Pallet> GeneratePallets()
        {
            var pallets= new List<Pallet>();
            for (int palletId = 1; palletId < numberOfPallets; palletId++)
            {
                Pallet pallet = new Pallet(
                    palletId,
                    (decimal)(rdm.NextDouble() * MaxValueOfParametrOfPallet),
                    (decimal)(rdm.NextDouble() * MaxValueOfParametrOfPallet),
                    (decimal)(rdm.NextDouble() * MaxValueOfParametrOfPallet));
                pallets.Add(pallet);
            }
            Pallets = pallets;
            return pallets;
        }

        public static List<Box> GenerateBoxes()
        {
            var boxes = new List<Box>();
            Random rdm = new Random();
            for (int boxId = 0; boxId < numberOfBoxes; boxId++)
            {
                int palletId = rdm.Next(1, numberOfPallets);
                var pallet = Pallets[palletId-1];
                Box box = new Box(
                   palletId,
                   boxId + 1,
                   GenerateRandomDecimal(1,pallet.Height),
                   GenerateRandomDecimal(1, pallet.Width),
                   GenerateRandomDecimal(1, pallet.Depth),
                   GenerateRandomDecimal(1, pallet.Weight));
                if (boxId % 2 == 0)
                {
                    box.DateOfProdaction = (new DateOnly(2020, 10, 1)).AddDays(rdm.Next(730));
                }
                else
                {
                    box.ExpiryDate = (new DateOnly(2020, 10, 1)).AddDays(rdm.Next(730));
                }
                boxes.Add(box);
                //Pallets[palletId-1].Boxes.Add(box);
            }
            return boxes;
        }
        private static decimal GenerateRandomDecimal(decimal min,decimal max)
        {
            return (decimal)new Random().NextDouble() * (max - min) + min;
        }

    }
}
