using Xunit;

namespace CircusTrainWithUnitTests.Test
{
    public class TrainTests
    {
        [Fact]
        public void AddWagon_ShouldAddOneWagonToListAndCountWagon()
        {
            // Arrange
            int expected = 1;
            Train train = new Train();
            Wagon wagon = new Wagon();
            
            // Act
            train.AddWagon(wagon);
            int result = train.Wagons.Count;

            // Assert
            Assert.Equal(expected, result);
            Assert.Equal(wagon, train.Wagons[0]);
        }
    }
}
