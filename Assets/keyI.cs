using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyI : MonoBehaviour
{
    public static bool Key1 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            keyI.Key1 = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(ComplexII.Tier2complex == true)
        {
            if(keyI.Key1 == true)
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
        if(keyI.Key1 == false)
        {
            if(Player.Wins > 1)
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
        }
        }
        else
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
    }
}
