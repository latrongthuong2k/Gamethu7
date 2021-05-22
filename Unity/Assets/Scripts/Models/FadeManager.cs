using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeManager : MonoBehaviour

{   
    [SerializeField]
    private float fadeTime = 1.0f;
    IEnumerator FadeIn(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 1.0f;
        while (canvasGroup.alpha > 0)
        
        {
            canvasGroup.alpha -= Time.deltaTime * (1.0f / fadeTime);   
            if (canvasGroup.alpha <= 0)
                canvasGroup.alpha = 0f;
                yield return null;
        }
    }


//
 public IEnumerator FadeOut(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 0.0f;
        while (canvasGroup.alpha < 1.0f)
        
        {
            canvasGroup.alpha += Time.deltaTime * (1.0f / fadeTime);   
            if (canvasGroup.alpha <= 1.0f)
                canvasGroup.alpha = 1.0f;
                yield return null;
        }
    }
}