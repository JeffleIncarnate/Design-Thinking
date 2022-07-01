using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject intro;
    public GameObject prophacy;
    public GameObject you;

    private int i = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            i++;
        }

        if (i == 0)
        {
            intro.SetActive(true);
        }
        else if (i == 1)
        {
            intro.SetActive(false);
            prophacy.SetActive(true);
        }
        else if (i == 2)
        {
            prophacy.SetActive(false);
            you.SetActive(true);
        }
        else if (i == 3)
        {
            SceneManager.LoadScene(1);
        }
    }
}
