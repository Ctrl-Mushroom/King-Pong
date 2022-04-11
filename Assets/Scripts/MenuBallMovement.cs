using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBallMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;

    void GoBall()
    {
        float rand = Random.Range(1, 4);
        if (rand == 1)
        {
            rb2d.AddForce(new Vector2(20, -15) * speed);
        }
        else if (rand == 2)
        {
            rb2d.AddForce(new Vector2(-20, -15) * speed);
        }
        else if (rand == 3)
        {
            rb2d.AddForce(new Vector2(20, 15) * speed);
        }
        else if (rand == 4)
        {
            rb2d.AddForce(new Vector2(-20, 15) * speed);
        }
    }

    void Start()
    {
        GetComponent<AudioSource>();
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 1);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Wall"))
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
