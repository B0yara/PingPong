using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pod : MonoBehaviour
{
   public Transform upperPod;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        float x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        Vector2 buffer = transform.position;
        buffer.x = x;
        transform.position = buffer;
        buffer = upperPod.position;
        buffer.x = x;
        upperPod.position = buffer;
    }
}
