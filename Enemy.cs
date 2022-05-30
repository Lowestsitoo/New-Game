using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject particle;
    public float speed;
    public float distance;
    private bool movingRight = true;
    public Transform groundDetection;
    public Transform wallDetection;
    CameraShake camShake;
    ScoreManagerScript scoreManagerScript;

 /*
  void OnCollisionEnter2D(Collision2D other) {
     if(other.gameObject.tag == "Bullet"){
                    camShake.CamShakeNow();
                    ScoreManagerScript.comboTime = 1f;
                    ScoreManagerScript.comboCount++;
                    Instantiate(particle, this.transform.position, Quaternion.identity);
                    Destroy(other.gameObject);
                    Destroy(this.gameObject);
     }
  
} */
    void Start(){
        camShake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<CameraShake>();
        scoreManagerScript = GameObject.FindGameObjectWithTag("Score Manager").GetComponent<ScoreManagerScript>();

}

    void Update() {
     
  

        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        RaycastHit2D wallInfo = Physics2D.Raycast(wallDetection.position, wallDetection.position - this.transform.right, distance);

        if (groundInfo.collider == false )
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
                transform.Rotate(0f, 180f, 0f);
            }
            else if (movingRight == false)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
                transform.Rotate(0f, 180f, 0f);
            }
           
            }
             if (wallInfo == true)
            {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
                transform.Rotate(0f, 180f, 0f);
            }
            else if (movingRight == false)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
                transform.Rotate(0f, 180f, 0f);
            }
        }
   }


   void OnTriggerEnter2D(Collider2D other) {
            if(other.CompareTag("Bullet")){
                    camShake.CamShakeNow();
                    ScoreManagerScript.Score += 10; 
                    scoreManagerScript.addComboCount();           
                    Destroy(other.gameObject);
                    Instantiate(particle, this.transform.position, Quaternion.identity);
                    Destroy(this.gameObject);
       }
         
     
 }
  
}
