using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imposterwall : MonoBehaviour
{
    public static bool Fakers = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            imposterwall.Fakers = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Swapwalls.Swappers == true)
        {
            if(imposterwall.Fakers == false)
        {
            if(Player.Wins > 1)
            {
                if(Timerbane.Choice1 == 4)
                {
                    gameObject.transform.position = new Vector3(5.56f,3.8f,-18.63808f);
                }
                else
                {
                    if(Timerbane.Choice2 == 4)
                    {
                        gameObject.transform.position = new Vector3(5.56f,3.8f,-18.63808f);
                    }
                    else
                    {
                        if(Timerbane.Choice3 == 4)
                        {
                            gameObject.transform.position = new Vector3(5.56f,3.8f,-18.63808f);
                        }
                        else
                        {
                            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
                        }
                    }
                }
            }
        }
        else
        {
            gameObject.transform.position = new Vector3(5.56f,3.8f,-999f);
        }
        }
        else
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
    }
}
