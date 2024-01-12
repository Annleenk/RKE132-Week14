Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);
Dog friendsDog = new Dog("Rax"); //objects


Console.WriteLine($"My dogs name is {myDog.Name}");
Console.WriteLine($"My friends dogs name is {friendsDog.Name}");
//Console.WriteLine($"Oh no! {myDog.Name} bit {friendsDog.Name}!");
//myDog.Rename("Bad Rix");


while(myDog.LevelOfHappiness != 3)
{
    myDog.Bark();
}

myDog.WagTail();
Console.WriteLine($"{myDog.Name} is happy!");
class Dog
{
    private string _name; //field
    private int _levelOfHappiness;

    //constructor
    public Dog(string name) // name - laseb nime sisestada
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    //getter

    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHappiness
    {
        get { return _levelOfHappiness;}
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }
}
