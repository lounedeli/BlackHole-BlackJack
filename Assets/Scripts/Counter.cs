using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public Text counterText;
    public Text counterText2;
    public int count = 0;
    public int count1 = 0;
    
    private void Start()
    {
        
        asteroidPrefab = GameObject.FindWithTag("Projectile");

        count = 0;
        count1 = 0;
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Projectile" && this.gameObject.tag == "BlackHole1") 
        {
            count += 1;
            
            counterText.text = "Black Hole 1 : " + count;
            GameData.holeCount1 = count;
            Destroy(other.gameObject);
            GameData.asteroidTotal--;
        }

       else if(other.gameObject.tag == "Projectile" && this.gameObject.tag == "BlackHole2") 
        {
            count1 += 1;
            counterText2.text = "Black Hole 2 : " + count1;
            GameData.holeCount2 = count1;
            Destroy(other.gameObject);
            GameData.asteroidTotal--;
        }
        
    }

}
