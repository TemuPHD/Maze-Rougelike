using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mud : MonoBehaviour
{
    public static bool Mudexist = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
    }

private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Mud.Mudexist = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Player.Wins <= 1)
        {
           gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
        if(Mud.Mudexist == true)
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
        if(Mud.Mudexist == false)
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
            Mud.Mudexist = false;
        }
    }
}
