using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(FadeInToFull(1f, GetComponent<Text>()));
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(FadeOutToZero(1f, GetComponent<Text>()));
        }
            
    }

    public IEnumerator FadeInToFull(float i, Text text)
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
        while (text.color.a < 1.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a + (Time.deltaTime / i));
            yield return null;
        }
    }

    public IEnumerator FadeOutToZero(float i, Text text)
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, 1);
        while (text.color.a > 0.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a - (Time.deltaTime / i));
            yield return null;
        }
    }
}
