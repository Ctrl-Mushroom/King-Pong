using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Multiverse : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (Input.GetKey(KeyCode.LeftAlt))
            {
                if (Input.GetKey(KeyCode.X))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
                    GetComponent<AudioSource>().Play();
                }
            }
        }
        if (Input.GetKey(KeyCode.RightControl))
        {
            if (Input.GetKey(KeyCode.RightAlt))
            {
                if (Input.GetKey(KeyCode.X))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
                    GetComponent<AudioSource>().Play();
                }
            }
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (Input.GetKey(KeyCode.RightAlt))
            {
                if (Input.GetKey(KeyCode.X))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
                    GetComponent<AudioSource>().Play();
                }
            }
        }
        if (Input.GetKey(KeyCode.RightControl))
        {
            if (Input.GetKey(KeyCode.LeftAlt))
            {
                if (Input.GetKey(KeyCode.X))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
                    GetComponent<AudioSource>().Play();
                }
            }
        }
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            if (Input.GetKey(KeyCode.B))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 15);
            }
        }
        if (Input.GetKey(KeyCode.RightAlt))
        {
            if (Input.GetKey(KeyCode.B))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 15);
            }
        }
    }
}
