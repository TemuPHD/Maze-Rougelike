using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timerbane : MonoBehaviour
{
    public static bool Timer = false;
    public static float Choice1;
    public static float Choice2;
    public static float Choice3;
    private bool select1 = false;
    private bool Banelock = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(-0.94f,3.8f,-18.63808f);
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Timerbane.Timer = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Player.Wins > 1)
        {
            gameObject.transform.position = new Vector3(-0.94f,3.8f,-999f);
            if(Player.inshop == true)
            {
                if(Banelock == false)
                {
                    if(select1 == false){
                   Timerbane.Choice1 = Random.Range(1,6);
                   select1 = true;
                   Timerbane.Choice2 = Random.Range(1,6);
                    }
                   if(Timerbane.Choice2 == Timerbane.Choice1)
                    {
                        Timerbane.Choice2 = Random.Range(1,6);
                        
                    }
                    else
                    {
                        Timerbane.Choice3 = Random.Range(1,6);
                        if(Timerbane.Choice3 == Timerbane.Choice1)
                        {
                            Timerbane.Choice3 = Random.Range(1,6);
                            
                        }
                        else
                        {
                            if(Timerbane.Choice3 == Timerbane.Choice2)
                            {
                                Timerbane.Choice3 = Random.Range(1,6);
                                
                            }
                            else
                            {
                                Banelock = true;
                                select1 = false;
                            }
                        }
                    }
                }
            }
            else
            {
                Banelock = false;
            }
        }
        if(Player.Wins <= 1)
        {
           gameObject.transform.position = new Vector3(-0.94f,3.8f,-18.63808f); 
        }
    }
}
