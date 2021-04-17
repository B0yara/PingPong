using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
   public GameObject settingsPanel;
    // Start is called before the first frame update
    public void Pause()
    {
        Time.timeScale = 0;
        settingsPanel.SetActive(true);
    }
    public void Play()
    {
        Time.timeScale = 1;
        settingsPanel.SetActive(false);
    }


}
