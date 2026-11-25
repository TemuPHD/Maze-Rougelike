using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alilfunnytile : MonoBehaviour
{
    public static bool funnyexist;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            alilfunnytile.funnyexist = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(ice.Iceexist == true)
        {
            if(alilfunnytile.funnyexist == true)
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
        if(alilfunnytile.funnyexist == false)
        {
            if(Player.Wins > 1)
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
        }
        if(Timerblock.FAIL == true)
        {
            alilfunnytile.funnyexist = false;
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
        }
    }
}
