using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] astroidPrefabs;

    [SerializeField] private float spawnLimitZLeft = -11.69f;
    [SerializeField] private float spawnLimitZRight = 11.6f;
    [SerializeField] private float spawnPosYTop = 14.5f;
    [SerializeField] private float spawnPosYBot = 11.5f;
   
    private float startDelay = 1.5f;
    public List<GameObject> asteroids;
    private int asteroidCount = 35;
    //public float distance = 10.0f;



    // Start is called before the first frame update
    void Start()
    {
        
        GameData.asteroidTotal = asteroidCount;
        StartCoroutine(SpawnAsteroids());
    }


    //spawn asteroids within a certain area with a delay
    IEnumerator SpawnAsteroids() {
        yield return new WaitForSeconds(startDelay);

        for (int i = 0; i < asteroidCount; i++)
        {
            //spawns many asteroids at once rather than one at a time in a specific area
            int which = Random.Range(0, asteroids.Count);
            Vector3 spawnPos = new Vector3(0, Random.Range(spawnPosYTop, spawnPosYBot), Random.Range(spawnLimitZLeft, spawnLimitZRight));
            Instantiate(asteroids[which], spawnPos, Random.rotation);

        }
    }
    
    

   


}
