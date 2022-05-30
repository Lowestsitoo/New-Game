using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPoint;
    public SoundManagerScript SoundManagerScript;
    float fireRate = 1f;
    private GameObject[] Enemy;
    public static float health;
    public Transform deathPos,spawnPos;
    public GameObject DmgPopUp;
    public float damageDealt;
    
    void Start()
    {   
        health = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {         
        if(bulletPoint == null){
             bulletPoint = GameObject.FindGameObjectWithTag("Bullet Point").transform;

        }     
      
            if (Input.GetButtonUp("Fire1"))
        {
          Instantiate(bullet,bulletPoint.position, Quaternion.identity);
             SoundManagerScript.PlaySound("Shoot");
        }
        if ( health <= 0){
            transform.position = deathPos.position;
        StartCoroutine(Respawn());


        }


    }
    
    IEnumerator Respawn(){

        yield return new WaitForSeconds(2);
        transform.position = spawnPos.position;
        health = 1f;

    }
    /*void FindTarget(){
                    

        if (Enemy == null || Enemy.health <= 0)
            Enemy = Enemy.GetClosestEnemy(turretTop, filter: enemy => enemy.health > 0);

        if (target != null)
        {
            Vector3 targetDir = target.transform.position - transform.position;
            // Rotating in 2D Plane...
            targetDir.y = 0.0f;
            targetDir = targetDir.normalized;

            Vector3 currentDir = turretTop.forward;

            currentDir = Vector3.RotateTowards(currentDir, targetDir, turnRateRadians*Time.deltaTime, 1.0f);

            Quaternion qDir = new Quaternion();
            qDir.SetLookRotation(currentDir, Vector3.up);
            turretTop.rotation = qDir;
        }
    }

}*/

    IEnumerator TakeTheDamage(float waitTime){
        
        
        Instantiate(DmgPopUp, new Vector3 (transform.position.x, transform.position.y + 0.5f , this.transform.position.z), Quaternion.identity);
        yield return new WaitForSeconds(waitTime);        
       
}


    void OnCollisionStay2D(Collision2D other) {
    
        
        if(other.gameObject.tag == "Enemy"){
        damageDealt = 0.05f;
        health -= damageDealt;
        StartCoroutine(TakeTheDamage(1f));
      }
}


}
