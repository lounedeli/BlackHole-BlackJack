using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidClick : MonoBehaviour
{
    public GameObject loseScreen;
    public GameObject winScreen;
    private float timer;
    private float elapsedTime;
    public Text timerText; 
    private int clickCount = 9;

    // Start is called before the first frame update
    void Start()
    {
       timer = 10.0f;
       elapsedTime = timer;
       GameData.miniClickCount = clickCount;
       GameData.miniGameTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {
        Timer();

        if((timer > 0) && (GameData.miniClickCount <= 0)) {
            timer = elapsedTime;
            timerText.text = "Timer: " + elapsedTime.ToString("0");
            winScreen.gameObject.SetActive(true);
        }
        else if((timer <= 0) && (GameData.miniClickCount >= 0)) {
            timer = 0;
            timerText.text = "Timer: " + timer.ToString("0");
            loseScreen.gameObject.SetActive(true);
        }
    }

    void Timer() {
        timer -= Time.deltaTime;
        GameData.miniGameTimer = timer;
        //Debug.Log("GameData.miniGameTimer: " + GameData.miniGameTimer);
        timerText.text = "Timer: " + timer.ToString("0");
        if (timer <= 0) {
            timer = 0;
            
            timerText.text = "Timer: " + timer.ToString("0");
        }
    }
     void OnMouseDown() {
      if(this.gameObject.tag == "Projectile") {
        clickCount = clickCount - 1;
        GameData.miniClickCount = GameData.miniClickCount - 1;
        Debug.Log(GameData.miniClickCount);
        Destroy(this.gameObject);
      }
      
 }
    
}
