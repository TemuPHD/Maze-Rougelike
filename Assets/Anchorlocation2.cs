using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anchorlocation2 : MonoBehaviour
{
     public static bool Anchorlock2 = false;
    public static float AnchorX2;
    public static float AnchorY2;
    private Vector3 Randomcellanchor2(int width, int height) {
      //var r = new Random();
     return new Vector3(-12.7f+(3*Random.Range(0,width)),5.64f-(3*Random.Range(0,height)),0);
   }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = Randomcellanchor2(9,4);
        Anchorlocation2.AnchorX2 = transform.position.x;
        Anchorlocation2.AnchorY2 = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Anchorlocation2.AnchorX2 = transform.position.x;
        Anchorlocation2.AnchorY2 = transform.position.y;

         if(Player.inshop == true)
        {
            if(Anchorlocation2.Anchorlock2 == false) ;
            {
                Anchorlocation2.Anchorlock2 = true;
            }
        }
        if(Player.inshop == false)
        {
            if(Anchorlocation2.Anchorlock2 == true)
            {
                Anchorlocation2.Anchorlock2 = false;
                gameObject.transform.position = Randomcellanchor2(9,4);
            }
        }
    }
}
