namespace Animals;

public partial class Game
{
    private class NewGame
    {
        public TreeNode Root { get; set; }
        public TreeNode Current { get; set; }

        public NewGame(TreeNode root, TreeNode current)
        {
            Root = root;
            Current = current;
        }

        public string GetItem()
        {
            return Current.Item;
        }

        public bool Guess(TreeNode guess)
        {
            return guess.Equals(Current);
        }

        public NewGame NextRound(string answer)
        {
            switch (answer)
            {
                case "yes":
                    if (Guess(new Guess(answer, Current.LeftLink, Current.RightLink)))
                    {
                        return new(Root, Current.LeftLink);
                    }
                    break;
                case "no":
                    if (Guess(new Guess(answer, Current.LeftLink, Current.RightLink)))
                    {
                        return new(Root, Current.RightLink);
                    }
                    break;
            }
            throw new Exception("Error");
        }
    }
}
