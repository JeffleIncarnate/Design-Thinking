using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private LevelManager manager;

    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y <= -10)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        if (manager.currentStage == "None")
        {
            transform.position = new Vector3(0f, 0f, 0f);
        }
        else if (manager.currentStage == "Stage1")
        {
            transform.position = new Vector3(100f, 1f, 0f);
        }
    }
}
