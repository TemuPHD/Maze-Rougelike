using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakewalls : MonoBehaviour
{
    private bool Blocked = false;
    private bool Wallock = false;
    // Start is called before the first frame update
    void Start()
    {
      gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,-999.111327f);
    }

    // Update is called once per frame
    void Update()
    {
        if(imposterwall.Fakers == true){
        if(Player.inshop == true)
        {
            if(Wallock == false)
            {
                Wallock = true;
                Blocked = false;
            }
        }
        if(Player.inshop == false)
        {
            if(Wallock == true)
            {
            if(Random.Range(0,5) == 1)
                Blocked = true;
            else
                Blocked = false;
            }
            Wallock = false;
        }
        if(Blocked == true)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,0.2f);
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
