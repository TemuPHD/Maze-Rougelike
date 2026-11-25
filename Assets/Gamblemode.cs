using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamblemode : MonoBehaviour
{
    private float Jackpot = 0;
    private bool gamblelock = false;
    public static bool LETSGOGAMBLING = false;
    // Start is called before the first frame update
    void Start()
    {
        Jackpot = Random.Range(1,8);
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Gamblemode.LETSGOGAMBLING = true;
            Timerbane.Timer = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Player.Wins == 0)
        {
            gamblelock = false;
            Gamblemode.LETSGOGAMBLING = false;
        }
        if(Player.Wins == 1)
        {
            if(Jackpot == 7)
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-18.63808f);
        }
        else
        {
            gameObject.transform.position = new Vector3(-10.56f,3.8f,-999f);
        }
        if(Timerblock.FAIL == true)
        {
            if(gamblelock == false){
            Jackpot = Random.Range(5,8);
            gamblelock = true;
            }
        }
        if(Gamblemode.LETSGOGAMBLING == true)
        {
            Timerbane.Choice2 = 77;
            Timerbane.Choice3 = 77;
        }
    }
}
