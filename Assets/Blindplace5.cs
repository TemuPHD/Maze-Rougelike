using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blindplace5 : MonoBehaviour
{
     private bool Mudlock = true;
    public static bool Blind6cue = false;
    public static float blind5x;
    public static float blind5y;
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
        Blindplace5.blind5x = transform.position.x;
       Blindplace5.blind5y = transform.position.y;

       if(Blind.blindexist == false)
        {
          gameObject.transform.position = new Vector3(-99,-99,-99);  
        } 
        if(Blind.blindexist == true)
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
            if(Blindplace4.Blind5cue == true) {
                success = Random.Range(0,3+tilechanceup.floorchance);
            if(success >= 2){
            if(Mudlock == true)
            {
                Mudlock = false;
                gameObject.transform.position = Randomcellmud(9,4);
                Blindplace5.Blind6cue = true;

            }
        }
                    else
                    {
                        Blindplace5.Blind6cue = false;
                    }
        Blindplace4.Blind5cue = false;
        
            }
        }
        }
        if(Timerblock.FAIL == true)
        {
            Blindplace5.Blind6cue = false;
        }
        if(Player.inshop == true)
        {
            gameObject.transform.position = new Vector3(-99,-99,-99);
        }
        if(Pathcreate.pathdone == false)
        {
            if (Mathf.Floor(Blindplace5.blind5x) == Mathf.Floor(Player.PlaXer))
         {
            if(Mathf.Floor(Blindplace5.blind5y) == Mathf.Floor(Player.PlaYer))
            {
               gameObject.transform.position = new Vector3(-99,-99,-99);
            }
         }
        }
    }
}
