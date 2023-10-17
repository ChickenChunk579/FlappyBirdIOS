using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<BirdController>() != null)
        {
            SFXManager.instance.PointSFX();
            ScoreSetter.instance.AddPoint();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
