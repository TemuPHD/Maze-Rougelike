using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funnyplace6 : MonoBehaviour
{
    private bool Mudlock = true;
    public static float funny6x;
    public static float funny6y;
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
        funnyplace6.funny6x = transform.position.x;
        funnyplace6.funny6y = transform.position.y;

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
            if(funnyplace5.Fun6cue == true) {
                success = Random.Range(0,3+tilechanceup.floorchance);
            if(success >= 2){
            if(Mudlock == true)
            {
                Mudlock = false;
                gameObject.transform.position = Randomcellmud(9,4);

            }
        }
        funnyplace5.Fun6cue = false;
            }
        }
        }
        if(Player.inshop == true)
        {
            gameObject.transform.position = new Vector3(-99,-99,-99);
        }
    }
}
