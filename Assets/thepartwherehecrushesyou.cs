using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thepartwherehecrushesyou : MonoBehaviour
{
    private bool Crusherlock = false;
    private bool Crushreset = false;
    private float Crushz;
    private float delay = 0;
    private bool delaylock;
    private Vector3 Randomcellcrush(int width, int height) {
      //var r = new Random();
     return new Vector3(-12.7f+(3*Random.Range(0,width)),5.64f-(3*Random.Range(0,height)),30);
   }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(-0.56f,3.8f,-999f);
    }

    // Update is called once per frame
    void Update()
    {
        if(crusheroffset.nomoresync == true)
        if(delaylock == false)
        {
            delay = (Random.Range(1,21)*0.001f);
            delaylock = true;
        }
        Crushz = transform.position.z;
        if(Crusher.Crushingtime == true)
        {
            if(Player.inshop == true)
            {
                Crusherlock = false;
            }
            else
            {
                if(Crusherlock == false)
                {
                    gameObject.transform.position = Randomcellcrush(9,4);
                    Crusherlock = true;
                }
                else
                {
                    if(Pathcreate.pathdone == true){
                    if(Crushreset == false)
                    {
                        if(Crushz > -1)
                        {
                            gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,(gameObject.transform.position.z)-0.1f-Crushtime.crushtime-delay);
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
                            gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,(gameObject.transform.position.z)+0.3f+(Crushtime.crushtime*0.025f)+delay);
                        }
                        else
                        {
                            Crushreset = false;
                        }
                    }
                    }
                }
            }
        }
        else
        {
            gameObject.transform.position = new Vector3(-0.56f,3.8f,-999f);
        }
        if(Timerblock.FAIL == true)
        {
            gameObject.transform.position = new Vector3(-90.56f,-993.8f,-999f);
            delay = 0;
        }
    }
}
