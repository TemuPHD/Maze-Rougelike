using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathcreate : MonoBehaviour
{
    public static bool pathdone = false;
    private bool foundanchorx = false;
    private bool foundanchorx2 = false;
    private bool foundanchory = false;
    private bool foundanchory2 = false;
    private bool again2y = false;
private bool again2x = false;
private bool againx = false;
private bool againy = false;
    private bool foundkey1x = false;
    private bool foundkey1y = false;
    private bool foundkey2y = false;
    private bool foundkey2x = false;
    private bool foundplayerx = false;
    private bool foundplayery = false;
    public static bool needload = false;
    private bool halt = true;
    private bool firstload = true;
    private bool started = false;
    public static float Currentx;
    public static float Currenty;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Currentx = transform.position.x;
        Currenty = transform.position.y;
       if(firstload == true)
        {
           if (started == false)
            {
               gameObject.transform.position = new Vector3(Exitlocation.eXit,Exitlocation.eYit,0);
            if (gameObject.transform.position == new Vector3(Exitlocation.eXit,Exitlocation.eYit,0))
            {
               started = true; 
            }
            }
            else{
      if (foundanchorx == false)
       {
            if (Mathf.Floor(Anchorlocation.AnchorX) < Mathf.Floor(Currentx))
            {
              gameObject.transform.position = new Vector3(-0.3f+(Currentx),(Currenty),0);
            }
            if (Mathf.Floor(Anchorlocation.AnchorX) > Mathf.Floor(Currentx))
            {
               gameObject.transform.position = new Vector3(0.3f+(Currentx),(Currenty),0);
            }
            if (Mathf.Floor(Anchorlocation.AnchorX) == Mathf.Floor(Currentx))
            {
                foundanchorx = true;
            }
       }
        else
        {
                    if (foundanchory == false)
                    {
                        if (Mathf.Floor(Anchorlocation.AnchorY) < Mathf.Floor(Currenty))
            {
              gameObject.transform.position = new Vector3((Currentx),-0.3f+(Currenty),0);
            }
            if (Mathf.Floor(Anchorlocation.AnchorY) > Mathf.Floor(Currenty))
            {
               gameObject.transform.position = new Vector3((Currentx),0.3f+(Currenty),0);
            }
            if (Mathf.Floor(Anchorlocation.AnchorY) == Mathf.Floor(Currenty))
            {
                foundanchory = true;
            }
                    }
                    else
                    {
                        if(KeyII.Key2 == true)
                        {
                            if (foundkey2x == false)
                            {
                            if (Mathf.Floor(Keypostion2.k2X) < Mathf.Floor(Currentx))
                            {
                                gameObject.transform.position = new Vector3(-0.3f+(Currentx),(Currenty),0);
                            }
                            if(Mathf.Floor(Keypostion2.k2X) > Mathf.Floor(Currentx))
                                {
                                  gameObject.transform.position = new Vector3(0.3f+(Currentx),(Currenty),0);  
                                }
                                if(Mathf.Floor(Keypostion2.k2X) == Mathf.Floor(Currentx))
                                {
                                    foundkey2x = true;
                                }
                            }
                            else
                            {
                                if(foundkey2y == false)
                                {
                                    if(Mathf.Floor(Keypostion2.k3Y) < Mathf.Floor(Currenty))
                                    {
                                        gameObject.transform.position = new Vector3((Currentx),-0.3f+(Currenty),0);
                                    }
                                    if(Mathf.Floor(Keypostion2.k3Y) > Mathf.Floor(Currenty))
                                    {
                                        gameObject.transform.position = new Vector3((Currentx),0.3f+(Currenty),0);
                                    }
                                    if(Mathf.Floor(Keypostion2.k3Y) == Mathf.Floor(Currenty))
                                    {
                                        foundkey2y = true;
                                    }
                                }
                                else
                                {
                                    if(ComplexI.Tier1complex == true){
                        if (foundanchorx2 == false)
                            {
                            if (Mathf.Floor(Anchorlocation2.AnchorX2) < Mathf.Floor(Currentx))
                            {
                                gameObject.transform.position = new Vector3(-0.3f+(Currentx),(Currenty),0);
                            }
                            if(Mathf.Floor(Anchorlocation2.AnchorX2) > Mathf.Floor(Currentx))
                                {
                                  gameObject.transform.position = new Vector3(0.3f+(Currentx),(Currenty),0);  
                                }
                                if(Mathf.Floor(Anchorlocation2.AnchorX2) == Mathf.Floor(Currentx))
                                {
                                    foundanchorx2 = true;
                                }
                            }
                            else
                            {
                                if (foundanchory2 == false)
                                {
                                    if(Mathf.Floor(Anchorlocation2.AnchorY2) < Mathf.Floor(Currenty))
                                    {
                                        gameObject.transform.position = new Vector3((Currentx),-0.3f+(Currenty),0);
                                    }
                                    if(Mathf.Floor(Anchorlocation2.AnchorY2) > Mathf.Floor(Currenty))
                                    {
                                        gameObject.transform.position = new Vector3((Currentx),0.3f+(Currenty),0);
                                    }
                                    if(Mathf.Floor(Anchorlocation2.AnchorY2) == Mathf.Floor(Currenty))
                                    {
                                        foundanchory2 = true;
                                    }
                                }
                                else
                                if(keyI.Key1 == true)
                                    {
                                       if(foundkey1x == false)
                                        {
                                           if (Mathf.Floor(keyposition.keX) < Mathf.Floor(Currentx))
            {
              gameObject.transform.position = new Vector3(-0.3f+(Currentx),(Currenty),0);
            }
            if (Mathf.Floor(keyposition.keX) > Mathf.Floor(Currentx))
            {
               gameObject.transform.position = new Vector3(0.3f+(Currentx),(Currenty),0);
            }
            if (Mathf.Floor(keyposition.keX) == Mathf.Floor(Currentx))
            {
                foundkey1x = true;
            } 
                                        }
                                        else
                                        {
                                            if(foundkey1y == false)
                                            {
                                                if (Mathf.Floor(keyposition.keY) < Mathf.Floor(Currenty))
            {
              gameObject.transform.position = new Vector3((Currentx),-0.3f+(Currenty),0);
            }
            if (Mathf.Floor(keyposition.keY) > Mathf.Floor(Currenty))
            {
               gameObject.transform.position = new Vector3((Currentx),0.3f+(Currenty),0);
            }
            if (Mathf.Floor(keyposition.keY) == Mathf.Floor(Currenty))
            {
                foundkey1y = true;
            }
                                            }
                                            else
                                            {
                                                if(again2y == false)
                                                {
                                                  if(Mathf.Floor(Anchorlocation2.AnchorY2) < Mathf.Floor(Currenty))
                                    {
                                        gameObject.transform.position = new Vector3((Currentx),-0.9f+(Currenty),0);
                                    }
                                    if(Mathf.Floor(Anchorlocation2.AnchorY2) > Mathf.Floor(Currenty))
                                    {
                                        gameObject.transform.position = new Vector3((Currentx),0.9f+(Currenty),0);
                                    }
                                    if(Mathf.Floor(Anchorlocation2.AnchorY2) == Mathf.Floor(Currenty))
                                    {
                                        again2y = true;
                                    }  
                                                }
                                                else
                                                {
                                                    if(again2x == false)
                                                    {
                                                        if (Mathf.Floor(Anchorlocation2.AnchorX2) < Mathf.Floor(Currentx))
                            {
                                gameObject.transform.position = new Vector3(-0.9f+(Currentx),(Currenty),0);
                            }
                            if(Mathf.Floor(Anchorlocation2.AnchorX2) > Mathf.Floor(Currentx))
                                {
                                  gameObject.transform.position = new Vector3(0.9f+(Currentx),(Currenty),0);  
                                }
                                if(Mathf.Floor(Anchorlocation2.AnchorX2) == Mathf.Floor(Currentx))
                                {
                                    again2x = true;
                                }
                                                    }
                                                    else
                                                    {
                                                       if(foundplayerx == false)
                        {
                            if (Mathf.Floor(Player.PlaXer) < Mathf.Floor(Currentx))
            {
              gameObject.transform.position = new Vector3(-0.3f+(Currentx),(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaXer) > Mathf.Floor(Currentx))
            {
               gameObject.transform.position = new Vector3(0.3f+(Currentx),(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(Currentx))
            {
                foundplayerx = true;
            }
                        }
                        else
                        {
                            if(foundplayery == false)
                            {
                                if (Mathf.Floor(Player.PlaYer) < Mathf.Floor(Currenty))
            {
              gameObject.transform.position = new Vector3((Currentx),-0.3f+(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaYer) > Mathf.Floor(Currenty))
            {
               gameObject.transform.position = new Vector3((Currentx),0.3f+(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaYer) == Mathf.Floor(Currenty))
            {
                foundplayery = true;
            }
                            }
                            else
                            {
                                firstload = false;
                                pathdone = true;
                                started = false;
                                foundanchorx = false;
                                foundanchory = false;
                                foundplayerx = false;
                                foundplayery = false;
                                foundanchorx2 = false;
                                foundanchory2 = true;
                                foundkey1x = false;
                                foundkey1y = false;
                                foundkey2x = false;
                                foundkey2y = false;
                                again2x = false;
                                again2y = false;
                                againx = false;
                                againy = false;
                                gameObject.transform.position = new Vector3(-99,-99,-99);
                            }
                        } 
                                                    }
                                                }
                                            }
                                        }
                                    }
                            }
                                    }
                                }
                            }
                        }
                        else{
                        if(ComplexI.Tier1complex == true){
                        if (foundanchorx2 == false)
                            {
                            if (Mathf.Floor(Anchorlocation2.AnchorX2) < Mathf.Floor(Currentx))
                            {
                                gameObject.transform.position = new Vector3(-0.3f+(Currentx),(Currenty),0);
                            }
                            if(Mathf.Floor(Anchorlocation2.AnchorX2) > Mathf.Floor(Currentx))
                                {
                                  gameObject.transform.position = new Vector3(0.3f+(Currentx),(Currenty),0);  
                                }
                                if(Mathf.Floor(Anchorlocation2.AnchorX2) == Mathf.Floor(Currentx))
                                {
                                    foundanchorx2 = true;
                                }
                            }
                            else
                            {
                                if (foundanchory2 == false)
                                {
                                    if(Mathf.Floor(Anchorlocation2.AnchorY2) < Mathf.Floor(Currenty))
                                    {
                                        gameObject.transform.position = new Vector3((Currentx),-0.3f+(Currenty),0);
                                    }
                                    if(Mathf.Floor(Anchorlocation2.AnchorY2) > Mathf.Floor(Currenty))
                                    {
                                        gameObject.transform.position = new Vector3((Currentx),0.3f+(Currenty),0);
                                    }
                                    if(Mathf.Floor(Anchorlocation2.AnchorY2) == Mathf.Floor(Currenty))
                                    {
                                        foundanchory2 = true;
                                    }
                                }
                                else
                                if(keyI.Key1 == true)
                                    {
                                       if(foundkey1x == false)
                                        {
                                           if (Mathf.Floor(keyposition.keX) < Mathf.Floor(Currentx))
            {
              gameObject.transform.position = new Vector3(-0.3f+(Currentx),(Currenty),0);
            }
            if (Mathf.Floor(keyposition.keX) > Mathf.Floor(Currentx))
            {
               gameObject.transform.position = new Vector3(0.3f+(Currentx),(Currenty),0);
            }
            if (Mathf.Floor(keyposition.keX) == Mathf.Floor(Currentx))
            {
                foundkey1x = true;
            } 
                                        }
                                        else
                                        {
                                            if(foundkey1y == false)
                                            {
                                                if (Mathf.Floor(keyposition.keY) < Mathf.Floor(Currenty))
            {
              gameObject.transform.position = new Vector3((Currentx),-0.3f+(Currenty),0);
            }
            if (Mathf.Floor(keyposition.keY) > Mathf.Floor(Currenty))
            {
               gameObject.transform.position = new Vector3((Currentx),0.3f+(Currenty),0);
            }
            if (Mathf.Floor(keyposition.keY) == Mathf.Floor(Currenty))
            {
                foundkey1y = true;
            }
                                            }
                                            else
                                            {
                                                if(again2y == false)
                                                {
                                                  if(Mathf.Floor(Anchorlocation2.AnchorY2) < Mathf.Floor(Currenty))
                                    {
                                        gameObject.transform.position = new Vector3((Currentx),-0.9f+(Currenty),0);
                                    }
                                    if(Mathf.Floor(Anchorlocation2.AnchorY2) > Mathf.Floor(Currenty))
                                    {
                                        gameObject.transform.position = new Vector3((Currentx),0.9f+(Currenty),0);
                                    }
                                    if(Mathf.Floor(Anchorlocation2.AnchorY2) == Mathf.Floor(Currenty))
                                    {
                                        again2y = true;
                                    }  
                                                }
                                                else
                                                {
                                                    if(again2x == false)
                                                    {
                                                        if (Mathf.Floor(Anchorlocation2.AnchorX2) < Mathf.Floor(Currentx))
                            {
                                gameObject.transform.position = new Vector3(-0.9f+(Currentx),(Currenty),0);
                            }
                            if(Mathf.Floor(Anchorlocation2.AnchorX2) > Mathf.Floor(Currentx))
                                {
                                  gameObject.transform.position = new Vector3(0.9f+(Currentx),(Currenty),0);  
                                }
                                if(Mathf.Floor(Anchorlocation2.AnchorX2) == Mathf.Floor(Currentx))
                                {
                                    again2x = true;
                                }
                                                    }
                                                    else
                                                    {
                                                       if(foundplayerx == false)
                        {
                            if (Mathf.Floor(Player.PlaXer) < Mathf.Floor(Currentx))
            {
              gameObject.transform.position = new Vector3(-0.3f+(Currentx),(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaXer) > Mathf.Floor(Currentx))
            {
               gameObject.transform.position = new Vector3(0.3f+(Currentx),(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(Currentx))
            {
                foundplayerx = true;
            }
                        }
                        else
                        {
                            if(foundplayery == false)
                            {
                                if (Mathf.Floor(Player.PlaYer) < Mathf.Floor(Currenty))
            {
              gameObject.transform.position = new Vector3((Currentx),-0.3f+(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaYer) > Mathf.Floor(Currenty))
            {
               gameObject.transform.position = new Vector3((Currentx),0.3f+(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaYer) == Mathf.Floor(Currenty))
            {
                foundplayery = true;
            }
                            }
                            else
                            {
                                firstload = false;
                                pathdone = true;
                                started = false;
                                foundanchorx = false;
                                foundanchory = false;
                                foundplayerx = false;
                                foundplayery = false;
                                foundanchorx2 = false;
                                foundanchory2 = true;
                                foundkey1x = false;
                                foundkey1y = false;
                                foundkey2x = false;
                                foundkey2y = false;
                                again2x = false;
                                again2y = false;
                                againx = false;
                                againy = false;
                                gameObject.transform.position = new Vector3(-99,-99,-99);
                            }
                        } 
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                {
                                  if(foundplayerx == false)
                        {
                            if (Mathf.Floor(Player.PlaXer) < Mathf.Floor(Currentx))
            {
              gameObject.transform.position = new Vector3(-0.3f+(Currentx),(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaXer) > Mathf.Floor(Currentx))
            {
               gameObject.transform.position = new Vector3(0.3f+(Currentx),(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(Currentx))
            {
                foundplayerx = true;
            }
                        }
                        else
                        {
                            if(foundplayery == false)
                            {
                                if (Mathf.Floor(Player.PlaYer) < Mathf.Floor(Currenty))
            {
              gameObject.transform.position = new Vector3((Currentx),-0.3f+(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaYer) > Mathf.Floor(Currenty))
            {
               gameObject.transform.position = new Vector3((Currentx),0.3f+(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaYer) == Mathf.Floor(Currenty))
            {
                foundplayery = true;
            }
                            }
                            else
                            {
                                firstload = false;
                                pathdone = true;
                                started = false;
                                foundanchorx = false;
                                foundanchory = false;
                                foundplayerx = false;
                                foundplayery = false;
                                foundanchorx2 = false;
                                foundanchory2 = true;
                                foundkey1x = false;
                                foundkey1y = false;
                                foundkey2x = false;
                                foundkey2y = false;
                                gameObject.transform.position = new Vector3(-99,-99,-99);
                            }
                        
                        }  
                                }
                            }
                            }
                            else
                            {
                        if(foundplayerx == false)
                        {
                            if (Mathf.Floor(Player.PlaXer) < Mathf.Floor(Currentx))
            {
              gameObject.transform.position = new Vector3(-0.3f+(Currentx),(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaXer) > Mathf.Floor(Currentx))
            {
               gameObject.transform.position = new Vector3(0.3f+(Currentx),(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(Currentx))
            {
                foundplayerx = true;
            }
                        }
                        else
                        {
                            if(foundplayery == false)
                            {
                                if (Mathf.Floor(Player.PlaYer) < Mathf.Floor(Currenty))
            {
              gameObject.transform.position = new Vector3((Currentx),-0.3f+(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaYer) > Mathf.Floor(Currenty))
            {
               gameObject.transform.position = new Vector3((Currentx),0.3f+(Currenty),0);
            }
            if (Mathf.Floor(Player.PlaYer) == Mathf.Floor(Currenty))
            {
                foundplayery = true;
            }
                            }
                            else
                            {
                                firstload = false;
                                pathdone = true;
                                started = false;
                                foundanchorx = false;
                                foundanchory = false;
                                foundplayerx = false;
                                foundplayery = false;
                                foundanchorx2 = false;
                                gameObject.transform.position = new Vector3(-99,-99,-99);
                            }
                        
                        }
                            }
                        }
                    }
        }
            }
        }
        if(Player.inshop == true)
        {
            if(Pathcreate.pathdone == true)
            pathdone = false;
            Currentx = transform.position.x;
            needload = true;
        Currenty = transform.position.y;
        }
        if(firstload == false){
        if(Exitlocation.proceed == true){
        if(Player.inshop == false)
                {
                    firstload = true;
                    needload = false;
                }
            }
        }
    }
}
