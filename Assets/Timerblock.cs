using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timerblock : MonoBehaviour
{
    private float timersize;
    public static bool FAIL = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(-13.71f,1.48f,-999);
        gameObject.transform.localScale = new Vector3(0.32134f,10,1);
    }

    // Update is called once per frame
    void Update()
    {
        timersize = transform.localScale.y;
        if(Timerbane.Timer == true)
        {
            gameObject.transform.position = new Vector3(-13.71f,1.48f,-0.68f);
        }
        else
        {
          gameObject.transform.position = new Vector3(-13.71f,1.48f,-999);
        gameObject.transform.localScale = new Vector3(0.32134f,10,1);  
        }
        if(Player.inshop == true)
        {
           gameObject.transform.localScale = new Vector3(0.32134f,10,1);
        }
        if(Player.inshop == false)
        {
            if(Pathcreate.pathdone == true){
            timersize = transform.localScale.y;
            gameObject.transform.localScale = new Vector3(0.32134f,timersize-0.0035f-Timershrink.Timespeed,1);
            if(gameObject.transform.localScale.y <= 0)
            {
                Timerblock.FAIL = true;
            }
            }
        }
    }
}
