using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
    public Image cooldown;
    public bool coolingDown;
    public float waitTime;

    void Start()
    {
        StartCoroutine(loadSceneAfterDelay(4));
    }

    void Update()
    {
        if (coolingDown == true)
        {
            //Reduce fill amount over 30 seconds
            cooldown.fillAmount += 1.0f / waitTime * Time.deltaTime;
        }
    }

    IEnumerator loadSceneAfterDelay(float waitbySecs)
    {
        yield return new WaitForSeconds(waitbySecs);
        SceneManager.LoadScene(7);
    }
}
