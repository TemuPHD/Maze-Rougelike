using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fyi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Pathcreate.pathdone == true)
        {
            if(Player.BlindMe == true)
            {
                gameObject.transform.position = new Vector3(0.35f,1.78f,-7.9f);
            }
            else
            {
                gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
            }
        }
        else
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
    }
}
