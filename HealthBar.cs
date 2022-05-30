using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    Vector3 localScale;
    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerScript.health > 1f){
            localScale.x = 1f;
        }
        else{
            localScale.x = PlayerScript.health;
            transform.localScale = localScale;
        }
    }
}
