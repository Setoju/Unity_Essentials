using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float floatSpeed = 2f;      // Speed of the up/down movement
    public float floatHeight = 0.05f;   // Maximum height of the float
    private Vector3 startPosition;
    public GameObject onCollectEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float yOffset = Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        // Apply the offset to the initial position
        transform.position = startPosition + new Vector3(0f, yOffset, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);

            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
    }
}
