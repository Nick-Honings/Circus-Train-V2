﻿using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace CircusTrainWithUnitTests.Test
{
    public class TrainTests
    {
        #region Setup
        Train train;
        Wagon wagon;
        Wagon emptyWagon;

        public TrainTests()
        {
            train = new Train();
            wagon = new Wagon();
        }

        #endregion

        #region AddWagon Tests
        [Fact]
        public void AddWagon_ShouldAddOneWagonToListAndCountWagon()
        {
            // Arrange
            int expected = 1;
            
            // Act
            train.AddWagon(wagon);
            int result = train.Wagons.Count;

            // Assert
            Assert.Equal(expected, result);
            Assert.Equal(wagon, train.Wagons[0]);
        }

        [Fact]
        public void AddWagon_ShouldNotAddEmptyClass()
        {
            // Arrange
            int expected = 0;

            // Act
            train.AddWagon(emptyWagon);
            int result = train.Wagons.Count;

            //Assert
            Assert.Equal(expected, result);
        }
        #endregion

        #region DistributeAnimals: Data driven tests
        /// <summary>
        /// IEnumberable object to inject sets of data in theory method.
        /// </summary>
        
        [Theory]
        [ClassData(typeof(TrainTestData))]

        public void DistributeAnimals_ShouldMatch(List<Animal> animals, List<Wagon> expected)
        {
            // Arrange

            // Act
            train.DistributeAnimals(animals);
            var result = train.Wagons;

            // Assert
            expected.Should().BeEquivalentTo(result);            
        }

        #endregion

    }
}
