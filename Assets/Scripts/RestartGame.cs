using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
    private Button restartButton;
    public string nextScene;

    // Start is called before the first frame update
    void Start()
    {
        restartButton = GetComponent<Button>();  
        restartButton.onClick.AddListener(OnMouseDown);
        
    }

    //set on the mouse, let's us restart game with all game data reset to original values
    void OnMouseDown() {
        GameData.choice = 0;
        GameData.holeCount1 = 0;
        GameData.holeCount2 = 0;
        //Debug.Log("restart successful, GameData.choice = : " + GameData.choice + ", GameData.holeCount1 = : " + GameData.holeCount1 + "GameData.holeCount2 = : " + GameData.holeCount2);
        SceneManager.LoadScene(nextScene);
    }
}
