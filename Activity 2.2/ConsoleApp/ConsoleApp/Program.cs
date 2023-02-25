namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal beast = new Animal();

            //beast.Talk();
            //beast.Greet();
            //beast.Sing();

            Dog bowser = new Dog();

            bowser.Talk();
            bowser.Greet();
            bowser.Sing();
            bowser.Fetch("stick");
            bowser.FeedMe();
            bowser.TouchMe();


            Robin red = new Robin();

            red.Talk();
            red.Greet();
            //red.Fetch("worm");
            //red.FeedMe();
            //red.TouchMe();



            // My three new types of animals:

            Horse horse = new Horse();
            horse.RideMe();
            horse.Sing();

            Donkey donkey = new Donkey();
            donkey.RideMe();
            donkey.Sing();

            Salmon salmon= new Salmon();
            salmon.Swim();
            salmon.Sing();

            Console.ReadLine();
        }





    }
}