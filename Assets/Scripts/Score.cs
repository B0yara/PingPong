using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreLabel;
    public Text highScoreLabel;
    int score = 0;
    int highscore;
    // Start is called before the first frame update
    void Start()
    {
         highscore= PlayerPrefs.GetInt("HighScore");
        highScoreLabel.text = "HighScore: " + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ricochet()
    {
        score++;
        scoreLabel.text = score.ToString();
    }
    public void Goal()
    {
        
        
        if(score>highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("HighScore", highscore);
            highScoreLabel.text = "HighScore: " + highscore.ToString();
        }
        score = 0;
        scoreLabel.text = "0";
    }
    public void RestoreHightScore()
    {
        highscore = 0;
        PlayerPrefs.SetInt("HighScore", highscore);
        highScoreLabel.text = "HighScore: " + highscore.ToString();
    }
}
