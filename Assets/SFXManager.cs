using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip jump;

    [SerializeField]
    private AudioClip hit;

    [SerializeField]
    private AudioClip point;

    [SerializeField]
    private AudioSource source;

    public static SFXManager instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    public void JumpSFX()
    {
        source.PlayOneShot(jump);
    }

    public void HitSFX()
    {
        source.PlayOneShot(hit);
    }

    public void PointSFX()
    {
        source.PlayOneShot(point);
    }
}
