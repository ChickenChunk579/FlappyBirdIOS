using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageController : MonoBehaviour
{
    public GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            print("touch");
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                GetComponent<UnityEngine.UI.Image>().enabled = false;
                BirdController controller = FindObjectOfType<BirdController>();
                controller.enabled = true;
                controller.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;

                FindObjectOfType<Pipe>().enabled = true;

                score.SetActive(true);
            }
        }

    }
}
