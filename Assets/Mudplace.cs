using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mudplace : MonoBehaviour
{
    private static bool Mudlock = true;
    public static bool Mud2cue = false;
    public static float Muddy1x;
    public static float Muddy1y;
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
        Mudplace.Muddy1x = transform.position.x;
        Mudplace.Muddy1y = transform.position.y;

       if(Mud.Mudexist == false)
        {
          gameObject.transform.position = new Vector3(-99,-99,-99);  
        } 
        if(Mud.Mudexist == true)
        {
            if(Player.inshop == true)
        {
            if(Mudplace.Mudlock == false)
            {
                Mudplace.Mudlock = true;
            }
        }
        if(Player.inshop == false)
        {
            if(Mudplace.Mudlock == true)
            {
                Mudplace.Mudlock = false;
                gameObject.transform.position = Randomcellmud(9,4);
                Mudplace.Mud2cue = true;

            }
        }
        }
        if(Timerblock.FAIL == true)
        {
            Mudplace.Mud2cue = false;
        }
        if(Player.inshop == true)
        {
            gameObject.transform.position = new Vector3(-99,-99,-99);
        }
    }
}
