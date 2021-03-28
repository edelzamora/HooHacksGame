using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerPos : MonoBehaviour
{
   public Transform xPos;
   public Text gameText;
   public Text q1Text;
   public Text q2Text;
   public Text q3Text;
   public Text q4Text;
   public Text q5Text;
   public float timeRemaining = 120;
   public bool timerIsRunning = false;

   public void Start(){
       timerIsRunning = true;
   }

    // Update is called once per frame
    void Update() {
        float pos = xPos.position.x;
        var botLevel = new List<string>(){"life is a hallucination", "happiness is only an imaginations", "drown", "give up", "hurting", "things are not going right", "saddest thought", "bad days", "nothing can cure the soul", "happy would lose", "grief", "friends leave", "Breathing is hard"};
        
        if(timerIsRunning){
            if(timeRemaining > 0){
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
                Debug.Log(timeRemaining);
                try {
                    q1Text.text = botLevel[Mathf.FloorToInt(timeRemaining)%10];
                    q2Text.text = botLevel[Mathf.FloorToInt(timeRemaining)%3];
                    q3Text.text = botLevel[Mathf.FloorToInt(timeRemaining)%2];
                    q4Text.text = botLevel[Mathf.FloorToInt(timeRemaining)%3];
                    q5Text.text = botLevel[Mathf.FloorToInt(timeRemaining)%10];
                } catch{}
            } else {
                Debug.Log("Time is up");
                timeRemaining = 0;
                timerIsRunning = false;
                q1Text.enabled = false;
                q2Text.enabled = false;
                q3Text.enabled = false;
                q4Text.enabled = false;
                q5Text.enabled = false;
            }
        }
    }

    void DisplayTime(float timeToDisplay){
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay)/60;
        float seconds = Mathf.FloorToInt(timeToDisplay)%60;

        gameText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
