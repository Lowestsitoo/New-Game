using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{
  public static int highScore;
   public int moveSpeed = 20;
   Vector2 moveDirection;
   Enemy target;
   	Rigidbody2D rb;
    public Vector3 offset;
     ScoreManagerScript scoreManagerScript;
    Enemy enemyScript;
    private Vector2 screenBounds;
    private CameraShake camShake;  
    
  
    void Start()
    { 
        FindClosestEnemy();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        scoreManagerScript = GameObject.Find("Score Manager").GetComponent<ScoreManagerScript>();
        

          
    }

    // Update is called once per frame
    void Update()
    {   

    
    
    /*  if(transform.position.x <screenBounds.x - 2){
        Destroy(this.gameObject);
      }
       if(transform.position.y <screenBounds.y - 2){
        Destroy(this.gameObject);
      }         */
      //transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
      
         
        
    }
    void OnTriggerEnter2D(Collider2D other) {
  
       if(other.CompareTag("Ground")){
         Destroy(this.gameObject);
        }
        if(other.CompareTag("Wall")){
          Destroy(this.gameObject);      
 }
     }
    void FindClosestEnemy()
	{
		float distanceToClosestEnemy = Mathf.Infinity;
		Enemy closestEnemy = null;
		 Enemy[] allEnemies = GameObject.FindObjectsOfType<Enemy>();
  

		foreach (Enemy currentEnemy in allEnemies) {
			float distanceToEnemy = (currentEnemy.transform.position - this.transform.position).sqrMagnitude;
			if (distanceToEnemy < distanceToClosestEnemy) {
				distanceToClosestEnemy = distanceToEnemy;
        		distanceToClosestEnemy = distanceToEnemy;
				    closestEnemy = currentEnemy;
			}
      
     
	  rb = GetComponent<Rigidbody2D> ();
        
		moveDirection = (closestEnemy.transform.position    - transform.position ).normalized * moveSpeed;
		rb.velocity = new Vector2 (moveDirection.x, moveDirection.y); 
	
	}


    

  }
    
}
