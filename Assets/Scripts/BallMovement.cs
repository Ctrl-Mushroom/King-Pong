using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb2d;
    public bool Ghost;
    public Rigidbody2D refernceball;
    private bool deleteGhosts;
    public bool PowerUppable = false;
    void Update()
    {
        if (GameManager.PlayerScore1 == 10 || GameManager.PlayerScore2 == 10)
        {
            PowerUppable = false;
        }
        if (AIGameManager.PlayerScore1 == 10 || AIGameManager.PlayerScore2 == 10)
        {
            PowerUppable = false;
        }
        if (SquadGameManager.PlayerScore1 == 0 || SquadGameManager.PlayerScore2 == 0 || SquadGameManager.PlayerScore3 == 0 || SquadGameManager.PlayerScore4 == 0)
        {
            PowerUppable = false;
        }
        if (TagTeamGameManager.PlayerScore1 == 10 || TagTeamGameManager.PlayerScore2 == 10)
        {
            PowerUppable = false;
        }
        if (GameManager.PlayerScore1 > 10)
        {
            GameManager.PlayerScore1 = 10;
        }
        if (GameManager.PlayerScore2 > 10)
        {
            GameManager.PlayerScore2 = 10;
        }
    }
    void GoBall()
    {
        PowerUppable = true;
        if (Ghost == false)
        {
            float rand = Random.Range(1, 5);
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
    }

    void Start()
    {
        GetComponent<AudioSource>();
        rb2d = GetComponent<Rigidbody2D>();

        if (Ghost == false)
        {
            refernceball = null;
            Invoke("GoBall", 2);
        }
        else
        {
            refernceball = GameObject.Find("Ball").GetComponent<Rigidbody2D>();
            Invoke("Followball", 0.0001f);
        }
    }

    void ResetBall()
    {
        if (Ghost == false)
        {

            rb2d.velocity = new Vector2(0, 0);
            transform.position = Vector2.zero;
        }
    }

    void Followball()
    {
        rb2d.velocity = (new Vector2(refernceball.velocity.x * Random.Range(0.8f, 1.2f), refernceball.velocity.y * Random.Range(0.8f, 1.2f)));
        CancelInvoke("Followball");
    }
    void RestartGame()
    {
        PowerUppable = false;
        ResetBall();
        Invoke("GoBall", 2);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = rb2d.velocity.x + 1;
            vel.y = ((rb2d.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f)) + 1f;


            if (Mathf.Abs(vel.x) < 15f)
            {
                vel.x = (vel.x / Mathf.Abs(vel.x)) * 15f;
            }
            if (Mathf.Abs(vel.y) < 2f)
            {
                vel.y = (vel.y / Mathf.Abs(vel.y)) * 2f;
            }
            rb2d.velocity = vel;
            Debug.Log(vel);

        }
        if (coll.collider.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
        }
        if (coll.collider.CompareTag("Wall"))
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
