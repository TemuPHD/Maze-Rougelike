using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timertextmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(0.79f,3.8f,-19.33f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.Wins > 1)
        {
            gameObject.transform.position = new Vector3(-0.94f,3.8f,-999f);
        }
        if(Player.Wins <= 1)
        {
            gameObject.transform.position = new Vector3(0.79f,3.8f,-19.33f);
        }
    }
}
