using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MusicManager : MonoBehaviour
{
    AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == ("InstructionScene") ){
            DontDestroyOnLoad(this.gameObject);
        }

        DestroyMusic();
        TimerVolume();
    }

    void DestroyMusic() {
        if(SceneManager.GetActiveScene().name == ("LoseScene") && this.gameObject.name == "Music") {
            Destroy(this.gameObject);
            //audioSource.volume = 0;
        }
        //else {
          //  audioSource.volume = 1;
        //}
    }
    void TimerVolume() {
        if(SceneManager.GetActiveScene().name == "LoseScene" && this.gameObject.name == "TickTock") {
            if(GameData.miniGameTimer <= 0 || GameData.miniClickCount == 0){
                audioSource.volume = 0;
            }
            else {
                audioSource.volume = 1;
            }
        }
    }
}
