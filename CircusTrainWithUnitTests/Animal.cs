namespace CircusTrainWithUnitTests
{
    public class Animal
    {
        public FoodPreference FoodPreference { get; private set; }
        public Size Size { get; private set; }

        public Animal(Size size, FoodPreference foodPreference)
        {
            Size = size;
            FoodPreference = foodPreference;
        }
    }
}
