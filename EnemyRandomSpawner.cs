using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomSpawner : MonoBehaviour
{

   public GameObject Enemy;
    float timeBtwSpawn = 3f; //gap betwwen spawn
     int PosRandom;
   // public int pos1, pos2, pos3;
     float startTimeBtwSpawn = 3f;
    float decreaseTime = 0.05f;
    public float minTime = 1.0f;
    public Transform[] spawnPoints;
    
    void Start() {

        timeBtwSpawn = startTimeBtwSpawn;
       
   }
    
    void Update()
    {
        
        if(timeBtwSpawn <= 0){
            PosRandom  = Random.Range(0,spawnPoints.Length);
            Instantiate(Enemy, spawnPoints[PosRandom].position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn <= minTime){
            timeBtwSpawn = minTime;
                        } 
                 else {
                        startTimeBtwSpawn =- decreaseTime;
                    }
            
        }
        else {
            timeBtwSpawn -= Time.deltaTime;
            //this comment is for shitty purposes
        }

         
         
        } 



        }




    


