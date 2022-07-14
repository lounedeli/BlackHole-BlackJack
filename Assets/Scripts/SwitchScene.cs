using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    // Start is called before the first frame update
    private Button startButton;
    public string nextScene;
    // Start is called before the first frame update
    void Start()
    {
        startButton = GetComponent<Button>();  
        startButton.onClick.AddListener(OnMouseDown);
    }

    //set on the mouse, let's us restart game with all game data reset to original values
    void OnMouseDown() {
        
        SceneManager.LoadScene(nextScene);
    }
}
