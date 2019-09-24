using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace CircusTrainWithUnitTests.Test
{    
    public class SeperateBigCarnivoresTests
    {
        [Fact]
        public void Seperate_ShouldPutZeroBigCarnivoresInSeperateWagons()
        {
            // Big carnivores: Food preference = 1, size = 5

            // Arrange
            List<Animal> animals = new List<Animal>();
            SeperateBigCarnivores BigCarnivores = new SeperateBigCarnivores();
            List<Wagon> expected = new List<Wagon>();

            // Act
            List<Wagon> result = BigCarnivores.Seperate(animals);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Seperate_ShouldPutOneBigCarnivoresInOneSeperateWagon()
        {
            // Big carnivores: Food preference = 1, size = 5

            // Arrange
            List<Wagon> expected = new List<Wagon>();
            expected.Add(new Wagon());
            expected[0].AddAnimal(new Animal(5, 1));
            
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(5, 1));

            SeperateBigCarnivores BigCarnivores = new SeperateBigCarnivores();

            // Act
            List<Wagon> result = BigCarnivores.Seperate(animals);

            // Assert
            expected.Should().BeEquivalentTo(result);
        }

        [Fact]
        public void Seperate_ShouldPutMultipleBigCarnivoresInMultipleSeperateWagon()
        {
            // Big carnivores: Food preference = 1, size = 5

            // Arrange
            List<Wagon> expected = new List<Wagon>()
            {
                new Wagon(),
                new Wagon(),
                new Wagon()
            };

            foreach (Wagon wagon in expected)
            {
                wagon.AddAnimal(new Animal(5, 1));
            }

            List<Animal> animals = new List<Animal>()
            {
                new Animal(5,1),
                new Animal(3, 1),
                new Animal(5, 0),
                new Animal(1,1),
                new Animal(5, 1),
                new Animal(1, 0),
                new Animal(3, 0),
                new Animal(5, 1)
            };

            SeperateBigCarnivores BigCarnivores = new SeperateBigCarnivores();

            // Act
            List<Wagon> result = BigCarnivores.Seperate(animals);

            // Assert
            expected.Should().BeEquivalentTo(result);
        }
    }
}
