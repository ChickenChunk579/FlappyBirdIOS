using UnityEngine;

public class Pipe : MonoBehaviour
{
    public GameObject topPipe; // Assign in inspector
    public GameObject bottomPipe; // Assign in inspector
    public float speed = 1.0f; // Speed of the pipes
    public Vector3 startPosition;
    public float endX;
    public float minY;
    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the pipes to the left
        transform.position += Vector3.left * speed * Time.deltaTime;

        // If the pipes have moved past a certain point, reset their position
        if (transform.position.x <= endX)
        {
            float randomY = Random.Range(minY, maxY);
            transform.position = new Vector3(startPosition.x, randomY, startPosition.z);
        }
    }
}
