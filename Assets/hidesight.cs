using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidesight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Pathcreate.pathdone == true)
        {
            if(Player.BlindMe == false)
            gameObject.transform.position = new Vector3(-13.7f,0,-99);
            else
            gameObject.transform.position = new Vector3(-13.7f,0,-2.6f);
        }
        else
        {
            gameObject.transform.position = new Vector3(-13.7f,0,-2.6f);
        }
    }
}
