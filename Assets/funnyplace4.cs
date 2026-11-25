using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funnyplace4 : MonoBehaviour
{
     private bool Mudlock = true;
    public static bool Fun5cue = false;
    public static float funny4x;
    public static float funny4y;
    private float success;
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
        funnyplace4.funny4x = transform.position.x;
        funnyplace4.funny4y = transform.position.y;

       if(alilfunnytile.funnyexist == false)
        {
          gameObject.transform.position = new Vector3(-99,-99,-99);  
        } 
        if(alilfunnytile.funnyexist == true)
        {
            if(Player.inshop == true)
        {
            if(Mudlock == false)
            {
                Mudlock = true;
            }
        }
        if(Player.inshop == false)
        {
            if(funnyplace3.Fun4cue == true) {
                success = Random.Range(0,3+tilechanceup.floorchance);
            if(success >= 2){
            if(Mudlock == true)
            {
                Mudlock = false;
                gameObject.transform.position = Randomcellmud(9,4);
                funnyplace4.Fun5cue = true;

            }
        }
                    else
                    {
                        funnyplace4.Fun5cue = false;
                    }
        funnyplace3.Fun4cue = false;
            }
        }
        }
        if(Timerblock.FAIL == true)
        {
            funnyplace4.Fun5cue = false;
        }
        if(Player.inshop == true)
        {
            gameObject.transform.position = new Vector3(-99,-99,-99);
        }
    }
}
