using UnityEngine;

public class Generics : MonoBehaviour
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

public class SomeNewClass
{
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}

public class GenericClass<T>
{
    T item;
    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}

public class GenericClassExample : MonoBehaviour
{
    void Start()
    {
        GenericClass<int> intClass = new GenericClass<int>();
        intClass.UpdateItem(5);
        GenericClass<string> stringClass = new GenericClass<string>();
        stringClass.UpdateItem("Hello");
    }
}