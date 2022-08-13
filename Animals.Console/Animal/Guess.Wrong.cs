namespace Animals;

partial class Guess
{
    public class Learn : Characteristic
    {
        public Learn(string animal, Characteristic yes, Characteristic no)
            : base(animal, yes, no) { }
    }
}