using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilechanceup : MonoBehaviour
{
    public static float floorchance = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
    }

private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            tilechanceup.floorchance = tilechanceup.floorchance + 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Blind.blindexist == true)
        {
            if(Timerbane.Choice1 == 1)
                {
                    gameObject.transform.position = new Vector3(-10.56f,3.8f,-18.63808f);
                }
                else
                {
                    if(Timerbane.Choice2 == 1)
                    {
                        gameObject.transform.position = new Vector3(-10.56f,3.8f,-18.63808f);
                    }
                    else
                    {
                        if(Timerbane.Choice3 == 1)
                        {
                            gameObject.transform.position = new Vector3(-10.56f,3.8f,-18.63808f);
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
