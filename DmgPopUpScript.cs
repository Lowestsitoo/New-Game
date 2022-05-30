using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DmgPopUpScript : MonoBehaviour
{

    float dmgDealt;
    
    static PlayerScript playerScript;
    // Start is called before the first frame update
    void Start()
    {
        
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        dmgDealt = playerScript.damageDealt;
        float convertTo = playerScript.damageDealt * 100;
        int damageTaken = Mathf.RoundToInt(convertTo);
        GetComponent<TextMesh>().text = damageTaken.ToString();
        Destroy(this.gameObject, 1.1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
}

