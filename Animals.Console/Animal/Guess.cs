namespace Animals;

public partial class Guess : TreeNode
{
    public Guess(string guess, TreeNode? yes, TreeNode? no)
        : base(guess, yes, no) { }
}
