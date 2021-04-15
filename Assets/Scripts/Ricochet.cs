using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ricochet : MonoBehaviour
{
    Score scorePanel;
    private void Start()
    {
        scorePanel = FindObjectOfType<Score>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        scorePanel.Ricochet(); 
    }
}
