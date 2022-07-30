namespace Animals;

public class TreeNode : IEquatable<TreeNode>
{
    public string Item { get; set; }
    public TreeNode? LeftLink { get; set; }
    public TreeNode? RightLink { get; set; }

    public TreeNode(string item)
        : this(item, null, null) { }

    public TreeNode(string item, TreeNode? left, TreeNode? right)
    {
        Item = item;
        LeftLink = left;
        RightLink = right;
    }

    public int Compare(string? obj)
    {
        return Item.CompareTo(obj);
    }

    public override string ToString()
    {
        return Item.ToString();
    }

    public bool Equals(TreeNode? other)
    {
        if (other == null)
        {
            return false;
        }
        if (LeftLink == other.LeftLink && RightLink == other.RightLink)
        {
            return true;
        }
        return false;
    }
}
