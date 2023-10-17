using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    public float speed;
    public float force;
    public float rotationSpeed;
    private Rigidbody2D body;
    private float rotationZ;
    private bool crashed;
    public Collider2D collider;

    IEnumerator DieCoroutine()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }

    void Die()
    {
        SFXManager.instance.HitSFX();
        crashed = true;
        StartCoroutine(DieCoroutine());
    }

    void Start()
    {
        crashed = false;
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GetPlayerInput();
        RotateBird();

        /*
        if (!crashed && transform.position.y > -2.77)
        {
            print("Crash");
            crashed = true;
        }
        */
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Pipe") || collision.collider.CompareTag("Base"))
        {
            print("Crash with " + collision.collider.name);
            Die();
        }
        
    }

    private void GetPlayerInput()
    {
        if (!crashed)
        {
            if (Input.touchCount > 0)
            {
                print("touch");
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    SFXManager.instance.JumpSFX();
                    ImpulseBird();
                }
            }
            else if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                ImpulseBird();
            }
        } else
        {
            collider.enabled = false;
        }
        
    }

    private void ImpulseBird()
    {
        body.velocity = Vector2.up * force;
    }

    private void RotateBird()
    {
        if (body.velocity.y > 0)
        {
            rotationZ += Time.deltaTime * rotationSpeed;
        }
        else
        {
            rotationZ -= Time.deltaTime * (rotationSpeed * 0.8f);
        }

        if (Mathf.Abs(rotationZ) > 30)
        {
            rotationZ = rotationZ > 0 ? 30 : -30;
        }

        transform.rotation = Quaternion.Euler(0, 0, rotationZ);
    }
}