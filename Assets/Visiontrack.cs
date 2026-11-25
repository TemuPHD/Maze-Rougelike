using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visiontrack : MonoBehaviour
{
    public static float camlock = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(0,1,-14);
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.inshop == true)
        {
            if(Visiontrack.camlock == 0)
            {
                gameObject.transform.position = new Vector3(0,1,-34);
                Visiontrack.camlock = 1;
            }
        }
       if(Player.inshop == false)
        {
            if(Visiontrack.camlock == 1)
            {
                gameObject.transform.position = new Vector3(0,1,-14);
                Visiontrack.camlock = 0;
            }
        }
        if(Visiontrack.camlock == 2)
                {
                    gameObject.transform.position = new Vector3(0,1,-59);
                }
    }
}
