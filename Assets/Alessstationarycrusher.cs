using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alessstationarycrusher : MonoBehaviour
{
    private bool Tracklock = false;
    private bool randomlock = false;
    private bool Crushreset = false;
    private float Tracktime = 5;
    private float Crushz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Crushz = transform.position.z;
        if(Lockedinready.targetinsight == true)
        {
            if(Player.inshop == true)
            {
                
                
                Crushreset = false;
            }
            
                if(Tracklock == false)
                {
                    gameObject.transform.position = new Vector3(Player.PlaXer,Player.PlaYer,30);
                    if(randomlock == false){
                    Tracktime = Random.Range(2,6);
                    randomlock = true;
                    Crushreset = false;
                    
                    StartCoroutine(WaitForFunction(Tracktime));
                    }

                }
                else
                {
                    if(Player.inshop == false){
                   
                    if(Crushreset == false)
                    {
                        if(Crushz > -1)
                        {
                            gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,(gameObject.transform.position.z)-0.075f-thelastbaneofV1.trackcrushspeed);
                        }
                        else
                        {
                            Crushreset = true;
                        }
                    }
                    else
                    {
                        if(Crushz < 30)
                        {
                            gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,(gameObject.transform.position.z)+0.15f+(thelastbaneofV1.trackcrushspeed*0.005f));
                        }
                        else
                        {
                            randomlock = false;
                            Tracklock = false;
                            
                            
                        }
                    }
                    }
                else
                {
                    randomlock = false;
                            Tracklock = false;
                }
                }
            
        }
        else
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
    }
    IEnumerator WaitForFunction(float wait)
{
    yield return new WaitForSeconds(wait);
    Tracklock = true;
    
    
}
}
