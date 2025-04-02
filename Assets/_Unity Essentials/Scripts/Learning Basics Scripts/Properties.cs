using UnityEngine;

public class Properties : MonoBehaviour
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

public class Player
{
    private string name { get; set; }
    private int health { get; set; }
    private int damage { get; set; }

    public Player(string _name, int _health, int _damage)
    {
        name = _name;
        health = _health;
        damage = _damage;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if(value.Length > 0)
            {
                name = value;
            }
        }
    }

    public int Health
    {
        get { return health; }
        set
        {
            if (value > 0)
            {
                health = value;
            }
        }
    }

    public int Damage
    {
        get { return damage; }
        set
        {
            if (value > 0)
            {
                damage = value;
            }
        }
    }
}