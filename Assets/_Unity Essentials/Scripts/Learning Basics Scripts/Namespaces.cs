using UnityEngine;
using System;
// Two types with the same name from different namespaces, so we specify which one we want to use
using Random = UnityEngine.Random;

// Nested namespaces
namespace EditorTools.MapCreation {    
    public class MapCreator
    {
        public void CreateMap()
        {
            Debug.Log("Creating map...");
        }
    }

    // Nested namespace type usage
    public class Inventory : MonoBehaviour
    {
        public System.Collections.ArrayList items;
    }

    public class Namespaces : MonoBehaviour
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
}
