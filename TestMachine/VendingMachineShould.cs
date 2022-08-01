namespace TestMachine
{
    public class VendingMachineShould
    {
        [Fact]
        public void InsertMoneyTest()
        {
             
            {
                // Arrange 
                int value = 50;

                // Act 
                VendingMachine sut = new VendingMachine();

                sut.Insert(value);

                Assert.Equal(value, sut.amountOfMoneyInVendingMachine);


            }

        }
        [Fact]
        public void DidMachieReturnAllCoinsTest()
        {

            {
                // Arrange 
                int value = 1000;

                // Act 
                VendingMachine sut = new VendingMachine();

                sut.Insert(value);
                sut.EndTransaction();

                Assert.Equal(0, sut.amountOfMoneyInVendingMachine);


            }

        }
        [Fact]
        public void CheckValidDenomination()
        {
            int value = 10;
            VendingMachine sut = new VendingMachine();
            Assert.True(sut.CheckValidDenomination(value));

        }
    }
}