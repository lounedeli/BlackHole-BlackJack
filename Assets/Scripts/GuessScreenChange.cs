using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GuessScreenChange : MonoBehaviour
{
    private Button button;
    private int guessChoice;
    public Text choiceText;
    public string nextScene;
    private float elapsedTime;
    private float sceneDelay = 1.75f;
    [SerializeField] private bool buttonClicked = false;

    
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnMouseDown);   
    }

    // Update is called once per frame
    void Update()
    { 
        SceneChange();
    }
    
    void OnMouseDown() {
        buttonClicked = true;
   
        if(this.gameObject.name == "Button1") {
            guessChoice = 1;
            GameData.choice = guessChoice;
            choiceText.text = "Your Choice was: Black Hole  " + GameData.choice + "!" + "\nLet's see if you were right...";
        }

        if(this.gameObject.name == "Button2") {
            guessChoice = 2;
            GameData.choice = guessChoice;
            choiceText.text = "Your Choice was: Black Hole " + GameData.choice + "!" + "\nLet's see if you were right...";
                
            }
            
        }
    void SceneChange() {

        if(buttonClicked == true) {
            elapsedTime += Time.deltaTime;
            if(elapsedTime >= sceneDelay)
            {
                if(GameData.choice == 1)
                {
                    //Debug.Log("button1 scene change");
                    SceneManager.LoadScene(nextScene);
                }
                else if(GameData.choice == 2)
                {
                    //Debug.Log("button2 scene change");
                    SceneManager.LoadScene(nextScene);
                }
            }
        }
    }
}

