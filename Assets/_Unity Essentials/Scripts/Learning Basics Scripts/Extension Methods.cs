using UnityEngine;

public class ExtensionMethods : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.ResetTransformation();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public static class ExtensionMethodsClass
{
   public static void ResetTransformation(this Transform transform)
   {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.identity;
        transform.localScale = new Vector3(1, 1, 1);
   }
}
