using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallchance : MonoBehaviour
{
    public static float Wallodds = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(5.56f,3.8f,-999f);
    }

private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wallchance.Wallodds = wallchance.Wallodds + 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Lethalwalls.Fatality == true)
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
}
