using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertiblockswap : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    private bool swaplock = false;
    private bool swapit = false;
    private bool swapside = false;
    private bool existlock = false;
    private bool exist = false;
    private bool checklock = false;

    private Vector3 Randomcellswap(int width, int height) {
      //var r = new Random();
     return new Vector3(-12.7f+(3*Random.Range(0,width)),4.14f-(3*Random.Range(0,height)),30);
   }
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = 
            RigidbodyConstraints.FreezePosition | 
            RigidbodyConstraints.FreezeRotation;
        gameObject.transform.position = new Vector3(-999,-999,-999);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Swapwalls.Swappers == false)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,-999.111327f);
        }
        else
        {
            if(Player.inshop == true)
            {
               if(swaplock == true)
               swaplock = false; 
               exist = false;
               existlock = false; 
               checklock = false;
            }
            else
            {
                if(exist == true){
                if(swaplock == false)
                {
                    gameObject.transform.position = Randomcellswap(9,4);
                    swaplock = true;
                }
                if(swapside == true)
                {
                   gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,0);
                   checklock = false; 
                }
                else{
                   gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,-999.111327f); 
                   
                   if(checklock == false){
                                      StartCoroutine(WaitForFunction(0.5f));
                                      checklock = true;
                                      }
                }
                } 
            }
        }
        if(swapit == true)
        {
            if(swapside == true)
            {
                swapside = false;
                swapit = false;
            }
            else
            {
                swapside = true;
                swapit = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
     {swapit = true;}
     if (Input.GetKeyDown(KeyCode.W))
     {swapit = true;}
     if (Input.GetKeyDown(KeyCode.A))
     {swapit = true;}
     if (Input.GetKeyDown(KeyCode.D))
     {swapit = true;}
     if(existlock == false)
        {
            if(Random.Range(0,3+wallchance.Wallodds) >= 2)
            {
                exist = true;
                existlock = true;
            }
            else
            {
                existlock = true;
                gameObject.transform.position = new Vector3(-999,-999,-999); 
            }
        }
    }
    IEnumerator WaitForFunction(float wait)
{
    yield return new WaitForSeconds(wait);
    gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,-999.111327f);
}
}