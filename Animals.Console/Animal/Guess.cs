namespace Animals;

partial class Guess : Characteristic
{
    public string Animal { get; set; }

    public Guess(string guess, Characteristic? correct, Characteristic? wrong)
        : base(string.Empty, correct, wrong)
    {
        Animal = guess;
    }

    public int Compare(string? obj)
    {
        return Animal.CompareTo(obj);
    }
}
