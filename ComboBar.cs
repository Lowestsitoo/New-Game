using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboBar : MonoBehaviour
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
       if(ScoreManagerScript.comboTime > 1f){
            localScale.x = 1f;
        }
        else{
        localScale.x = ScoreManagerScript.comboTime;
        transform.localScale = localScale;
        }
    }
}
