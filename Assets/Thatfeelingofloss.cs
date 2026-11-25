using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thatfeelingofloss : MonoBehaviour
{
    private AudioSource audioSource;
    private bool itslikesomefearoflossgraveroute = false;
    //Insert Figment reference here
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.gameovermusic == true)
        {
            if(itslikesomefearoflossgraveroute == false)
            {
                audioSource = GetComponent<AudioSource>();
                audioSource.Play();
                itslikesomefearoflossgraveroute = true;
            }
        }
        else
        {
                audioSource = GetComponent<AudioSource>();
                audioSource.Stop();
                itslikesomefearoflossgraveroute = false;
            
        }
    }
}
