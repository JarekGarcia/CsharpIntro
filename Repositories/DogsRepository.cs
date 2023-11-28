
namespace CsharpIntro.Repositories;

public class DogsRepository
{
    private List<Dog> _dogs;

    public DogsRepository()
    {
        _dogs = [
            new Dog(1, "Clubber", "Boxer", 12, "Brindle"),
                new Dog(2, "Mack", "Boxer", 8, "Fawn"),
                new Dog(3, "Toby", "Husky", 2, "White and Black"),
                new Dog(4, "Solo", "PitBull", 1, "Grey"),
            ];
    }
    internal List<Dog> GetDogs()
    {
        return _dogs;
    }
}
