using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class TextFlash : MonoBehaviour
{

    [SerializeField]
    private float timer;

    
    public TextMeshProUGUI getReadyFlash;
    public TextMeshProUGUI numThreeFlash;
    public TextMeshProUGUI numTwoFlash;
    public TextMeshProUGUI numOneFlash;
    public TextMeshProUGUI startFlash;


    private void Start()
    {
        getReadyFlash.enabled = false;
        numThreeFlash.enabled = false;
        numTwoFlash.enabled = false;
        numOneFlash.enabled = false;
        startFlash.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        CountdownFlash();
    }

    public void CountdownFlash()
    {
        timer = timer + Time.deltaTime;

        //From Seconds 0-2.5 the timer is handling for Get Ready
        //From Seconds 3-3.5(and incrementing every second the timer is starting the countdown. 3....2....1....Start
        if (timer >= 0.05)
        {
            getReadyFlash.enabled = true;
        }
        if(timer >= 1)
        {
            getReadyFlash.enabled = false;
        }
        if (timer >= 1.5)
        {
            getReadyFlash.enabled = true;
        }
        if (timer >= 2)
        {
            getReadyFlash.enabled = false;
        }
        if (timer >= 2.5)
        {
            getReadyFlash.enabled = true;
        }
        if (timer >= 3)
        {
            getReadyFlash.enabled = false;
            numThreeFlash.enabled = true;
        }
        if (timer >= 4)
        {
            numThreeFlash.enabled = false;
            numTwoFlash.enabled = true;
        }
        if (timer >= 5)
        {
            numTwoFlash.enabled = false;
            numOneFlash.enabled = true;
        }
        if (timer >= 6)
        {
            numOneFlash.enabled = false;
            startFlash.enabled = true;
        }
        if (timer > 7)
        {
            startFlash.enabled = false;
            getReadyFlash.enabled = false;
            numThreeFlash.enabled = false;
            numTwoFlash.enabled = false;
            numOneFlash.enabled = false;

        }




    }


}
