using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anchorlocation : MonoBehaviour
{
    public static bool Anchorlock = false;
    public static float AnchorX;
    public static float AnchorY;
    public Vector3 Randomcellanchor(int width, int height) {
      //var r = new Random();
     return new Vector3(-12.7f+(3*Random.Range(0,width)),5.64f-(3*Random.Range(0,height)),0);
   }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = Randomcellanchor(9,4);
        Anchorlocation.AnchorX = transform.position.x;
        Anchorlocation.AnchorY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Anchorlocation.AnchorX = transform.position.x;
        Anchorlocation.AnchorY = transform.position.y;

         if(Player.inshop == true)
        {
            if(Anchorlocation.Anchorlock == false) ;
            {
                Anchorlocation.Anchorlock = true;
            }
        }
        if(Player.inshop == false)
        {
            if(Anchorlocation.Anchorlock == true)
            {
                Anchorlocation.Anchorlock = false;
                gameObject.transform.position = Randomcellanchor(9,4);
            }
        }
    }
}
