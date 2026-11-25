using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blindplace : MonoBehaviour
{
    private bool Icelock = true;
    public static bool Blind2cue = false;
    public static float blind1x;
    public static float blind1y;
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
        blind1x = transform.position.x;
        blind1y = transform.position.y;
        if(Blind.blindexist == false)
        {
          gameObject.transform.position = new Vector3(-99,-99,-99);  
        } 
        if(Blind.blindexist == true)
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
                Blindplace.Blind2cue = true;

            }
        }
        }
        if(Timerblock.FAIL == true)
        {
            Blindplace.Blind2cue = false;
        }
        if(Player.inshop == true)
        {
            gameObject.transform.position = new Vector3(-99,-99,-99);
        }
        if(Pathcreate.pathdone == false)
        {
            if (Mathf.Floor(Blindplace.blind1x) == Mathf.Floor(Player.PlaXer))
         {
            if(Mathf.Floor(Blindplace.blind1y) == Mathf.Floor(Player.PlaYer))
            {
               gameObject.transform.position = new Vector3(-99,-99,-99);
            }
         }
        }
    }
}
