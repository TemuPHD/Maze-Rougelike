using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class somethingsomethinglethalcompanysomething : MonoBehaviour
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
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,-999.111327f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Lethalwalls.Fatality == true)
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
                gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,-999.111327f);
            }
        }
        if(Player.inshop == false)
        {
            if(Wallock == true)
            {
            if(Random.Range(0,11+(ComplexII.Morewall*0.33f)) >= 10)
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
            
        
        }
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,-999.111327f);
        }
    }
}
