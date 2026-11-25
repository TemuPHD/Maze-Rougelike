using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crusheroffset : MonoBehaviour
{
    public static bool nomoresync = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            crusheroffset.nomoresync = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(DualCrusher.AnotherCrushingtime == true)
        {
            if(crusheroffset.nomoresync == true)
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
        if(crusheroffset.nomoresync == false)
        {
            if(Player.Wins > 1)
            {
                if(Timerbane.Choice1 == 3)
                {
                    gameObject.transform.position = new Vector3(-0.56f,3.8f,-18.63808f);
                    
                }
                else
                {
                    if(Timerbane.Choice2 == 3)
                    {
                        gameObject.transform.position = new Vector3(-0.56f,3.8f,-18.63808f);
                        
                    }
                    else
                    {
                        if(Timerbane.Choice3 == 3)
                        {
                            gameObject.transform.position = new Vector3(-0.56f,3.8f,-18.63808f);
                            
                        }
                        else
                        {
                            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
                        }
                    }
                }
            }
        }
        }
        else
        {
            gameObject.transform.position = new Vector3(-99,-99,-99);
        }
    }
}
