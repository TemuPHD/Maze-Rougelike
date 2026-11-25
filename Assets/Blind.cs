using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blind : MonoBehaviour
{
    public static bool blindexist = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Blind.blindexist = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(alilfunnytile.funnyexist == true)
        {
            if(Blind.blindexist == true)
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
        if(Blind.blindexist == false)
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
            Blind.blindexist = false;
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
        }
        else
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
    }
}
