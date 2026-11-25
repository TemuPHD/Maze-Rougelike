using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamblemodeshow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Gamblemode.LETSGOGAMBLING == true)
        {
            gameObject.transform.position = new Vector3(-4.03f,5.65f,-43.62f);
        }
        else
        {
            gameObject.transform.position = new Vector3(-999,-999,-999);
        }
    }
}
