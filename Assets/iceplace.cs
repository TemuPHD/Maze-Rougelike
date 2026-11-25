using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceplace : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    private bool Icelock = true;
    public static bool Ice2cue = false;
    public static float Icy1x;
    public static float Icy1y;
    private Vector3 Randomcellmud(int width, int height)
    
   {
      //var r = new Random();
     return new Vector3(-12.7f+(3*Random.Range(0,width)),5.64f-(3*Random.Range(0,height)),0);
   }
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = 
            RigidbodyConstraints.FreezePosition | 
            RigidbodyConstraints.FreezeRotation;
        gameObject.transform.position = new Vector3(-99,-99,-99);
    }

    // Update is called once per frame
    void Update()
    {
        iceplace.Icy1x = transform.position.x;
        iceplace.Icy1y = transform.position.y;
        if(ice.Iceexist == false)
        {
          gameObject.transform.position = new Vector3(-99,-99,-99);  
        } 
        if(ice.Iceexist == true)
        {
            if(Player.inshop == true)
        {
            if(Icelock == false)
            {
                Icelock = true;
            }
        }
        if(Player.inshop == false)
        {
            if(Icelock == true)
            {
                Icelock = false;
                gameObject.transform.position = Randomcellmud(9,4);
                iceplace.Ice2cue = true;

            }
        }
        }
        if(Timerblock.FAIL == true)
        {
            iceplace.Ice2cue = false;
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
