namespace Circus_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            Platform platform = new Platform();
            platform.AddTrain(new Train());
            platform.Train.FillTrain(platform.SpawnAnimals(10));


            DisplayWagons.Display(platform.Train.Wagons);
        }
    }
}
