using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
   public float speed;

    // Start is called before the first frame update
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
      if (PlayerPrefs.GetString("ColorType")== "Britnes")
        {
            spriteRenderer.color = Color.HSVToRGB(0, 0f, PlayerPrefs.GetFloat("Color"));   
        }
        if (PlayerPrefs.GetString("ColorType") == "Hue")
        {
            spriteRenderer.color = Color.HSVToRGB(PlayerPrefs.GetFloat("Color"), 1f,1f );
        }
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Respawn()
    {
        float scale = Random.Range(0.03f, 0.1f);
        transform.localScale = new Vector2(scale, scale);
        transform.position = Vector3.zero;
        rb.velocity =Vector2.zero;
        StartCoroutine(CountDown());
    }
    IEnumerator  CountDown()
    {
        
      yield  return new WaitForSeconds(1f);
        Vector2 force;
        if (Random.Range(0f,1f)>0.5f)
        {
             force = new Vector2(Random.Range(-0.8f, 0.8f), -1f);
        }
        else
        {
            force = new Vector2(Random.Range(-0.8f, 0.8f), 1f);
        }
        rb.AddForce(force*speed);
        
    }
}
