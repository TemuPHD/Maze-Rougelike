using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypostion2 : MonoBehaviour
{
    public static bool unlocked2 = false;
    private bool telelock = false;
    private bool firsttime = true;
    public static float k2X;
    public static float k3Y;
    private Vector3 Randomcellleave(int width, int height)
    
   {
      //var r = new Random();
     return new Vector3(-12.7f+(3*Random.Range(0,width)),5.84f-(3*Random.Range(0,height)),0);
   }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(-99,-999,-99);
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Keypostion2.unlocked2 = true;
            if(Pathcreate.pathdone == true)
            gameObject.transform.position = new Vector3(-99,-999,-99);
        }
    }
    // Update is called once per frame
    void Update()
    {
       if(KeyII.Key2 == true)
        {
            if (firsttime == true)
            {
                gameObject.transform.position = Randomcellleave(9,4);
                firsttime = false;
            }
            Keypostion2.k2X = transform.position.x;
        Keypostion2.k3Y = transform.position.y;
        if(Player.inshop == true)
        {
            if(telelock == false) ;
            {
                telelock = true;
            }
            if(Keypostion2.unlocked2 == true)
                {
                    Keypostion2.unlocked2 = false;
                }
        }
        if(Player.inshop == false)
        {
            if(telelock == true)
            {
                gameObject.transform.position = Randomcellleave(9,4);
                telelock = false;
                gameObject.transform.position = Randomcellleave(9,4);
                firsttime = true;
            }
        }
        }
        if(Timerblock.FAIL == true)
        {
            firsttime = true;
            gameObject.transform.position = new Vector3(-99,-999,-99);
        } 
    }
}
