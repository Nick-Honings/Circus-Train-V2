using Xunit;

namespace CircusTrainWithUnitTests.Test
{

    public class PlatformTests
    {
        #region Setup
        Platform platform;
        Train train;
        
        public PlatformTests()
        {
            platform = new Platform();
            train = new Train();
        }
        #endregion

        #region SpawnAnimals Tests
        [Fact]
        public void SpawnAnimals_ShouldSpawnZeroAnimals()
        {
            // Arrange
            int expected = 0;

            // Act
            int actual = platform.Spawnanimals(0).Count;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SpawnAnimals_ShouldSpawnOneAnimals()
        {
            // Arrange
            int expected = 1;

            // Act
            int actual = platform.Spawnanimals(1).Count;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SpawnAnimals_ShouldSpawnMultipleAnimals()
        {
            // Arrange
            int expected = 5;

            // Act
            int actual = platform.Spawnanimals(5).Count;

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region AddTrain Tests

        [Fact]
        public void AddTrain_ShouldAddTrain()
        {
            // Arrange            

            // Act
            platform.AddTrain(train);

            // Assert
            Assert.NotNull(platform.Train);
            Assert.Equal(train, platform.Train);
        }

        [Fact]
        public void AddTrain_ShouldNotAddTrain()
        {
            // Arrange
            Train train2 = new Train();
            platform.AddTrain(train);

            // Act
            platform.AddTrain(train2);

            // Assert
            Assert.Equal(train, platform.Train);
        }
        #endregion
    }
}
