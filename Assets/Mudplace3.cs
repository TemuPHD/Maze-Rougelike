using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mudplace3 : MonoBehaviour
{
    private bool Mudlock = true;
    public static bool Mud4cue = false;
    public static float Muddy3x;
    public static float Muddy3y;
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
        Mudplace3.Muddy3x = transform.position.x;
        Mudplace3.Muddy3y = transform.position.y;

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
            if(Mudplace2.Mud3cue == true) {
                success = Random.Range(0,3+tilechanceup.floorchance);
            if(success >= 2){
            if(Mudlock == true)
            {
                Mudlock = false;
                gameObject.transform.position = Randomcellmud(9,4);
                Mudplace3.Mud4cue = true;

            }
        }
                    else
                    {
                        Mudplace3.Mud4cue = false;
                    }
            }
        }
        }
        if(Timerblock.FAIL == true)
        {
            Mudplace3.Mud4cue = false;
        }
        if(Player.inshop == true)
        {
            gameObject.transform.position = new Vector3(-99,-99,-99);
        }
    }
}
