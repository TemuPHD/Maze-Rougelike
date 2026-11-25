using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplexI : MonoBehaviour
{
    public static bool Tier1complex = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ComplexI.Tier1complex = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Player.Wins <= 1)
        {
           gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
        if(ComplexI.Tier1complex == true)
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
        if(ComplexI.Tier1complex == false)
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
}
