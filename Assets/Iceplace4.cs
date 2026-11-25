using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iceplace4 : MonoBehaviour
{
    private bool Mudlock = true;
    public static bool Ice5cue = false;
    public static float Icy4x;
    public static float Icy4y;
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
        Iceplace4.Icy4x = transform.position.x;
        Iceplace4.Icy4y = transform.position.y;

       if(ice.Iceexist == false)
        {
          gameObject.transform.position = new Vector3(-99,-99,-99);  
        } 
        if(ice.Iceexist == true)
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
            if(Iceplace3.Ice4cue == true) {
                success = Random.Range(0,3+tilechanceup.floorchance);
            if(success >= 2){
            if(Mudlock == true)
            {
                Mudlock = false;
                gameObject.transform.position = Randomcellmud(9,4);
                Iceplace4.Ice5cue = true;

            }
        }
        Iceplace3.Ice4cue = false;
            }
        }
        }
        if(Timerblock.FAIL == true)
        {
            Iceplace4.Ice5cue = false;
        }
        if(Player.inshop == true)
        {
            gameObject.transform.position = new Vector3(-99,-99,-99);
        }
        if(Timerblock.FAIL == true)
        {
            gameObject.transform.position = new Vector3(-99,-99,-99);
        }
    }
}
