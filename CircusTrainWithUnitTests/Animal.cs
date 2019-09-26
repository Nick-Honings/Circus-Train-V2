namespace CircusTrainWithUnitTests
{
    public class Animal
    {
        public FoodPreference FoodPreference { get; set; }
        public Size Size { get; set; }

        public Animal(Size size, FoodPreference foodPreference)
        {
            Size = size;
            FoodPreference = foodPreference;
        }
    }
}
