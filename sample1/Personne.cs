namespace sample1;

public class Personne
{
    public string Nom { get; set; }
    public int Age { get; set; }

    public string Hello(bool isLowerCase = true) {
        if (!isLowerCase)
        {
            return $"Hello {Nom}, you are {Age} years old".ToUpper();
        }
        else
        {
            return $"Hello {Nom}, you are {Age} years old".ToLower();
        }
    }

    public Personne(string nom, int age)
    {
        Nom = nom;
        Age = age;
    }
}