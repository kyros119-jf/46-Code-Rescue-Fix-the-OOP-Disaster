public class Player
{

    public Player (string name, int health, int experience)
    {
        Name = name;
        Health = health;
        Experience = experience;
    }

    public string Name { get; set; }
    public int Health { get; set; }
    public int Experience { get; set; }

    public void TakeDamage(int damageAmount)
    {
        Health -= damageAmount;
        
        if (Health < 0)
        {
            Health = 0;
        }

        Console.WriteLine("player took damage");
    }


    public void AddExperience(int experienceAmount)
    {
        Experience += experienceAmount;
    }

    public void ShowStats()
    {
        Console.WriteLine($"{Name} hp:{Health} xp:{Experience}");
    }
}


// Reflection Questions:
//
// 1. Why are PascalCase names used for classes and methods?
// PascalCase follows C# naming conventions and makes classes and methods
// easier to recognize and read.
//
// 2. Why is code formatting important in large projects?
// Good formatting makes code easier to read, understand, and maintain,
// especially when multiple programmers work on the same project.