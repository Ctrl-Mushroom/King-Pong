using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPlayerMovement : MonoBehaviour
{
    private float speed;
    private float reAdjustSpeed = 10f;
    private Rigidbody2D computer2d;
    public static bool isTwoPlayer;
    GameObject theBall;
    public float boundY;
    Rigidbody2D rb2d;

    void Start()
    {
        computer2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTwoPlayer == false)
        {
            speed = 10f;


            if (theBall == null)
            {
                theBall = GameObject.FindGameObjectWithTag("Ball");
            }

            rb2d = theBall.GetComponent<Rigidbody2D>();

            //Is the ball going left or right
            if (rb2d.velocity.x > 0)
            {

                if (rb2d.velocity.y > 0)
                {
                    if (rb2d.position.y > computer2d.position.y)
                    {
                        MoveUp();
                        var pos = transform.position;
                        if (pos.y > boundY)
                        {
                            pos.y = boundY;
                        }
                        else if (pos.y < -boundY)
                        {
                            pos.y = -boundY;
                        }
                        transform.position = pos;
                    }

                    if (rb2d.position.y < computer2d.position.y)
                    {
                        MoveDown();
                        var pos = transform.position;
                        if (pos.y > boundY)
                        {
                            pos.y = boundY;
                        }
                        else if (pos.y < -boundY)
                        {
                            pos.y = -boundY;
                        }
                        transform.position = pos;
                    }
                }

                if (rb2d.velocity.y < 0)
                {
                    if (rb2d.position.y > computer2d.position.y)
                    {
                        MoveUp();
                        var pos = transform.position;
                        if (pos.y > boundY)
                        {
                            pos.y = boundY;
                        }
                        else if (pos.y < -boundY)
                        {
                            pos.y = -boundY;
                        }
                        transform.position = pos;
                    }
                    if (rb2d.position.y < computer2d.position.y)
                    {
                        MoveDown();
                        var pos = transform.position;
                        if (pos.y > boundY)
                        {
                            pos.y = boundY;
                        }
                        else if (pos.y < -boundY)
                        {
                            pos.y = -boundY;
                        }
                        transform.position = pos;
                    }
                }

            }

            if (rb2d.velocity.x < 0)
            {
                if (computer2d.position.y < 0)
                {
                    computer2d.position += Vector2.up * reAdjustSpeed * Time.deltaTime;
                }

                if (computer2d.position.y > 0)
                {
                    computer2d.position += Vector2.down * reAdjustSpeed * Time.deltaTime;
                }
            }
        }
    }
    void MoveDown()
    {
        if (Mathf.Abs(rb2d.velocity.y) > speed)
        {
            computer2d.position += Vector2.down * speed * Time.deltaTime;
        }
        else
        {
            computer2d.position += Vector2.down * speed * Time.deltaTime;
        }
    }

    void MoveUp()
    {
        if (Mathf.Abs(rb2d.velocity.y) > speed)
        {
            computer2d.position += Vector2.up * speed * Time.deltaTime;
        }
        else
        {
            computer2d.position += Vector2.up * speed * Time.deltaTime;
        }
    }
}
