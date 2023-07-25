
using FileStorageContext;
using BusinessLogic;

namespace Tests
{
    public class UnitTests
    {
        [Fact]
        public void AllBoxesLessThanPallet()
        {
            //arrange
            ApplicationContext db = new ApplicationContext();
            Calculations cal = new Calculations();
            //act
            foreach (var pallet in db.Pallets)
            {
                foreach (var box in pallet.Boxes)
                {
                    //assert
                    Assert.True((box.Width <= pallet.Width && box.Height <= pallet.Height) || (box.Height <= pallet.Width && box.Width <= pallet.Height));
                }
            }
        }
        [Fact]
        public void ExpiryDateOfPalletIsTheLeastExpiryDateOfBoxes()
        {
            //arrange
            ApplicationContext db = new ApplicationContext();
            Calculations cal = new Calculations();
            //act
            foreach (var pallet in db.Pallets)
            {
                DateOnly? TheLeastExpiryDateOfBoxes = pallet.Boxes.Min(p => p.ExpiryDate);
                //assert
                Assert.Equal(TheLeastExpiryDateOfBoxes, pallet.ExpiryDate);
            }
        }

        [Fact]
        public void IsSortingPalletsByExpiryDateWorkCorrectly()
        {
            //arrange
            ApplicationContext db = new ApplicationContext();
            Calculations cal = new Calculations();
            var myPallets = cal.SortPallets();
            //act
            DateOnly? prExpiryDate = DateOnly.MinValue;
            foreach (var groupOfPallet in myPallets)
            {
                Assert.True(groupOfPallet.Key > prExpiryDate);
                prExpiryDate = groupOfPallet.Key;

                decimal prWeight = 0;
                foreach (var pallet in groupOfPallet.Value)
                {
                    Assert.True(pallet.Weight > prWeight);
                    prWeight = pallet.Weight;
                }
            }
            //assert
            Assert.Equal(myPallets.SelectMany(x => x.Value).Count(), db.Pallets.Select(x => x.ExpiryDate).Distinct().Count());
        }

        [Fact]
        public void GetThreePalletsWithHighestExpiryDateWorksCorrectly()
        {
            //arrange
            ApplicationContext db = new ApplicationContext();
            Calculations cal = new Calculations();
            var myPallets = cal.GetThreePalletsWithHighestExpiryDate();
            var pallets = db.Pallets;
            var expectedResult = new List<DateOnly?>();
            //act
            foreach(var pallet in pallets)
            {
                var sortedBoxes = pallet.Boxes.Max(b => b.ExpiryDate);
                expectedResult.Add(sortedBoxes);
            }
            expectedResult.Sort();
            expectedResult.Reverse();
            expectedResult = expectedResult.Take(3).ToList();
            for(int i = 0; i < 3; i++)
            {
                Assert.Equal(expectedResult[i], myPallets[i].Boxes.Max(b=>b.ExpiryDate));
            }
            foreach (var pallet in myPallets)
            {
                decimal prVolume = 0.0M;
                foreach(var box in pallet.Boxes)
                {
                    Assert.True(box.Volume>prVolume);
                    prVolume = box.Volume;
                }
            }
            //assert
            Assert.Equal(myPallets.Count,3);
        }

    }
}