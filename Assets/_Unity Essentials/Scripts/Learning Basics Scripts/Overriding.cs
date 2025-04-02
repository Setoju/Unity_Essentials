using UnityEngine;

public class Overriding : MonoBehaviour
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

public class Vegetable
{
    public Vegetable()
    {
        Debug.Log("1st Vegetable constructor called");
    }

    public virtual void Chop()
    {
        Debug.Log("The vegetable has been chopped.");
    }

    public virtual void SayHello()
    {

       Debug.Log("Hello, I am a vegetable.");
    }
}

public class Tomato : Vegetable
{
    public Tomato()
    {
        Debug.Log("1st Tomato constructor called");
    }

    public override void Chop()
    {
        Debug.Log("The tomato has been chopped.");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am a tomato.");
    }
}

public class Salad : MonoBehaviour
{

   void Start()
    {
        Vegetable vegetable = new Vegetable();
        Tomato tomato = new Tomato();

        vegetable.Chop();
        vegetable.SayHello();
        tomato.Chop();
        tomato.SayHello();
    }
}