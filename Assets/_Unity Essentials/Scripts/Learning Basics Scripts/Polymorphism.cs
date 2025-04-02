using System;
using UnityEngine;

public class Polymorphism : MonoBehaviour
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

public class PetShop : MonoBehaviour
{
    [SerializeReference]
    public Mammal mammal = new Cat();
}

public class Animal { }

[Serializable]
public class Mammal : Animal { }

public class Cat : Mammal { }