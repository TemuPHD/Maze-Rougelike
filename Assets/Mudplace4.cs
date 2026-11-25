using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mudplace4 : MonoBehaviour
{
    private bool Mudlock = true;
    public static bool Mud5cue = false;
    public static float Muddy4x;
    public static float Muddy4y;
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
        Mudplace4.Muddy4x = transform.position.x;
        Mudplace4.Muddy4y = transform.position.y;

       if(Mud.Mudexist == false)
        {
          gameObject.transform.position = new Vector3(-99,-99,-99);  
        } 
        if(Mud.Mudexist == true)
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
            if(Mudplace3.Mud4cue == true) {
                success = Random.Range(0,3+tilechanceup.floorchance);
            if(success >= 2){
            if(Mudlock == true)
            {
                Mudlock = false;
                gameObject.transform.position = Randomcellmud(9,4);
                Mudplace4.Mud5cue = true;

            }
        }
        Mudplace3.Mud4cue = false;
            }
        }
        }
        if(Timerblock.FAIL == true)
        {
            Mudplace4.Mud5cue = false;
        }
        if(Player.inshop == true)
        {
            gameObject.transform.position = new Vector3(-99,-99,-99);
        }
    }
}
