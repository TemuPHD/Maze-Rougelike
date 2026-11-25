using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exitlocation : MonoBehaviour
{
    public static bool telelock = false;
    public static float eXit;
    public static float eYit;
    public static bool proceed = false;
    public Vector3 Randomcellleave(int width, int height)
    
   {
      //var r = new Random();
     return new Vector3(-12.7f+(3*Random.Range(0,width)),5.64f-(3*Random.Range(0,height)),0);
   }
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SphereCollider>().enabled = true;
        gameObject.transform.position = Randomcellleave(9,4);
        Exitlocation.eXit = transform.position.x;
        Exitlocation.eYit = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Exitlocation.eXit = transform.position.x;
        Exitlocation.eYit = transform.position.y;
        if(Player.inshop == true)
        {
            if(Exitlocation.telelock == false) ;
            {
                Exitlocation.telelock = true;
            }
        }
        if(Player.inshop == false)
        {
            if(Exitlocation.telelock == true)
            {
                Exitlocation.telelock = false;
                gameObject.transform.position = Randomcellleave(9,4);
                Exitlocation.proceed = true;
            }
              if(Pathcreate.needload == false)
        {
            Exitlocation.proceed = false;
        }
        }
        if(Timerblock.FAIL == true)
        {
            GetComponent<SphereCollider>().enabled = true;
        }
        if(keyI.Key1 == true)
        {
            if(keyposition.unlocked == true)
            {
                if(KeyII.Key2 == true)
                {
                    if(Keypostion2.unlocked2 == true)
                    {
                        GetComponent<SphereCollider>().enabled = true;
                    }
                    else
                    GetComponent<SphereCollider>().enabled = false;
                }
                else
                GetComponent<SphereCollider>().enabled = true;
            }
            else
            {
                GetComponent<SphereCollider>().enabled = false;
            }
        }
    }
}
