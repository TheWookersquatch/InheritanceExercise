using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var penguin = new Bird();
            penguin.BeakOrBill = "beak";
            penguin.EatingHabit = "carnivore";
            penguin.NestType = "rock nest";
            penguin.LocomotionType = "swims and walks";
            penguin.HasFeathers = true;

            Console.WriteLine($"A penguin is an animal.\n" +
                "It does breath and it does move. \n" +
                $"Like all birds, penguins have feathers and a baby a penguin is called a {penguin.BabyName}. \n" +
                $"Penguin {penguin.BabyName}s are incubated in the egg in a {penguin.NestType}. \n" +
                $"A penguin is a strange bird, because rather than flying it {penguin.LocomotionType}. \n" +
                $"A penguin has a {penguin.BeakOrBill} and is a {penguin.EatingHabit}.");
            Console.WriteLine("");
            var chameleon = new Reptile();
            chameleon.AwakeHabit = "diurnal";
            chameleon.BabyName = "hatchling";
            chameleon.EatingHabit = "insectavore";
            chameleon.NeedsUVB = true;
            chameleon.ReptileType = "lizard";

            Console.WriteLine($"A chameleon is an animal.\n" +
                "It does breath and it does move. \n" +
                $"A chameleon is a {chameleon.ReptileType}. \n" +
                $"Like all {chameleon.ReptileType}s, chameleons are cold blooded and a baby a chameleon is called a {chameleon.BabyName}. \n" +
                $"Chameleons are {chameleon.AwakeHabit} and, therefore, need UVB light to grow properly. \n" +              
                $"Chameleons are {chameleon.EatingHabit}s.");

            /* public bool IsColdBlooded { get; set; }
        public string AwakeHabit { get; set; }
        public bool NeedsUVB { get; set; }
        public string ReptileType { get; set; }*/


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
