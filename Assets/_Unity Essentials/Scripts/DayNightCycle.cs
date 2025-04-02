using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [SerializeField]
    private float dayDuration = 60f; // Seconds for a full day cycle

    private float rotationSpeed;

    void Start()
    {
        // Calculate rotation speed (360 degrees per full day cycle)
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Rotate the directional light based on time
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
