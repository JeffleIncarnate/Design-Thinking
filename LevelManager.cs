using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject challengesStart;
    [SerializeField] private GameObject completionParcour;
    [SerializeField] private GameObject completionPuzzle;
    [SerializeField] private GameObject completionMemory;
    [SerializeField] private GameObject completionTrash;

    public string currentStage = "None";

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "base1")
        {
            StartCoroutine(StageOne());
        }
        else if (col.gameObject.tag == "base2")
        {
            Debug.Log("Stage2 Complete!");
        }
        else if (col.gameObject.tag == "base3")
        {
            Debug.Log("Stage3 Complete!");
        }
        else if (col.gameObject.tag == "base4")
        {
            Debug.Log("Stage4 Complete!");
        }
    }

    private void Update()
    {
        if (Input.anyKey)
        {
            challengesStart.SetActive(false);
        }
    }

    private IEnumerator StageOne()
    {
        completionParcour.SetActive(true);
        yield return new WaitForSeconds(3);
        completionParcour.SetActive(false);
        currentStage = "Stage1";
    }
}