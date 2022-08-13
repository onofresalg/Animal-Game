namespace Animals;

public partial class Game
{
    private Characteristic _animalCharacteristic;

    public Game(string description, string correctAnimal, string wrongAnimal)
    {
        Characteristic correct = new Guess(correctAnimal, new Guess.Right(), Learn());
        Characteristic wrong = new Guess(wrongAnimal, new Guess.Right(), Learn());

        _animalCharacteristic = new Characteristic(description, correct, wrong);
    }

    public string Ready()
    {
        return "Think in an animal to start the game...";
    }

    public string Start()
    {
        return FirstQuestion();
    }
}