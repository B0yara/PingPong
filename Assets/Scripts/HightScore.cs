using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HightScore : MonoBehaviour
{
    Text hightScore;
    public Score scorePanel;
    // Start is called before the first frame update
    void Start()
    {
       hightScore = GetComponent<Text>();
        hightScore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    public void ResetHightScore()
    {
        hightScore.text = "0";

        PlayerPrefs.SetInt("HighScore", 0);
        if (scorePanel != null)
        {
            scorePanel.RestoreHightScore();
        }

    }
}
