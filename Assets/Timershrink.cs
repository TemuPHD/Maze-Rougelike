using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timershrink : MonoBehaviour
{
    public static float Timespeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Timershrink.Timespeed = Timershrink.Timespeed + 0.001f;
        }
    }
    void Update()
    {
        if(KeyII.Key2 == true)
        {
            if(Timerbane.Choice1 == 2)
                {
                    gameObject.transform.position = new Vector3(-5.56f,3.8f,-18.63808f);
                    
                }
                else
                {
                    if(Timerbane.Choice2 == 2)
                    {
                        gameObject.transform.position = new Vector3(-5.56f,3.8f,-18.63808f);
                        
                    }
                    else
                    {
                        if(Timerbane.Choice3 == 2)
                        {
                            gameObject.transform.position = new Vector3(-5.56f,3.8f,-18.63808f);
                            
                        }
                        else
                        {
                            gameObject.transform.position = new Vector3(-5.56f,3.8f,-999f);
                        }
                    }
                }
        }
        else
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
    }
}
