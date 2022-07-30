namespace Animals;

class Program
{
    static void Main(string[] args)
    {
        Guess yes = new("Is the animal a dog?", new Guess.Right(), null);
        Guess no = new("Is the animal a cat?", new Guess.Wrong("Sorry", null, null), null);

        Characteristic newCharacteristic = new("Does the animal bark?", yes, no);
        var game = new Game(newCharacteristic);

        Console.ReadKey();
    }
}