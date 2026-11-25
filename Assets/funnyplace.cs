using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funnyplace : MonoBehaviour
{
    private bool Icelock = true;
    public static bool Fun2cue = false;
    public static float funny1x;
    public static float funny1y;
    private Vector3 Randomcellmud(int width, int height)
    
   {
      //var r = new Random();
     return new Vector3(-12.7f+(3*Random.Range(0,width)),5.64f-(3*Random.Range(0,height)),0);
   }
    // Start is called before the first frame update
    void Start()
    {
     gameObject.transform.position = new Vector3(-99,-99,-99);   
    }

    // Update is called once per frame
    void Update()
    {
        funnyplace.funny1x = transform.position.x;
        funnyplace.funny1y = transform.position.y;
        if(alilfunnytile.funnyexist == false)
        {
          gameObject.transform.position = new Vector3(-99,-99,-99);  
        } 
        if(alilfunnytile.funnyexist == true)
        {
            if(Player.inshop == true)
        {
            if(Icelock == false)
            {
                Icelock = true;
            }
        }
        if(Player.inshop == false)
        {
            if(Icelock == true)
            {
                Icelock = false;
                gameObject.transform.position = Randomcellmud(9,4);
                funnyplace.Fun2cue = true;

            }
        }
        }
        if(Timerblock.FAIL == true)
        {
            funnyplace.Fun2cue = false;
        }
        if(Player.inshop == true)
        {
            gameObject.transform.position = new Vector3(-99,-99,-99);
        }
    }
}
