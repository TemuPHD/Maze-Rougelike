using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clonemean : MonoBehaviour
{
    public static bool Cruelclone = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Clonemean.Cruelclone = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
       if(Player.Wins <= 1)
        {
           gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
        if(Clonemean.Cruelclone == false)
        {
            if(Player.Wins > 1)
            {
                if(Timerbane.Choice1 == 5)
                {
                    gameObject.transform.position = new Vector3(10.56f,3.8f,-18.63808f);
                }
                else
                {
                    if(Timerbane.Choice2 == 5)
                    {
                        gameObject.transform.position = new Vector3(10.56f,3.8f,-18.63808f);
                    }
                    else
                    {
                        if(Timerbane.Choice3 == 5)
                        {
                            gameObject.transform.position = new Vector3(10.56f,3.8f,-18.63808f);
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
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }  
    }
}
