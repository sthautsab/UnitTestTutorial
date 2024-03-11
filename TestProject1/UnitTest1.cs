namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GetCarName()
        {
            //Arrange
            Random rand = new Random();
            var expectedCarName = "XUV 500";


            //Act
            var result = rand.CarName("XUV 500");

            //Assert
            Assert.Equal(expectedCarName, result);



        }
    }
}