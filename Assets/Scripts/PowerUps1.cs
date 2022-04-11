using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps1 : MonoBehaviour
{
    
    private bool powerUp;
    private float timer;
    private int Powerupss;
    public GameObject player1;
    public GameObject player2;
    public GameObject GhostBall;
    public Transform Referenceposition;
    public int GhostNum;
    public float PowerUpInterval;
    public float shortDuration;
    public float stunDuration;
    private BallMovement ballmove;
    // Start is called before the first frame update
    void Start()
    {
        ballmove = GameObject.Find("Ball").GetComponent<BallMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
            InvokeRepeating("PowerUppers", 2f, 2f);
    }
    void PowerUppers()
    {
        if (ballmove.PowerUppable == true)
        {

            Powerupss = Random.Range(0, 3);
            switch (Powerupss)
            {
                case (0): StartCoroutine(Stun()); Debug.Log("Stun"); break;
                case (1): StartCoroutine(Shorten()); Debug.Log("Shorten"); break;
                case (2): StartCoroutine(Multiply()); Debug.Log("Multiply"); break;
            }

        }

        CancelInvoke();
    }
    IEnumerator Stun()
    {
        player1.GetComponent<PlayerMovement>().enabled = false;
        player2.GetComponent<PlayerMovement>().enabled = false;
        yield return new WaitForSeconds(stunDuration);
        player1.GetComponent<PlayerMovement>().enabled = true;
        player2.GetComponent<PlayerMovement>().enabled = true;
    }
    IEnumerator Shorten()
    {
        player1.transform.localScale = new Vector3(1f, 0.40f, 1f);
        player2.transform.localScale = new Vector3(1f, 0.40f, 1f);
        yield return new WaitForSeconds(shortDuration);
        player1.transform.localScale = new Vector3(1f, 0.7054508f, 1f);
        player2.transform.localScale = new Vector3(1f, 0.7054508f, 1f);
    }
    IEnumerator Multiply()
    {
        
        for (int i = 1; i<= GhostNum;i++)
        {
            GameObject ghost1 = (GameObject)Instantiate(GhostBall);
            ghost1.transform.position = Referenceposition.transform.position;
            ghost1.name = "Ghostball" + i;
        }
        yield return new WaitForSeconds(1f);
    }
}
