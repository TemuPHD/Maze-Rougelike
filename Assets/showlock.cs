using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showlock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(keyI.Key1 == true)
        {
            if(keyposition.unlocked == true)
            {
                if(KeyII.Key2 == true)
                {
                 if(Keypostion2.unlocked2 == true)
                    {
                        gameObject.transform.position = new Vector3(-999,9,-999);
                    }
                    else
                    {
                        gameObject.transform.position = new Vector3(Exitlocation.eXit,Exitlocation.eYit,0);
                    }
                }
                else
                gameObject.transform.position = new Vector3(-999,9,-999);
            }
            else
            {
                gameObject.transform.position = new Vector3(Exitlocation.eXit,Exitlocation.eYit,0);
            }
        }
        else
        {
            gameObject.transform.position = new Vector3(-999,9,-999);
        }
    }
}
