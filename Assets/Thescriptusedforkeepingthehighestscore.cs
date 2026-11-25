using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Thescriptusedforkeepingthehighestscore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshPro>().text = "Highscore: "+Player.BestWins;
    }
}
