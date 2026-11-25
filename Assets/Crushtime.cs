using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crushtime : MonoBehaviour
{
    public static float crushtime;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Crushtime.crushtime = Crushtime.crushtime + 0.025f;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(thebigone.bossasscrusher == true)
        {
            if(Timerbane.Choice1 == 3)
                {
                    gameObject.transform.position = new Vector3(-0.56f,3.8f,-18.63808f);
                    
                }
                else
                {
                    if(Timerbane.Choice2 == 3)
                    {
                        gameObject.transform.position = new Vector3(-0.56f,3.8f,-18.63808f);
                        
                    }
                    else
                    {
                        if(Timerbane.Choice3 == 3)
                        {
                            gameObject.transform.position = new Vector3(-0.56f,3.8f,-18.63808f);
                            
                        }
                        else
                        {
                            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
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
