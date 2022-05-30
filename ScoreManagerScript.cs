using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour
{
    [SerializeField] private ComboBar comboBar;
    public static int highScore;
    public static int Score, maxMulti = 4;
    public  int comboCount;
    public static float comboTime, min = 0.00f, timelapse = 1f;
    public BulletScript bulletScript;
    
    public Text ScoreText,HighScoreText, comboText;

    public double add = 0;
    string DoubleScore;
    public float chances;
   
    void Start() 
    {
        highScore = PlayerPrefs.GetInt("highScore",highScore);
        Score = 0;
        comboCount = 1;
        comboTime = 0f;
        chances = 0.05f;
     
    }

   
    void Update()
         {  
           
            if(comboTime >= min){
                comboTime -= timelapse * Time.deltaTime;
                 
                    
        }
        else {
            comboCount = 1;
            DoubleScore = "X1!!!";
        }
       
    
        comboText.text = DoubleScore.ToString();   
        ScoreText.text = Score.ToString();
        HighScoreText.text = highScore.ToString();
        if(Score> highScore){
                highScore = Score;
                 HighScoreText.text = Score.ToString();
         
        }
        
            PlayerPrefs.SetInt("highScore",highScore);
    }
       public void Multiply(){
            if(comboTime <= maxMulti){
                Score *= comboCount;
        }

            


        }


        public void addComboCount(){
                
                float prob = Random.Range(0.01f, 1f);
                if(prob <= chances){
                    comboTime = 1f;
                    DoubleScore = "X2!!!";
                    comboCount = 2;
                    Multiply();
                }          
             else {
                 DoubleScore = "X1!!!";
             }

        
     
        }
  }







