using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
   public Score scorePanel;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        BallScript ball =collision.GetComponent<BallScript>();
        if (ball!=null)
        {
            ball.Respawn();
            scorePanel.Goal();
        }
    }
}
