using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] private int choice;
    public string loseScene;
    //public string winScene;
    public string restartScene;
    public GameObject correctGuess;
    public GameObject incorrectGuess;
    public GameObject tieScreen;
    private float sceneTimeDelay = 1.5f;
    private float elapsedTime;
    

    // Update is called once per frame
    void Update()
    {
        if(GameData.asteroidTotal == 0) {
           elapsedTime += Time.deltaTime; 
        }
        
        choice = GameData.choice;
        CheckChoice();
    }

    void CheckChoice() {
        if(GameData.asteroidTotal <= 0) {
             if(GameData.choice == 1 && (GameData.holeCount1 > GameData.holeCount2)) {
                //Debug.Log("correct choice, counter 1 is higher"); 
                correctGuess.gameObject.SetActive(true);
             }
              
            else if(GameData.choice == 2 && (GameData.holeCount2 > GameData.holeCount1)) {
                //Debug.Log("correct choice, counter 2 is higher");
                correctGuess.gameObject.SetActive(true);
            }
            else if(GameData.choice == 1 && (GameData.holeCount1 < GameData.holeCount2)) {
                //Debug.Log("wrong choice, counter 2 is higher, you lose!");
                incorrectGuess.gameObject.SetActive(true);

                if(elapsedTime > sceneTimeDelay) {
                   SceneManager.LoadScene(loseScene); 
                }
            }
            else if(GameData.choice == 2 && (GameData.holeCount2 < GameData.holeCount1)){
                //Debug.Log("wrong choice, counter 1 is higher, you lose!");
                incorrectGuess.gameObject.SetActive(true);

                if(elapsedTime > sceneTimeDelay) {
                   SceneManager.LoadScene(loseScene); 
                }
            }
            else if((GameData.choice == 2 || GameData.choice == 1) && (GameData.holeCount1 == GameData.holeCount2)) {
                //Debug.Log("it's a tie! let's try again!");
                tieScreen.gameObject.SetActive(true);
                if(elapsedTime > sceneTimeDelay) {
                   SceneManager.LoadScene(restartScene); 
                }

            }
        }    
        
    }
}
