using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    public Transform leftWall;
    public Transform rightWall;
    public Transform upperGoal;
    public Transform downGoal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int width = Camera.main.pixelWidth;
        int height = Camera.main.pixelHeight;
        leftWall.position = Camera.main.ScreenToWorldPoint(new Vector3 (0 , height/2, 0));
        rightWall.position = Camera.main.ScreenToWorldPoint(new Vector3(width, height / 2, 0));
        upperGoal.position = Camera.main.ScreenToWorldPoint(new Vector3(width/2, height, 0));
        downGoal.position = Camera.main.ScreenToWorldPoint(new Vector3(width/2, 0, 0));
    }
}
