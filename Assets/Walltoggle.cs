using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walltoggle : MonoBehaviour
{
    private bool Blocked = false;
    private bool Wallock = false;
    private bool specialtype = false;
    private bool speciallock = false;
    private bool swaplock = false;
    private bool swapside = false;
    private float Swap = 0;
    private float Wallx;
    private float Wally;
    // Start is called before the first frame update
    void Start()
    {
        if(Random.Range(0,2+ComplexII.Morewall) == 1)
            Blocked = true;
        else
            Blocked = false;
    }

    // Update is called once per frame
    void Update()
    {
        Wallx = transform.position.x;
        Wally = transform.position.y;
        if (Mathf.Floor(Wallx) == Mathf.Floor(Pathcreate.Currentx))
        {
            if(Mathf.Floor(Wally) == Mathf.Floor(Pathcreate.Currenty))
            {
                Blocked = false;
            }
        }
        if(Player.inshop == true)
        {
            if(Wallock == false)
            {
                Wallock = true;
                speciallock = false;
                specialtype = false;
                swaplock = false;
                Swap = 0;
            }
        }
        if(Player.inshop == false)
        {
            if(Wallock == true)
            {
            if(Random.Range(0,2+ComplexII.Morewall) >= 1)
                Blocked = true;
            else
                Blocked = false;
            }
            Wallock = false;
        }
        if(Blocked == true)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,0);
        }
        if(Blocked == false)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,-999.111327f);
            if(Swapwalls.Swappers){
            if(speciallock == false)
            {
             if(Random.Range(0,3) == 1)
                {
                    specialtype = true;
                    speciallock = true;
                }
               else
            {
                    speciallock = true;
              }
            }
            }
            
        
        }
    }
}
