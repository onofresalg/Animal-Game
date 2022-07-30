namespace Animals;

public partial class Game
{
    public TreeNode node { get; set; }
    private NewGame _currentGame;

    public Game(TreeNode firstGuess)
    {
        node = firstGuess;
        Start();
    }

    public void Guess(string answer)
    {
        _currentGame.NextRound(answer);
    }

    public void Ready()
    {
        Console.WriteLine(_currentGame.GetItem());

        Guess(Console.ReadLine());

        Ready();
    }

    private void Start()
    {
        Console.WriteLine("Think in an animal to start the game");

        _currentGame = new NewGame(node, node);

        Console.WriteLine("...");

        Ready();
    }
}