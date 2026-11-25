using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyposition : MonoBehaviour
{
    public static bool unlocked = false;
    private bool telelock = false;
    private bool firsttime = true;
    public static float keX;
    public static float keY;
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
            keyposition.unlocked = true;
            if(Pathcreate.pathdone == true)
            gameObject.transform.position = new Vector3(-99,-999,-99);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(keyI.Key1 == true)
        {
            if (firsttime == true)
            {
                gameObject.transform.position = Randomcellleave(9,4);
                firsttime = false;
            }
            keyposition.keX = transform.position.x;
        keyposition.keY = transform.position.y;
        if(Player.inshop == true)
        {
            if(telelock == false) ;
            {
                telelock = true;
            }
            if(keyposition.unlocked == true)
                {
                    keyposition.unlocked = false;
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
