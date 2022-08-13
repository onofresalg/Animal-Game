namespace Animals;

class Program
{
    static void Main(string[] args)
    {
        var game = new Game("Does the animal bark?", "Dog", "Cat");

        Console.WriteLine(game.Ready());

        Console.WriteLine(game.Start());

        Console.WriteLine(game.PrepareRound());

        char option = Console.ReadKey().KeyChar;

        game.NextRound(option);
    }
}