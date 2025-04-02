using UnityEngine;

public class Statics : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Opponent
{
    // static variables are shared across all instances of a class
    public static int enemyCount = 0;

    public Opponent()
    {
        enemyCount++;
    }
}

public class Game
{
    void start()
    {
        Opponent enemy1 = new Opponent();
        Opponent enemy2 = new Opponent();
        Opponent enemy3 = new Opponent();

        // accessing static variables
        int x = Opponent.enemyCount;
    }
}

// static classes can't be instantiated
public static class Utilities
{
    // static methods cannot acess non-static variables
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}

public class UtilitiesExample : MonoBehaviour
{
    void Start()
    {
        int sum = Utilities.Add(3, 5);
    }
}