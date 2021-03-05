using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text WaveInterval;
    public Text Goldpix;
    public int Gold;
    public float Times;
    public GameObject Spown;
    public int score;
    public Text scorepix;
    

    void Start()
    {
        Gold = 2300;
    }

    // Update is called once per frame
    void Update()
    {
        Goldpix.text = Gold.ToString();
        scorepix.text = "РЕКОРД:" + score.ToString();
        /*
        //секундомер до начала волны
       // Times = Spown.GetComponent<WaveSpawn>().StartTime;

        WaveInterval.text = Times.ToString();
        Times = Times-- * Time.deltaTime;

        
        */
    }
    
}
