using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
   private AudioSource audioSource;
   Rigidbody m_Rigidbody;
   public static bool inshop = false;
   public static bool gameovermusic = false;
   public static bool swapit = false;
   public static bool BlindMe = false;
   public static float PlaXer;
   public static float PlaYer;
   public static float Wins;
   public static float BestWins;
   public Vector3 Randomcell(int width, int height)
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
        
      Player.Wins = 0;
      gameObject.transform.position = Randomcell(9,4);
    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Exit"))
        {
            Player.Wins = Wins+1;
            Player.inshop = true;
            Mudplace.Mud2cue = false;
            Mudplace2.Mud3cue = false;
            Mudplace3.Mud4cue = false;
            Mudplace4.Mud5cue = false;
            Mudplace5.Mud6cue = false;
            UnityEngine.Rigidbody rb;
            rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0.0f,0.0f,0.0f);
            gameObject.transform.position = new Vector3(0,0,-19);
        }
        if (collision.gameObject.CompareTag("Shop item"))
      {
         Player.inshop = false;
         UnityEngine.Rigidbody rb;
            rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0.0f,0.0f,0.0f);
         gameObject.transform.position = Randomcell(9,4);
         m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.constraints = 
            RigidbodyConstraints.FreezePosition | 
            RigidbodyConstraints.FreezeRotation;
        
      }
      if (collision.gameObject.CompareTag("Retry"))
      {
         Player.gameovermusic = false;
         if(Player.Wins > Player.BestWins)
         {
            Player.BestWins = Player.Wins;
         }
         Player.Wins = 0;
         Visiontrack.camlock = 1;
         Player.inshop = false;
         UnityEngine.Rigidbody rb;
            rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0.0f,0.0f,0.0f);
         gameObject.transform.position = Randomcell(9,4);
      }
      if (collision.gameObject.CompareTag("Leave"))
      {
         Application.Quit();
      }
      if (collision.gameObject.CompareTag("Musicstart"))
      {
         audioSource = GetComponent<AudioSource>();
         audioSource.Play();
      }
      if (collision.gameObject.CompareTag("Musicstop"))
      {
         audioSource = GetComponent<AudioSource>();
         audioSource.Stop();
      }
      if (collision.gameObject.CompareTag("EmergencyB"))
      {
         UnityEngine.Rigidbody rb;
            rb = GetComponent<Rigidbody>();
         rb.velocity = new Vector3(0.0f,7f,0.0f);
      }
      if (collision.gameObject.CompareTag("EmergencyT"))
      {
         UnityEngine.Rigidbody rb;
            rb = GetComponent<Rigidbody>();
         rb.velocity = new Vector3(0.0f,-7f,0.0f);
      }
      if (collision.gameObject.CompareTag("EmergencyL"))
      {
         UnityEngine.Rigidbody rb;
            rb = GetComponent<Rigidbody>();
         rb.velocity = new Vector3(7.0f,0f,0.0f);
      }
      if (collision.gameObject.CompareTag("EmergencyR"))
      {
         UnityEngine.Rigidbody rb;
            rb = GetComponent<Rigidbody>();
         rb.velocity = new Vector3(-7.0f,0f,0.0f);
      }
      if (collision.gameObject.CompareTag("Crusher"))
      {
         Timerblock.FAIL = true;
      }
      if (collision.gameObject.CompareTag("Ice"))
      {
         Debug.Log("Collided");
         if (Input.GetKeyDown(KeyCode.D))
         {
            UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(40.0f,0.0f,0.0f);
         }
         if (Input.GetKeyDown(KeyCode.A))
         {
            UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(-99.0f,0.0f,0.0f);
         }
         if (Input.GetKeyDown(KeyCode.W))
         {
            UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0.0f,99.0f,0.0f);
         }
         if (Input.GetKeyDown(KeyCode.S))
         {
            UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0.0f,-99.0f,0.0f);
         }
      }
    }
    void Update()
    {
      Player.PlaXer = transform.position.x;
      Player.PlaYer = transform.position.y;
      if(Pathcreate.pathdone == true){
         m_Rigidbody.constraints = RigidbodyConstraints.None;
         if (Input.GetKeyDown(KeyCode.D))
     {
      swapit = true;
        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace.Muddy1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace.Muddy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
            }
            else
            {
               if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
               if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
         if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(iceplace.Icy1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(iceplace.Icy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
            }
            else
            {
               if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
               if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(40.0f,0.0f,0.0f);
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
         if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace.funny1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace.funny1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
            }
            else
            {
               if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
               if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
     if (Input.GetKeyDown(KeyCode.A))
     {
      swapit = true;
         if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace.Muddy1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace.Muddy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
            }
            else
            {
               if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-1.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
         if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(iceplace.Icy1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(iceplace.Icy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
            }
            else
            {
               if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-40.0f,0.0f,0.0f);
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
         if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace.funny1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace.funny1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
            }
            else
            {
               if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
               if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
     if (Input.GetKeyDown(KeyCode.W))
     {
      swapit = true;
       if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace.Muddy1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace.Muddy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
            }
            else
            {
               if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace6.Muddy6y))
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
         if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(iceplace.Icy1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(iceplace.Icy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
            }
            else
            {
               if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,40.0f,0.0f);  
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
         if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace.funny1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace.funny1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
            }
            else
            {
               if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
               if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
     if (Input.GetKeyDown(KeyCode.S))
     {
      swapit = true;
       if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace.Muddy1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace.Muddy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
            }
            else
            {
               if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace2.Muddy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace2.Muddy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace3.Muddy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace3.Muddy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace4.Muddy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace4.Muddy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace5.Muddy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace5.Muddy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-1.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace6.Muddy6y))
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
         if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(iceplace.Icy1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(iceplace.Icy1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
            }
            else
            {
               if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace2.Icy2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace2.Icy2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace3.Icy3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace3.Icy3y))
                     {
                       UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f); 
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace4.Icy4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace4.Icy4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace5.Icy5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Iceplace5.Icy5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6x))
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Iceplace6.Icy6y))
                              {
                                 UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-40.0f,0.0f);
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
if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace.funny1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace.funny1y)){
               UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
            }
            else
            {
               if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
               if (Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace2.funny2x))
               {
                  if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace2.funny2y))
                  {
                     UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                  }
                  else
                  {
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                  if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace3.funny3x))
                  {
                     if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace3.funny3y))
                     {
                        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                     }
                     else
                     {
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                     if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace4.funny4x))
                     {
                        if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace4.funny4y))
                        {
                           UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                        }
                        else
                        {
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                        if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace5.funny5x))
                        {
                           if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace5.funny5y))
                           {
                              UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);
                           }
                           else
                           {
                              if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
                           if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(funnyplace6.funny6x))
                           {
                              if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(funnyplace6.funny6y))
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
      if(Player.inshop == true)
      {
         m_Rigidbody.constraints = RigidbodyConstraints.None;
         if (Input.GetKeyDown(KeyCode.D))
     {
        
        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5.0f,0.0f,0.0f);

     }   
     if (Input.GetKeyDown(KeyCode.A))
     {
         if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace.Muddy1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace.Muddy1y)){
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
         else{
        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(-5.0f,0.0f,0.0f);
         }
     }   
     if (Input.GetKeyDown(KeyCode.W))
     {
       if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace.Muddy1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace.Muddy1y)){
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
         else{
        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,5.0f,0.0f);
         }
     }   
     if (Input.GetKeyDown(KeyCode.S))
     {
       if(Mathf.Floor(Player.PlaXer) == Mathf.Floor(Mudplace.Muddy1x)){
            if(Mathf.Floor(Player.PlaYer) == Mathf.Floor(Mudplace.Muddy1y)){
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
         else{
        UnityEngine.Rigidbody rb;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0.0f,-5.0f,0.0f);
         }
     }
      }
      if (Input.GetKeyDown(KeyCode.L))
      {
            Application.Quit();
      }
     if(Timerblock.FAIL == true)
      {
            Visiontrack.camlock = 2;
            Player.inshop = true;
            UnityEngine.Rigidbody rb;
            rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0.0f,0.0f,0.0f);
            gameObject.transform.position = new Vector3(0,0,-45);
            Timerbane.Timer = false;
            Timerblock.FAIL = false;
            Mud.Mudexist = false;
            Mudplace.Mud2cue = false;
            Mudplace2.Mud3cue = false;
            Mudplace3.Mud4cue = false;
            Mudplace4.Mud5cue = false;
            Mudplace5.Mud6cue = false;
            ComplexI.Tier1complex = false;
            Crusher.Crushingtime = false;
            Swapwalls.Swappers = false;
            Crushtime.crushtime = 0;
            tilechanceup.floorchance = 0;
            Timershrink.Timespeed = 0;
            wallchance.Wallodds = 0;
            ComplexII.Tier2complex = false;
            ComplexII.Morewall = 0;
            DualCrusher.AnotherCrushingtime = false;
            imposterwall.Fakers = false;
            alilfunnytile.funnyexist = false;
            keyI.Key1 = false;
            keyposition.unlocked = false;
            crusheroffset.nomoresync = false;
            movingwalls.movers = false;
            Blind.blindexist = false;
            Lethalwalls.Fatality = false;
            KeyII.Key2 = false;
            thebigone.bossasscrusher = false;
            Clonemean.Cruelclone = false;
            reverseclone.Oppiclone = false;
            speedyclone.likethesnail = false;
            Lockedinready.targetinsight = false;
            ice.Iceexist = false;
            audioSource = GetComponent<AudioSource>();
            audioSource.Stop();
            Player.gameovermusic = true;
      }
      if(Blind.blindexist == true)
      {
         if (Mathf.Floor(Blindplace.blind1x) == Mathf.Floor(Player.PlaXer))
         {
            if(Mathf.Floor(Blindplace.blind1y) == Mathf.Floor(Player.PlaYer))
            {
               Player.BlindMe = true;
            }
         }
         else
         {
           if (Mathf.Floor(Blindplace2.blind2x) == Mathf.Floor(Player.PlaXer))
         {
            if(Mathf.Floor(Blindplace2.blind2y) == Mathf.Floor(Player.PlaYer))
            {
               Player.BlindMe = true;
            }
         }
            else
            {
               if (Mathf.Floor(Blindplace3.blind3x) == Mathf.Floor(Player.PlaXer))
         {
            if(Mathf.Floor(Blindplace3.blind3y) == Mathf.Floor(Player.PlaYer))
            {
               Player.BlindMe = true;
            }
         }
               else
               {
                  if (Mathf.Floor(Blindplace4.blind4x) == Mathf.Floor(Player.PlaXer))
         {
            if(Mathf.Floor(Blindplace4.blind4y) == Mathf.Floor(Player.PlaYer))
            {
               Player.BlindMe = true;
            }
         }
                  else
                  {
                     if (Mathf.Floor(Blindplace5.blind5x) == Mathf.Floor(Player.PlaXer))
         {
            if(Mathf.Floor(Blindplace5.blind5y) == Mathf.Floor(Player.PlaYer))
            {
               Player.BlindMe = true;
            }
         }
                     else
                     {
                        if (Mathf.Floor(Blindplace6.blind6x) == Mathf.Floor(Player.PlaXer))
         {
            if(Mathf.Floor(Blindplace6.blind6y) == Mathf.Floor(Player.PlaYer))
            {
               Player.BlindMe = true;
            }
         }
                        else
                        {
                           StartCoroutine(WaitForFunction(0.5f));
                           
                        }
                     }
                  }
               }
            }
         }
      }
    }
   IEnumerator WaitForFunction(float wait)
{
    yield return new WaitForSeconds(wait);
  Player.BlindMe = false;
}
}
