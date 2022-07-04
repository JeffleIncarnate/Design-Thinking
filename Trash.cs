using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Text;

public class Trash : MonoBehaviour
{
    [SerializeField] private Text countDisplay;

    [SerializeField] public int count;

    // Update is called once per frame
    void Update()
    {
        StringBuilder text = new StringBuilder("Points: ");
        text.Append(Convert.ToString(count));

        countDisplay.text = Convert.ToString(text);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Trash")
        {
            ++count;
            Destroy(collider.gameObject);
        }
    }
}
