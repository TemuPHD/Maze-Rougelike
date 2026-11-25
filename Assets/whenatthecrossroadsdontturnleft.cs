using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenatthecrossroadsdontturnleft : MonoBehaviour
{
    private float ClXne = 0;
    private float ClYne = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Exit"))
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        ClXne = transform.position.x;
        ClYne = transform.position.y;
        if(tokeeplonglive.place2 == true)
        {
            StartCoroutine(WaitForFunction(0.25f));
        }
        if(reverseclone.Oppiclone == false)
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
        if(Player.inshop == true)
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
        if(Pathcreate.pathdone == true)
        {
            if (Input.GetKeyDown(KeyCode.A))
     {
      
        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace.Muddy1x)){
            if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace.Muddy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
            }
            else
            {
               if (Mathf.Floor(ClXne) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                     }
                  }
               }
            }
         }
         else{
               if (Mathf.Floor(ClXne) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                        }
                     }
                  }
               }
         }
         if(Mathf.Floor(ClXne) == Mathf.Floor(iceplace.Icy1x)){
            if(Mathf.Floor(ClYne) == Mathf.Floor(iceplace.Icy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
            }
            else
            {
               if (Mathf.Floor(ClXne) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
            }
         }
         else{
               if (Mathf.Floor(ClXne) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
         }
         if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace.funny1x)){
            if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace.funny1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
            }
            else
            {
               if (Mathf.Floor(ClXne) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
            }
         }
         else{
               if (Mathf.Floor(ClXne) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
         }

     }   
     if (Input.GetKeyDown(KeyCode.D))
     {
      
         if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace.Muddy1x)){
            if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace.Muddy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
            }
            else
            {
               if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                     }
                  }
               }
            }
         }
         else{
        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                        }
                     }
                  }
               }
         }
         if(Mathf.Floor(ClXne) == Mathf.Floor(iceplace.Icy1x)){
            if(Mathf.Floor(ClYne) == Mathf.Floor(iceplace.Icy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
            }
            else
            {
               if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
            }
         }
         else{
        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-50.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
         }
         if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace.funny1x)){
            if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace.funny1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
            }
            else
            {
               if (Mathf.Floor(ClXne) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
            }
         }
         else{
               if (Mathf.Floor(ClXne) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
         }


     }   
     if (Input.GetKeyDown(KeyCode.S))
     {
      
       if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace.Muddy1x)){
            if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace.Muddy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
            }
            else
            {
               if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                     }
                  }
               }
            }
         }
         else{
        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                        }
                     }
                  }
               }
         }
         if(Mathf.Floor(ClXne) == Mathf.Floor(iceplace.Icy1x)){
            if(Mathf.Floor(ClYne) == Mathf.Floor(iceplace.Icy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
            }
            else
            {
               if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
            }
         }
         else{
        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,50.0f,0.0f);  
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
         }
         if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace.funny1x)){
            if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace.funny1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
            }
            else
            {
               if (Mathf.Floor(ClXne) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
            }
         }
         else{
               if (Mathf.Floor(ClXne) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
         }


     }   
     if (Input.GetKeyDown(KeyCode.W))
     {
      
       if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace.Muddy1x)){
            if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace.Muddy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
            }
            else
            {
               if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                     }
                  }
               }
            }
         }
         else{
        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Mudplace6.Muddy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                        }
                     }
                  }
               }
         }
         if(Mathf.Floor(ClXne) == Mathf.Floor(iceplace.Icy1x)){
            if(Mathf.Floor(ClYne) == Mathf.Floor(iceplace.Icy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
            }
            else
            {
               if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
            }
         }
         else{
        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-50.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
         }
if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace.funny1x)){
            if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace.funny1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
            }
            else
            {
               if (Mathf.Floor(ClXne) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
            }
         }
         else{
               if (Mathf.Floor(ClXne) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
                  }
               }
               else
               {
                  if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                     }
                  }
                  else
                  {
                     if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                        }
                     }
                     else
                     {
                        if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                           }
                        }
                        else
                        {
                           if(Mathf.Floor(ClXne) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(ClYne) == Mathf.Floor(funnyplace6.funny6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                              }
                              else
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                              }
                           }
                           else
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        
                           }
                        }
                     }
                  }
               }
         }

     }
      
        }
        else
        {
            UnityEngine.Rigidbody rb;
            rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0.0f,0.0f,0.0f);
        }
    }
    IEnumerator WaitForFunction(float wait)
{
    yield return new WaitForSeconds(wait);
    gameObject.transform.position = new Vector3(tokeeplonglive.gohere2x,tokeeplonglive.gohere2y,0);
            tokeeplonglive.place2 = false; 
}
}
