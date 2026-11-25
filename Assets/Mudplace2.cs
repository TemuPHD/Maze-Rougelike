using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mudplace2 : MonoBehaviour
{
    private bool Mudlock = true;
    public static bool Mud3cue = false;
    public static float Muddy2x;
    public static float Muddy2y;
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
        Mudplace2.Muddy2x = transform.position.x;
        Mudplace2.Muddy2y = transform.position.y;

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
            if(Mudplace.Mud2cue == true) {
                success = Random.Range(0,3+tilechanceup.floorchance);
            if(success >= 2){
            if(Mudlock == true)
            {
                Mudlock = false;
                gameObject.transform.position = Randomcellmud(9,4);
                Mudplace2.Mud3cue = true;

            }
        }
        if(success < 2)
                    {
                        Mudplace.Mud2cue = false;
                    }
            }
        }
        }
        if(Timerblock.FAIL == true)
        {
            Mudplace2.Mud3cue = false;
        }
        if(Player.inshop == true)
        {
            gameObject.transform.position = new Vector3(-99,-99,-99);
        }
    }
}
