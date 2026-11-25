using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funnyplace2 : MonoBehaviour
{
    private bool Mudlock = true;
    public static bool Fun3cue = false;
    public static float funny2x;
    public static float funny2y;
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
        funnyplace2.funny2x = transform.position.x;
        funnyplace2.funny2y = transform.position.y;

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
            if(funnyplace.Fun2cue == true) {
                success = Random.Range(0,3+tilechanceup.floorchance);
            if(success >= 2){
            if(Mudlock == true)
            {
                Mudlock = false;
                gameObject.transform.position = Randomcellmud(9,4);
                funnyplace2.Fun3cue = true;

            }
        }
        if(success < 2)
                    {
                        funnyplace2.Fun3cue = false;
                    }
            }
        }
        }
        if(Timerblock.FAIL == true)
        {
            funnyplace2.Fun3cue = false;
        }
        if(Player.inshop == true)
        {
            gameObject.transform.position = new Vector3(-99,-99,-99);
        }
    }
}
