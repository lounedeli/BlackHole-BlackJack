using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRemainingAsteroids : MonoBehaviour
{
    private int sum;
   
   //destroys remaining asteroids that hit ground object
    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Projectile") {
            sum++;
            GameData.asteroidTotal--;
            Destroy(other.gameObject);
        }
       
    }
}
