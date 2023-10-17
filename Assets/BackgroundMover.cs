using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    public float speed = 0.05f;

    public Vector3 startPosition;
    public float endX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the pipes to the left
        transform.position += Vector3.left * speed * Time.deltaTime;

        // If the pipes have moved past a certain point, reset their position
        if (transform.position.x <= endX)
        {
  
            transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z);
        }

    }
}
