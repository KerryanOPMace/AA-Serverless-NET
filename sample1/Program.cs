namespace sample1;

class Program
{
    
    static void Main(string[] args)
    {
        Personne personne = new Personne("Jean", 42);
        Console.WriteLine(personne.Hello());
        Console.WriteLine(personne.Hello(false));
    }
}
