using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeViews : MonoBehaviour
{
    [SerializeField]

    private CanvasGroup _canvasGroup;

    public CanvasGroup CanvasG { get { return _canvasGroup; } }

    private Image _fadeImage; 
    public Image FadeImage { get { return _fadeImage; } }
}
