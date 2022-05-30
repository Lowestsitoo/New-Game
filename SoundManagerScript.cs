using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip BulletEnemy, Shoot, Dead, Fire, Jump,Hurt,Collect,Hit;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        
        BulletEnemy = Resources.Load<AudioClip>("BulletEnemy");
        Hit = Resources.Load<AudioClip>("Hit");
       
        Shoot = Resources.Load<AudioClip>("Shoot");
         Jump = Resources.Load<AudioClip>("Jump");
        Collect= Resources.Load<AudioClip>("Collect");
        Dead = Resources.Load<AudioClip>("Dead");
        Hurt = Resources.Load<AudioClip>("Hurt");
        audioSrc = GetComponent<AudioSource>();

        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "BulletEnemy":
                audioSrc.PlayOneShot(BulletEnemy);
                break;
            case "Dead":
                audioSrc.PlayOneShot(Dead);
                break;
            case "Shoot":
                audioSrc.PlayOneShot(Shoot);
                break;
            case "Jump":
                audioSrc.PlayOneShot(Jump);
                break;
            case "Collect":
                audioSrc.PlayOneShot(Collect);
                break;
        }

    }
}
