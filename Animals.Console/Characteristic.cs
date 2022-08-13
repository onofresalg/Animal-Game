namespace Animals;

class Characteristic : IEquatable<Characteristic>
{
    public string Description { get; set; }
    public Characteristic? Match { get; set; }
    public Characteristic? Wrong { get; set; }

    public Characteristic()
        : this(string.Empty, null, null) { }

    public Characteristic(string description, Characteristic? match, Characteristic? wrong)
        => (Description, Match, Wrong) = (description, match, wrong);

    public override string ToString()
    {
        return Description.ToString();
    }

    public bool Equals(Characteristic? characteristic)
    {
        if (characteristic == null)
        {
            return false;
        }
        if (Match == characteristic.Match && Wrong == characteristic.Wrong)
        {
            return true;
        }
        return false;
    }
}
