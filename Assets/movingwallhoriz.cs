using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingwallhoriz : MonoBehaviour
{
    private float movex;
    private float movey;
    private float nowx;
    private float nowy;
    private bool locationlock = false;
    private bool randylock = false;
    private bool randychancelock = false;
    private bool moveitschomveit = false;
    private bool direction = false;
    private Vector3 Randomcellswap(int width, int height) {
      //var r = new Random();
     return new Vector3(-10.78f+(3*Random.Range(0,width)),5.64f-(3*Random.Range(0,height)),30);
   }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      nowx = transform.position.x;
                nowy = transform.position.y;
        if(movingwalls.movers == true)
        {
            if(Player.inshop == true)
            {
                locationlock = false;
                randylock = false;
                randychancelock = false;
            }
            else
            {
                
                if(moveitschomveit == true){
                if(randylock == false){
                gameObject.transform.position = Randomcellswap(9,4);
                randylock = true;
                }
                if (locationlock == false)
                {
                    movex = transform.position.x;
                movey = transform.position.y;
                locationlock = true;
                }
                else
                {
                    if(direction == false)
                    {
                        if (nowy < movey+2)
                        {
                            gameObject.transform.position = new Vector3((nowx),gameObject.transform.position.y+0.05f,0);
                        }
                        else
                        {
                            direction = true;
                        }
                    }
                    else
                    {
                        if (nowy > movey-2)
                        {
                            gameObject.transform.position = new Vector3((nowx),gameObject.transform.position.y-0.05f,0);
                        }
                        else
                        {
                            direction = false;
                        }
                    }
                }
                }
            }
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,-999.111327f);
        }
         if(randychancelock == false)
                {
                    if(Random.Range(0,3+wallchance.Wallodds) >= 2)
                    {
                        moveitschomveit = true;
                        randychancelock = true;
                        
                    }
                    else
                    {
                        moveitschomveit = false;
                        randychancelock = true;
                        gameObject.transform.position = new Vector3(-999,-999,-999); 
                    }
                }  
    }
}
