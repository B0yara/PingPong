using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHColor : MonoBehaviour
{
    Image image;
    public Slider hueColor;
    public Slider vColor;
    public SpriteRenderer ball;
    private void Start()
    {
        image = GetComponent<Image>();
        if (PlayerPrefs.GetString("ColorType") == "Britnes")
        {
            vColor.value= PlayerPrefs.GetFloat("Color");
        }
        if (PlayerPrefs.GetString("ColorType") == "Hue")
        {
            hueColor.value = PlayerPrefs.GetFloat("Color");
        }
    }

    public void OnChangeHueColor(float hueColor)
    {
        image.color = Color.HSVToRGB(hueColor, 1f, 1f);
        PlayerPrefs.SetFloat("Color", hueColor);
        PlayerPrefs.SetString("ColorType", "Hue");
        if (ball != null)
        {
            ball.color = Color.HSVToRGB(hueColor, 1f, 1f);
        }
    }
    public void OnChangeBritnesColor(float vColor)
    {
        image.color = Color.HSVToRGB(0, 0f, vColor);
        PlayerPrefs.SetFloat("Color", vColor);
        PlayerPrefs.SetString("ColorType", "Britnes");
        if (ball != null)
        {
            ball.color = Color.HSVToRGB(0, 0f, vColor);
        }
    }
}
