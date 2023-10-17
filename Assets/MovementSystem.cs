using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : MonoBehaviour
{
    int position = 0;
    public float speed = 2;

    public void MoveLeft()
    {
        print("Hi");
        if (position != -1)
        {
            position -= 1;
            Move(Vector3.left);
        }
    }

    public void MoveRight()
    {
        print("Hi");

        if (position != 1)
        {
            position += 1;
            Move(Vector3.right);
        }
    }

    public void Move(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
