namespace Animals;

public partial class Guess
{
    public class Wrong : TreeNode
    {
        public Wrong(string guess, TreeNode yes, TreeNode no)
            : base(guess, yes, no) { }
    }
}