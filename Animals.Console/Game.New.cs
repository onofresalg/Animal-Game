namespace Animals;

public partial class Game
{
    private string FirstQuestion()
    {
        return _animalCharacteristic.Description;
    }

    private string PrepareQuestion()
    {
        Guess? guess;
        guess = _animalCharacteristic.Match as Guess;

        return $"Is the animal {guess?.Animal}";
    }

    public string PrepareRound()
    {
        return PrepareQuestion();
    }

    public string NextRound(char? answer)
    {
        switch (answer)
        {
            case 'y':
                return PrepareQuestion();
            case 'n':
                return PrepareQuestion();
        }
        throw new Exception("Error");
    }

    private Characteristic Learn()
    {
        /*
         * Animal novo
         * Caract. -> Sim
         * Caract. Sim Ant. -> Não
         */


        return new Characteristic();
    }

}
