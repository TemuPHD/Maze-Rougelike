using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tokeeplonglive : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    private bool checklock = false;
    public static bool place2 = false;
    public static float gohere2x = 0;
    public static float gohere2y = 0;
    private Vector3 Randomcel(int width, int height)
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
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.transform.position = Randomcel(9,4);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(reverseclone.Oppiclone == true)
        {
            if(Player.inshop == true)
            {
              checklock = false;
              tokeeplonglive.place2 = false;  
              GetComponent<SphereCollider>().enabled = true;
            }
            else
            {
                if(checklock == false)
                {
                     gameObject.transform.position = Randomcel(9,4);
                     StartCoroutine(WaitForFunction(0.1f));
                     checklock = true;
                }
            }
        }
        else
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
    }
    IEnumerator WaitForFunction(float wait)
{
    yield return new WaitForSeconds(wait);
    GetComponent<SphereCollider>().enabled = false;
    tokeeplonglive.place2 = true;
    GetComponent<SphereCollider>().enabled = false;
    tokeeplonglive.gohere2x = transform.position.x;
        tokeeplonglive.gohere2y = transform.position.y;
    gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
}
}
