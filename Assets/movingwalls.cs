using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingwalls : MonoBehaviour
{
    public static bool movers = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            movingwalls.movers = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(imposterwall.Fakers == true)
        {
            if(movingwalls.movers == false)
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
