using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShopScript : MonoBehaviour
{

    [SerializeField]
    public Transform weaponSlot;
    public int currentWeaponCount;
    public int totalWeaponCount;
    
    public GameObject currentWeapon;
    public GameObject itemMenu;
   
    public List<GameObject> Guns = new List<GameObject>(); 
    bool isCreated;
    public PlayerMovement PlayerMovement;
    // Start is called before the first frame update
    void Start()
    {   
        totalWeaponCount = Guns.Count;
        currentWeapon = Guns[0];
        isCreated = false;
        var pistol = Instantiate(Guns[0],weaponSlot.position, Quaternion.identity);
        pistol.transform.parent = weaponSlot.transform;
        pistol.gameObject.tag = "Current Weapon";
        //ano gani to ah
        //nalipat nako
        //indi ka process utok ko
    }

    // Update is called once per frame
    void Update()
    {
          currentWeaponCount = Guns.Count;
        
    }
    public void Pause(){
        Time.timeScale = 0;
        itemMenu.SetActive(true);
    }
    public void Upgrade(){
        switch(currentWeaponCount){
            case 0:
                
            break;
            case 1:

            break;
            case 2:

            break;
            case 3:

            break;
        }
    }
    public void Bazooka(){

        //check if present
        if(!isCreated){
            if(gameObject.tag == "Current Weapon"){
                Destroy(gameObject);
            }
           var bazooka = Instantiate(Guns[4],weaponSlot.position, Quaternion.identity);
            isCreated = true;
            bazooka.transform.parent = weaponSlot.transform;
            Destroy(currentWeapon);
            itemMenu.SetActive(false);
        }
      
       
    }
    public void HealthUp(){
        PlayerScript.health += .5f;
        itemMenu.SetActive(false);
    }

    public void DoubleScore(){
        // i got 1 day and wrote 2 lines of code
        ScoreManagerScript.comboTime = 5f;
        itemMenu.SetActive(false);
    }
    public void MovementUp(){
        float doubleSpeed = 60f;
        PlayerMovement.runSpeed = doubleSpeed;
        itemMenu.SetActive(false);
    }   
}
